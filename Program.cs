using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Console.WriteLine("Ingresar Nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingresar Apellido:");
            string ape = Console.ReadLine();
            Console.WriteLine("Nombre Completo: "+ nom + " " + ape);

            //Ejercicio 2
            Console.WriteLine("Ingresar Edad:");
            string edad = Console.ReadLine();            
            if (int.Parse(edad) > 18)
            {
                Console.WriteLine("Es mayor");
            }else
            {
                Console.WriteLine("Es Menor");
            }

            //Ejercicio 3
            Console.WriteLine("Ingresar un numero entero, calculare la suma de los anteriores:");
            int numero=0;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int tot = 0;
                while (numero >= 0)
                {
                    tot = tot + numero;
                    numero = numero - 1;
                }
                Console.WriteLine("El resultado total es " + tot);
            }
            else
            {
                Console.WriteLine("No ingresaste un numero entero");
            }

            //Ejericio 4 
            int mayor = 0;
            int menor = 0;
            Console.WriteLine("Ingrese dos valores, se calculara el Maximo Comun Divisor");
            Console.WriteLine("Ingresar Valor 1:");
            int val1 =int.Parse( Console.ReadLine());
            Console.WriteLine("Ingresar Valor 2:");
            int val2 = int.Parse(Console.ReadLine());
            if (val1 > val2)
            {
                 mayor = val1;
                 menor = val2;
            }
            else
            {
                 mayor = val2;
                 menor = val1;
            }
            int resto;
            for (int i = menor; i > 0; i--)
            {
                resto = menor % i;
                resto += mayor % i;
                if (resto<=0)
                {
                    Console.WriteLine("maximo comun divisor es: " +i);
                    i = 0;
                }
            }

            //Ejercicio 5
            Console.WriteLine("Ingrese numeros, se calculara el promdio de estos");
            Console.WriteLine("0 para dejar de ingresar");
            Console.WriteLine("Ingresar un numero:");
            int n = int.Parse(Console.ReadLine());
            int total = n;
            int c = 1;
            while (n!=0)
            {
                c++;
                Console.WriteLine("Ingresar un numero:");
                n = int.Parse(Console.ReadLine());
                total += n;
            }
            double promedio = n/c;
            Console.WriteLine("El promedio es " + promedio);

            //Stop
            Console.ReadLine();
        }
    }
}
