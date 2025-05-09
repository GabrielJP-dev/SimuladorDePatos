public class PatoReal : Pato, Voar, Quack{

    public PatoReal() {
        Nome = "PatoReal";
       
    }
    public override void Mostrar()
    {
        Console.WriteLine("SOU UM PATO REAL.");
    }

    public override void Nadar()
    {
        Console.WriteLine("NADO COM CLASSE");
    }
}