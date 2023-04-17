using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué operación quieres realizar? 1 = suma, 2 = resta, 3 = división, 4 = multiplicación");
            int respuesta = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el primer operando");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando");
            int num2 = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    suma(num1, num2);
                        break;
                case 2:
                    resta(num1, num2);
                    break;
                case 3:
                    division(num1, num2);
                    break;
                case 4:
                    multiplicacion(num1, num2);
                    break;

            }
        }

        static int suma (int operando1, int operando2)
        {
           int resultado = operando1 + operando2;
            Console.WriteLine(resultado);
            return resultado;
        }

        static int resta (int operando1, int operando2)
        {
            int resultado = operando1 - operando2;
            Console.WriteLine(resultado);
            return resultado;
        }

        static int division(int operando1, int operando2)
        {
            int resultado = operando1 / operando2;
            Console.WriteLine(resultado);
            return resultado;
        }

        static int multiplicacion (int operando1, int operando2)
        {
            int resultado = operando1 * operando2;
            Console.WriteLine(resultado);
            return resultado;
        }
    }
}
