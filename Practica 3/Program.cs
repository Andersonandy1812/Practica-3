
using System;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio4();
        }

        static void ejercicio1()
        {
            Console.WriteLine("Escriba un numero entero:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        static void ejercicio2()
        {
            Console.WriteLine("Escriba un numero entero:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero entero:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("El primer numero es mayor");
            }
            else
            {
                Console.WriteLine("El segundo numero es mayor");
            }
        }
        static void ejercicio3()
        {
            Console.WriteLine("Escriba un numero entero:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero entero:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 % n2 == 0)
            {
                Console.WriteLine("el primero es multiplo del segundo numero");
            }
            else
            {
                Console.WriteLine("El primero no es multiplo del segundo");
            }
        }
        static void ejercicio4()
        {
            Console.WriteLine("Escriba un numero entero:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 10 == 0)
            {
                Console.WriteLine("El numero es multiplo de 10");
                Console.WriteLine("Escriba otro numero entero:");
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 % 10 == 0)
                {
                    Console.WriteLine("Este numero tambien es multiplo de 10");
                }
                else
                {
                    Console.WriteLine("Este no es multiplo de 10");
                }
            }
            else
            {
                Console.WriteLine("El numero no es multiplo de 10");
            }
        }
        static void ejercicio5()
        {
            Console.WriteLine("escriba el numero que desea multiplicar");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 == 0)
            {
                Console.WriteLine("Cacon pero el producto de 0 por cualquier numero es 0");
            }
            else
            {
                Console.WriteLine("escriba por cuanto lo desea multiplicar");
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 == 0)
                {
                    Console.WriteLine("Cacon pero el producto de 0 por cualquier numero es 0");
                }
                else
                {
                    n2 = n1 * n2;
                    Console.WriteLine("La multiplicacion de los numeros es: " + n2);
                }
            }
        }
        static void ejercicio6()
        {
            Console.WriteLine("Escriba un numero entero:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero entero:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 != 0)
            {
                Console.WriteLine("El resultado de la division de estos numeros es: " + (n1 / n2));
            }
            else
            {
                Console.WriteLine(" Pero cacon no se puede dividir entre 0");
            }
        }
        static void ejercicio7()
        {
            Console.WriteLine("Escriba un numero entero:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 5 == 0)
            {
                Console.WriteLine("Este numero es multiplo de 5");

            }
            else
            {
                Console.WriteLine("Este numero no es multiplo de 5");
                if (n1 % 4 == 0)
                {
                    Console.WriteLine("Este numero es multiplo de 4");
                }
                else
                {
                    Console.WriteLine("Este numero no es multiplo de 4");
                }
            }
        }
        static void ejercicio8()
        {
            Console.WriteLine("Escriba un numero:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine("El primer numero es positivo");
            }
            else
            {
                Console.WriteLine("El primer numero es negativo");
            }
            if (n2 > 0)
            {
                Console.WriteLine("El segundo numero es positivo");
            }
            else
            {
                Console.WriteLine("El segundo numero es negativo");
            }
        }
        public static void ejercicio9()
        {
            Console.WriteLine("Escriba un numero real:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero real:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba un numero real:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 & n1 > n3)
            {
                Console.WriteLine("El primer numero es mayor");
            }
            else if (n2 > n1 & n2 > n3)
            {
                Console.WriteLine("El segundo numero es mayor");
            }
            if (n3 > n1 & n3 > n2)
            {
                Console.WriteLine("El tercer numero es mayor");
            }

        }
    }
}
