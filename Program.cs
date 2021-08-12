using System;
using System.Collections.Generic;

namespace console_desafio21dias_api
{
  class Program
  {
    static void Main(string[] args)
    {
        
        /*
        Daniel é um agricultor e precisa de um programa que ao digitar o numero inicial 1 e final 10, o programa mostra
        repetidamente todos os números na tela 
        */
        
        // Console.WriteLine("Digite o número inicial");
        // var numeroInicial = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Digite o número final");
        // int numeroFinal = Convert.ToInt32(Console.ReadLine());
        
        // int indice = numeroInicial;
        // while(indice <= numeroFinal)
        // {
        //   Console.WriteLine(indice);
        //   indice++;
        // }

        // for(int i = numeroInicial; i <= numeroFinal; i++)
        // {
        //   Console.WriteLine(i);
        // }


        // int[][] alunos;

        // alunos[0][0] = "Danilo";
        // alunos[1][0] = "001";
        // alunos[2][0] = "10, 8, 5";

        // alunos[0][1] = "Jaison";
        // alunos[1][1] = "001";
        // alunos[2][1] = "10, 8, 5";

        // alunos[0][2] = "Sheila";
        // alunos[1][2] = "001";
        // alunos[2][2] = "10, 8, 5";

        // const int NOME = 0
        // const int MATRICULA = 1
        // const int NOTAS = 2

        // int linha = 0

        // alunos[linha][NOME]
        // alunos[linha][MATRICULA]
        // alunos[linha][NOTAS]

        /*
        Valkiria é a diretora da escola Mundo Melhor
        Ela precisa de um programa que armazene alunos com suas matrículas e notas em uma tabela
        no final ela tem a necessidade de saber se o aluno foi aprovado ou não.
        Faça um programa para resolver a questão da Valkiria
        */

        Console.WriteLine("Bem vinda, Valkiria!\n");
        var opcao = "s";
        List<Aluno> alunos = new List<Aluno>();
        while(opcao.ToLower() == "s")
        {
          var aluno = new Aluno();

          Console.WriteLine("Digite o nome do aluno:");
          aluno.Nome = Console.ReadLine();
          Console.WriteLine("Digite a matrícula do aluno:");
          aluno.Matricula = Console.ReadLine();
          Console.WriteLine("Digite as notas do aluno:");
          for (int i = 0; i < 3; i++)
          {
              Console.WriteLine($"{i + 1}ª nota:");
              aluno.Notas.Add( Convert.ToDouble(Console.ReadLine()) );
          }
          alunos.Add(aluno);
          
          Console.Clear();
          Console.WriteLine("Cadastrar outro aluno? s/n");
          opcao = Console.ReadLine();
        }
        Console.Clear();
        foreach(var aluno in alunos)
        {
            Console.WriteLine("────────────────────────────────");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Matrícula: {aluno.Matricula}");
            Console.WriteLine($"Notas: {string.Join(",", aluno.Notas.ToArray())}");
            Console.WriteLine($"Média: {aluno.CalcularMedia()}");
            Console.WriteLine($"Situação: {aluno.Situacao()}");
            Console.WriteLine("────────────────────────────────");
        }
        Console.WriteLine("────────────────────────────────");

        
        
        // List<dynamic> alunos = new List<dynamic>();
        // alunos.Add(new {
        //   Nome = "Danilo",
        //   Matricula = "001",
        //   Notas = "10, 8, 7"
        // });

        // alunos.Add(new {
        //   Nome = "Sheila",
        //   Matricula = "001",
        //   Notas = "10, 8, 7"
        // });

        // alunos.Add(new {
        //   Nome = "Stela",
        //   Matricula = "001",
        //   Notas = "10, 8, 7"
        // });

        // foreach(var aluno in alunos)
        // {
        //   Console.WriteLine("-------------------");
        //   Console.WriteLine($"Nome: {aluno.Nome}");
        //   Console.WriteLine($"Matricula: {aluno.Matricula}");
        //   Console.WriteLine($"Notas: {aluno.Notas}");
        // }

        // return;

        // while(true)
        // {
        //   Console.WriteLine("Digite\n1 - para sair\n0 - para continuar");
        //   int sair = Convert.ToInt32(Console.ReadLine());
        //   if(sair == 1) break;
        //   else if(sair == 2) continue;

        //   Console.WriteLine("Opaaaa estou por aqui");
        // }



        // return;
        
        
        
        
        
        
        
        
        
        
        
        
        // int caseSwitch = 2;

        // if(caseSwitch == 1)
        // {
        //     Console.WriteLine("Case 1");
        // }
        // else if(caseSwitch == 2)
        // {
        //     Console.WriteLine("Case 2");
        // }
        // else
        // {
        //     Console.WriteLine("Default case");
        // }


        // switch (caseSwitch)
        // {
        //     case 1:
        //         Console.WriteLine("Case 1");
        //         break;
        //     case 2:
        //         Console.WriteLine("Case 2");
        //         break;
        //     default:
        //         Console.WriteLine("Default case");
        //         break;
        // }


      //camelCase
      //PascalCase
      //unders_core

      // Console.WriteLine("Digite o primeiro número");
      // var numeroUm = 11;//Convert.ToInt32(Console.ReadLine());

      // Console.WriteLine("Digite o segundo número");
      // int numeroDois = 20;//Convert.ToInt32(Console.ReadLine());

      // var soma = numeroUm * numeroDois;

      // Console.WriteLine($"Qual é o resultado da soma dos números {numeroUm} + {numeroDois} ?");
      // Console.WriteLine($"Digite o numero premiado?");
      // int resultado = 20;//Convert.ToInt32(Console.ReadLine());

      // if (soma == resultado || resultado == 1 || resultado == 10 || (resultado >= 100 && resultado <= 200))
      // {
      //   Console.WriteLine($"Parabéns você acertou o resulado: {soma}");
      // }
      // else if (resultado == 20)
      // {
      //   Console.WriteLine($"Você acertou a opção extraordinária, incrivel");
      // }
      // else
      // {
      //   Console.WriteLine($"O resultado é {soma}, você errou, tente novamente na próxima");
      // }
    }
  }
}
