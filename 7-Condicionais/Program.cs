using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");

        int idade = 16;
        bool acompanhandoDosPais = false;

        if (idade >= 18 || acompanhandoDosPais)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("NNão pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}