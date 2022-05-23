using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AbrirMenu();
        }

        static void Soma()
        {
            Console.Clear();
            System.Console.WriteLine("Voce escolheu SOMAR");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 + v2;
            System.Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();
            AbrirMenu();
        }

        static void Subtracao()
        {
            Console.Clear();
            System.Console.WriteLine("Voce escolheu SUBTRAIR");

            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 - v2;
            System.Console.WriteLine($"O resultado da subração é {resultado}");

            Console.ReadKey();
            AbrirMenu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            System.Console.WriteLine("Voce escolheu MULTIPLICAR");

            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 * v2;
            System.Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();
            AbrirMenu();
        }

        static void Divisao()
        {
            Console.Clear();
            System.Console.WriteLine("Voce escolheu DIVIDIR");

            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 / v2;
            System.Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadKey();
            AbrirMenu();
        }

        static void AbrirMenu()
        {
            System.Console.WriteLine("Escolha uma operação:");
            System.Console.WriteLine("======================");
            System.Console.WriteLine("1. SOMAR");
            System.Console.WriteLine("2. SUBTRAIR");
            System.Console.WriteLine("3. MULTIPLICAR");
            System.Console.WriteLine("4. DIVIDIR");
            System.Console.WriteLine("5. SAIR");
            int escolha = int.Parse(Console.ReadLine());

            EscolherOperacao(escolha);
        }

        static void EscolherOperacao(int escolha)
        {
            switch (escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5:
                    System.Console.WriteLine("Saindo...");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida, tente novamente!");
                    AbrirMenu();
                    break;
            }
        }
    }
}