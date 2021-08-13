using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace console_desafio21dias_api
{
  class Aluno
  {
    #region "Propriedades"
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }

    private List<double> notas;
    public List<double> Notas 
    { 
      get
      {
        if(this.notas == null) this.notas = new List<double>();
        return this.notas;
      }
      set
      {
        this.notas = value;
      }
    }

    #endregion

    #region Metodos de instancia
    public double CalcularMedia()
    {
      var somaNotas = 0.0;
      foreach(var nota in this.Notas)
      {
        somaNotas += nota;
      }
      return somaNotas / this.Notas.Count;
    }

    public string Situacao()
    {
      return this.CalcularMedia() >= 7 ? "Aprovado" : "Reprovado";
    }

    public void Apagar()
    {
      Aluno.ApagarPorId(this.Id);
    }

    public void Salvar()
    {
      if(this.Id > 0)
      {
        Aluno.Atualizar(this);
      }
      else
      {
        Aluno.Incluir(this);
      }
    }

    #endregion

    #region Metodos de classe ou staticos
    private static string connectionString()
    {
      // create database desafio21diasapi
      /*
        CREATE TABLE Alunos (
            id int IDENTITY(1,1) PRIMARY KEY,
            nome varchar(150) NOT NULL,
            matricula varchar(15) NOT NULL,
            notas varchar(255)
        );
      */
      return "Server=localhost;database=desafio21diasapi;user=sa;password=!1#2a3d4c5g6v";
    }

    public static void Incluir(Aluno aluno)
    {
      using(SqlConnection sqlConn = new SqlConnection(connectionString()))
      {
        sqlConn.Open();
        
        SqlCommand sqlCommand = new SqlCommand($"insert into alunos(nome, matricula, notas)values(@nome, @matricula, @notas)", sqlConn);
        sqlCommand.Parameters.Add("@nome", SqlDbType.VarChar);
        sqlCommand.Parameters["@nome"].Value = aluno.Nome;

        sqlCommand.Parameters.AddWithValue("@matricula", aluno.Matricula);
        sqlCommand.Parameters.AddWithValue("@notas", string.Join(",", aluno.Notas.ToArray()));
        
        sqlCommand.ExecuteNonQuery();

        sqlConn.Close();
      }
    }
    public static void Atualizar(Aluno aluno)
    {
      SqlConnection sqlConn = new SqlConnection(connectionString());
      sqlConn.Open();
      
      SqlCommand sqlCommand = new SqlCommand($"update alunos set nome=@nome, matricula=@matricula, notas=@notas where id=@id", sqlConn);
      sqlCommand.Parameters.AddWithValue("@id", aluno.Id);
      sqlCommand.Parameters.AddWithValue("@nome", aluno.Nome);
      sqlCommand.Parameters.AddWithValue("@matricula", aluno.Matricula);
      sqlCommand.Parameters.AddWithValue("@notas", string.Join(",", aluno.Notas.ToArray()));
      sqlCommand.ExecuteNonQuery();

      sqlConn.Close();
      sqlConn.Dispose();
    }

    public static void ApagarPorId(int id)
    {
      SqlConnection sqlConn = new SqlConnection(connectionString());
      sqlConn.Open();
      
      SqlCommand sqlCommand = new SqlCommand($"delete from alunos where id={id}", sqlConn);
      sqlCommand.ExecuteNonQuery();

      sqlConn.Close();
      sqlConn.Dispose();
    }

    public static List<Aluno> Todos()
    {
      var alunos = new List<Aluno>();

      SqlConnection sqlConn = new SqlConnection(connectionString());
      sqlConn.Open();
      
      SqlCommand sqlCommand = new SqlCommand("select * from alunos", sqlConn);
      var reader = sqlCommand.ExecuteReader();
      while(reader.Read())
      {
        var notas = new List<double>();
        string strNotas = reader["notas"].ToString();
        foreach(var nota in strNotas.Split(','))
        {
          notas.Add(Convert.ToDouble(nota));
        }

        var aluno = new Aluno()
        {
          Id = Convert.ToInt32(reader["id"]),
          Nome = reader["nome"].ToString(),
          Matricula = reader["matricula"].ToString(),
          Notas = notas,
        };

        alunos.Add(aluno);
      }

      sqlConn.Close();
      sqlConn.Dispose();
      return alunos;
    }

    #endregion
  }
}