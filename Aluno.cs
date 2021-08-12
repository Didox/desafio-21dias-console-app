using System;
using System.Collections.Generic;

namespace console_desafio21dias_api
{
  class Aluno
  {
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
  }
}