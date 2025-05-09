using System;

class Program
{

    /*fazer um menu de jogos
criar mais 3 patos
mostrar todos os patos e oque eles podem fazer 

depois de selecionar o pato, ele vai poder soltar os poderes a vontade.*/
    static void Main(string[] args)
    {

      List<Pato> Patos = new List<Pato>{
        new CyberDuck(),
        new GodDuck(),
        new EchoWarriorDuck(),
        new KnightDuck(),
        new PatoDeBorracha(),
        new PatoDeCabeçaVermelha(),
        new PatoReal(),
        new RocketDuck(),
        new RubberNinjaDuck(),
        new StealthDuck()

      };

     int escolha;
        do
        {
            Console.Clear();
            Console.WriteLine("=== 🦆 MENU DE PATOS ===");
            for (int i = 0; i < Patos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Patos[i].Nome}");
            }
            Console.WriteLine("0. Sair");

            Console.Write("\nEscolha um pato: ");
            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out escolha) || escolha < 0 || escolha > Patos.Count)
            {
                Console.WriteLine("❌ Entrada inválida. Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            if (escolha == 0) break;

            Pato patoSelecionado = Patos[escolha - 1];

            int poderEscolhido;
            do
            {
                Console.Clear();
                Console.WriteLine($"🐤 {patoSelecionado.Nome} — Poderes disponíveis:\n");

                int index = 1;
                var poderes = new List<Action>();

                if (patoSelecionado is Voar f)
                {
                    Console.WriteLine($"{index}. Voar");
                    poderes.Add(() => f.voando());
                    index++;
                }

                if (patoSelecionado is Quack q)
                {
                    Console.WriteLine($"{index}. Grasnar");
                    poderes.Add(() => q.falar());
                    index++;
                }

                if (patoSelecionado is IInvisibility inv)
                {
                    Console.WriteLine($"{index}. Ficar Invisível");
                    poderes.Add(() => inv.Invisível());
                    index++;
                }

                if (patoSelecionado is ILaserEyes laser)
                {
                    Console.WriteLine($"{index}. Laser nos Olhos");
                    poderes.Add(() => laser.ILaserEyes());
                    index++;
                }

                if (patoSelecionado is IShieldWings shield)
                {
                    Console.WriteLine($"{index}. Asas Escudo");
                    poderes.Add(() => shield.ShieldWings());
                    index++;
                }

                if (patoSelecionado is ITeleport tp)
                {
                    Console.WriteLine($"{index}. Teleporte");
                    poderes.Add(() => tp.Teleport());
                    index++;
                }

                Console.WriteLine("0. Voltar");

                Console.Write("\nEscolha o poder a usar: ");
                string? entradaPoder = Console.ReadLine();
                if (!int.TryParse(entradaPoder, out poderEscolhido) || poderEscolhido < 0 || poderEscolhido > poderes.Count)
                {
                    Console.WriteLine("❌ Entrada inválida. Pressione Enter para continuar...");
                    Console.ReadLine();
                    continue;
                }

                if (poderEscolhido == 0) break;

                Console.WriteLine();
                poderes[poderEscolhido - 1].Invoke();

                Console.WriteLine("\n✅ Poder usado! Pressione Enter para continuar...");
                Console.ReadLine();

            } while (poderEscolhido != 0);

        } while (escolha != 0);

        Console.WriteLine("\nPrograma finalizado. Até mais!");
     
    }
}
