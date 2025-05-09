public class PatoDeCabeçaVermelha : Pato, Voar {

    public PatoDeCabeçaVermelha() {
        Nome = "PatoDeCabeçaVermelha";
       
    }
    public override void Mostrar()
    {
        base.Mostrar();
    }

    public void voando()
    {
        Console.WriteLine("Voando");
    }

    public override void Nadar()
    {
        base.Nadar();
    }
}
