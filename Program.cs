using System;

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

        // int[] itens = new int[]{1,2,3,4,5,6,7,8,9,10};
        // foreach(int item in itens)
        // {
        //   Console.WriteLine(item);
        // }



        while(true)
        {
          Console.WriteLine("Digite\n1 - para sair\n0 - para continuar");
          int sair = Convert.ToInt32(Console.ReadLine());
          if(sair == 1) break;
          else if(sair == 2) continue;

          Console.WriteLine("Opaaaa estou por aqui");
        }



        return;
        
        
        
        
        
        
        
        
        
        
        
        
        int caseSwitch = 2;

        if(caseSwitch == 1)
        {
            Console.WriteLine("Case 1");
        }
        else if(caseSwitch == 2)
        {
            Console.WriteLine("Case 2");
        }
        else
        {
            Console.WriteLine("Default case");
        }


        switch (caseSwitch)
        {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }


      //camelCase
      //PascalCase
      //unders_core

      Console.WriteLine("Digite o primeiro número");
      var numeroUm = 11;//Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Digite o segundo número");
      int numeroDois = 20;//Convert.ToInt32(Console.ReadLine());

      var soma = numeroUm * numeroDois;

      // Console.WriteLine($"Qual é o resultado da soma dos números {numeroUm} + {numeroDois} ?");
      Console.WriteLine($"Digite o numero premiado?");
      int resultado = 20;//Convert.ToInt32(Console.ReadLine());

      if (soma == resultado || resultado == 1 || resultado == 10 || (resultado >= 100 && resultado <= 200))
      {
        Console.WriteLine($"Parabéns você acertou o resulado: {soma}");
      }
      else if (resultado == 20)
      {
        Console.WriteLine($"Você acertou a opção extraordinária, incrivel");
      }
      else
      {
        Console.WriteLine($"O resultado é {soma}, você errou, tente novamente na próxima");
      }
    }
  }
}
