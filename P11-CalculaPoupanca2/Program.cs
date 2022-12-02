using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 10 - Calcula Poupança 2 ");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        // calculando mes a mes com while

      /*  int mes = 1;
        while (mes <= 12)
        {

            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no Mes: " + mes + " você tem R$ " + investimento);
            mes++;

        }*/

        // calculando mes a mes com for
       for (int i = 1; i <= 12; i++)
         {

             investimento = investimento + investimento * 0.005;
             Console.WriteLine("no Mes: " + i + " você tem R$ " + investimento);


         }
       


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }


}