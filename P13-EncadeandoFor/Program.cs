using System;

class Programa
{

    static void Main(string[] args)
    {

        Console.WriteLine("Executando projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****

        for(int contadorLinha = 0;contadorLinha < 10; contadorLinha++)
        {
            
            for (int contador = 0;contador< 10; contador++)
            {
                Console.Write("*");
                if (contador >= contadorLinha)
                {
                    break;
                }            }
            Console.WriteLine();
        }
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}


