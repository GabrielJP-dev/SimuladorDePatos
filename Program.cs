using System;

class Program
{

    /*fazer um menu de jogos
criar mais 3 patos
mostrar todos os patos e oque eles podem fazer 

depois de selecionar o pato, ele vai poder soltar os poderes a vontade.*/
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
