using System;

class Program
{
    static void Main(string[] args)
    {

         Console.WriteLine("PATO DE BORRACHA AMARELINHO");

        PatoDeBorracha amarelinho = new PatoDeBorracha();

        amarelinho.Mostrar();
        amarelinho.Nadar();
        amarelinho.falar();

        Console.WriteLine("SOU UM PATINHO REAL");

        PatoReal rei = new PatoReal();

        rei.Mostrar();
        rei.Nadar();

        Console.WriteLine("SOU UM PATO DE CABEÇA VERMELHA");


        PatoDeCabeçaVermelha foguinho = new PatoDeCabeçaVermelha();

        foguinho.Mostrar();
        foguinho.Nadar();
        foguinho.voando();

     
    }
}
