using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 12 - Investimento ao Longo Prazo.");

        double fatorRendemento = 1.005;
        double investimento = 1000;

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendemento;
                
            }
            fatorRendemento +=  0.001;
        }
        Console.WriteLine("Depois de 5 anos terá R$ " + investimento);



        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }


}