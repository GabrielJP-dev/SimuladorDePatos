using System;
using System.Collections.Generic;

class Program
{
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

        int indexAnterior = -1;

        while (true)
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
            if (!int.TryParse(entrada, out int escolha) || escolha < 0 || escolha > Patos.Count)
            {
                Console.WriteLine("❌ Entrada inválida. Pressione Enter...");
                Console.ReadLine();
                continue;
            }

            if (escolha == 0) break;

            int indexSelecionado = escolha - 1;
            var pato = Patos[indexSelecionado];

            if (indexSelecionado == indexAnterior)
            {
                ExecutarPoderes(pato);
                indexAnterior = -1;
            }
            else
            {
                indexAnterior = indexSelecionado;

                Console.Clear();
                Console.WriteLine("=== 🦆 MENU DE PATOS ===");
                for (int i = 0; i < Patos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Patos[i].Nome}");
                }

                Console.WriteLine($"\n--- Poderes de {pato.Nome} ---");
                MostrarPoderes(pato);
                Console.WriteLine("\n(Digite novamente o número para usar os poderes)");
                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
            }
        }

        Console.WriteLine("\nPrograma finalizado. Até mais!");
    }

    static void MostrarPoderes(Pato pato)
    {
        if (pato is Voar) Console.WriteLine("- Voar");
        if (pato is Quack) Console.WriteLine("- Grasnar");
        if (pato is IInvisibility) Console.WriteLine("- Ficar Invisível");
        if (pato is ILaserEyes) Console.WriteLine("- Laser nos Olhos");
        if (pato is IShieldWings) Console.WriteLine("- Asas Escudo");
        if (pato is ITeleport) Console.WriteLine("- Teleporte");
    }

    static void ExecutarPoderes(Pato pato)
    {
        List<Action> poderes = new List<Action>();
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"🐤 {pato.Nome} — Escolha um poder:\n");
            int index = 1;

            if (pato is Voar v)
            {
                Console.WriteLine($"{index}. Voar");
                poderes.Add(() => v.voando());
                index++;
            }

            if (pato is Quack q)
            {
                Console.WriteLine($"{index}. Grasnar");
                poderes.Add(() => q.falar());
                index++;
            }

            if (pato is IInvisibility inv)
            {
                Console.WriteLine($"{index}. Ficar Invisível");
                poderes.Add(() => inv.Invisível());
                index++;
            }

            if (pato is ILaserEyes laser)
            {
                Console.WriteLine($"{index}. Laser nos Olhos");
                poderes.Add(() => laser.ILaserEyes());
                index++;
            }

            if (pato is IShieldWings shield)
            {
                Console.WriteLine($"{index}. Asas Escudo");
                poderes.Add(() => shield.ShieldWings());
                index++;
            }

            if (pato is ITeleport tp)
            {
                Console.WriteLine($"{index}. Teleporte");
                poderes.Add(() => tp.Teleport());
                index++;
            }

            Console.WriteLine("0. Voltar ao menu de patos");

            Console.Write("\nEscolha o poder a usar: ");
            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out int escolha) || escolha < 0 || escolha > poderes.Count)
            {
                Console.WriteLine("❌ Entrada inválida. Pressione Enter...");
                Console.ReadLine();
                continue;
            }

            if (escolha == 0) break;

            Console.WriteLine();
            poderes[escolha - 1].Invoke();
            Console.WriteLine("\n✅ Poder usado! Pressione Enter...");
            Console.ReadLine();
        }
    }
}
