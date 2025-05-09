public class PatoDeBorracha : Pato, Quack {

    public PatoDeBorracha() {
        Nome = "PatoDeBorracha";
       
    }
    public override void Mostrar()
    {
        base.Mostrar();
    }

    public void falar()
    {
        Console.WriteLine("QUAACK");
    }

    public override void Nadar()
    {
        Console.WriteLine("Eu não nado, eu boio");
    }
}