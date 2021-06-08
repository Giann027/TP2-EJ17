using System;

namespace TP2_EJ17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUENASS!");
            Console.Title = "Operaciones Basicas + error division con 0 ";
          
            float Numero1, Numero2, Suma, Resta, Multiplicación, División;

            Console.Write("Ingrese el primer Número: ");
            Numero1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el segundo Número: ");
            Numero2 = Convert.ToSingle(Console.ReadLine());

            Suma = Numero1 + Numero2;
            Resta = Numero1 - Numero2;
            Multiplicación = Numero1 * Numero2;
            División = Numero1 / Numero2;

            if (Numero2 == 0)

                Console.WriteLine($"No se puede dividir por 0");

            else

                Console.WriteLine($"El resultado de la Division es {División}");
                Console.WriteLine($"El resultado de la suma es {Suma}");
                Console.WriteLine($"El resultado de la Resta es {Resta}");
                Console.WriteLine($"El resultado de la Multiplicación es {Multiplicación}");


            

           
       


        }
    }
}
