using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Qual operação deseja realizar: ");
            Console.WriteLine("1 - Para Soma");
            Console.WriteLine("2 - Para Subtração");
            Console.WriteLine("3 - Para Divisão");
            Console.WriteLine("4 - Para Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------------------");
            Console.WriteLine("=> Digite uma opção:");

            int res = Convert.ToInt32(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double resultado = v1 + v2;
            Console.WriteLine($"Resultado da operação: {resultado} ");
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double resultado = v1 - v2;
            Console.WriteLine($"Resultado da operação: {resultado} ");
            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double resultado = v1 / v2;
            Console.WriteLine($"Resultado da operação: {resultado} ");
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double resultado = v1 * v2;
            Console.WriteLine($"Resultado da operação: {resultado} ");
            Console.ReadKey();
            Menu();

        }
    }
}
