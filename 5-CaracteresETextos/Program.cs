using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando p Projero 5 - Caractres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        string primeiraFrase = "Alura -  Cursos de Tecnologia ";

        Console.WriteLine(primeiraFrase + 2022);

        string[] curso = { "Javascript", "C#", "PHP" };

        Console.WriteLine(curso[1]);

        string curso2 = @"Curso:" +
" - Go " +
"- C# " +
"- Python";
        

        Console.WriteLine(curso2 );

        Console.WriteLine("Tecle enter para fechar...");

        Console.ReadLine();


    }
}