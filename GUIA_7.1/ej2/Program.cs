﻿namespace ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double masakg, masag, sobrante;
            double budines = 0, paquetes = 0, cajas = 0;
            Console.Write("Ingrese cantidad de masa en KG: ");
            masakg = Convert.ToDouble(Console.ReadLine());
            masag = masakg * 1000;
            budines = Convert.ToInt32(masag / 55);
            sobrante = masag % 55;
            paquetes = Convert.ToInt32(budines / 12);
            cajas = Convert.ToInt32(paquetes / 20);
            Console.WriteLine("La cantidad de masa sobrante es de {0:f2}g", sobrante);
            Console.WriteLine("Se producieron en total {0} budines, armando {1} paquetes y finalmente {2} cajas.", budines, paquetes, cajas);
        }
    }
}
