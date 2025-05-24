using System.ComponentModel;

namespace ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patente, a1, a2, a3, numb1,numb2,numb3;
            char b1, b2, b3;
            Console.Write("Ingrese número a procesar: ");
            patente = Convert.ToInt32(Console.ReadLine());
            a3 = patente % 10;
            a2 = (patente/10) % 10;
            a1 = (patente/100) % 10;
            numb3 = (patente / 1000) % 26;
            b3 = Convert.ToChar('A' + numb3);
            numb2 = ((patente / 1000) / 26) % 26;
            b2 = Convert.ToChar('A' + numb2);
            numb1 = (((patente / 1000) / 26) / 26) % 26;
            b1 = Convert.ToChar('A' + numb1);
            Console.WriteLine($"Patente: {b1}{b2}{b3}{a1}{a2}{a3}" );
        }
    }
}
