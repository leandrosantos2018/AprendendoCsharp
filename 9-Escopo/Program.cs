using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");

        int idade = 16;
        bool acompanhandoDosPais = false;

        string textAdicional;

        if(acompanhandoDosPais == true)
        {
            textAdicional = "João esta acompanhando";
        }
        else
        {
            textAdicional = "João não esta acompanhado";
        }

        if (idade >= 18 || acompanhandoDosPais)
        {
            Console.WriteLine( textAdicional);
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine(textAdicional);
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}