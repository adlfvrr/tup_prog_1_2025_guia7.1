namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad1, edad2, edad3, edad4, suma;
            double monto, por1, por2, por3, por4, monto1, monto2, monto3, monto4;
            Console.Write("Ingrese monto a repartir: $");
            monto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese edades de las niñas: ");
            edad1 = Convert.ToInt32(Console.ReadLine());
            edad2 = Convert.ToInt32(Console.ReadLine());
            edad3 = Convert.ToInt32(Console.ReadLine());
            edad4 = Convert.ToInt32(Console.ReadLine());
            suma = edad1 + edad2 + edad3 + edad4;
            por1 = 1.0 * edad1 / suma * 100;
            por2 = 1.0 * edad2 / suma * 100;
            por3 = 1.0 * edad3 / suma * 100;
            por4 = 1.0 * edad4 / suma * 100;
            monto1 = por1 * monto / 100;
            monto2 = por2 * monto / 100;
            monto3 = por3 * monto / 100;
            monto4 = por4 * monto / 100;
            Console.WriteLine("A la niña 1 le corresponde un {0:f2}%, siendo un total de ${1:f2}", por1, monto1);
            Console.WriteLine("A la niña 2 le corresponde un {0:f2}%, siendo un total de ${1:f2}", por2, monto2);
            Console.WriteLine("A la niña 3 le corresponde un {0:f2}%, siendo un total de ${1:f2}", por3, monto3);
            Console.WriteLine("A la niña 4 le corresponde un {0:f2}%, siendo un total de ${1:f2}", por4, monto4);
        }
    }
}
