using System;
class Program
{
    static void Main(string[] args)

    {
        int a = 0;
        int b = 1;
        int c;

        Console.Write("Digite um número: ");
        c = int.Parse(Console.ReadLine());

        while (c > b)
        {
            a = a + b;
            b = b + a;
        }

        if (c == a || c == b)
        {
            Console.WriteLine("O número digitado pertence a sequência de Fibonacci!");
        }
        else
        {
            Console.WriteLine("O número digitado não pertence a sequência de Fibonacci!");
        }
    }
}
