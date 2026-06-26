using System;

namespace Tarea2ISR
{
    internal class ISR
    {
        static void Main(string[] args)
        {
            double salarioMensual, isrAnual, isrMensual;

            Console.Write("Ingrese su salario mensual RD$: ");
            salarioMensual = double.Parse(Console.ReadLine());

            double salarioAnual = salarioMensual * 12;

            // Escala ISR 2024 República Dominicana
            if (salarioAnual <= 624329.01)
            {
                isrAnual = 0;
            }
            else if (salarioAnual <= 867123.01)
            {
                isrAnual = (salarioAnual - 624329.01) * 0.15;
            }
            else if (salarioAnual <= 1044441.01)
            {
                isrAnual = 36419.10 + (salarioAnual - 867123.01) * 0.20;
            }
            else
            {
                isrAnual = 71896.06 + (salarioAnual - 1044441.01) * 0.25;
            }

            isrMensual = isrAnual / 12;

            Console.WriteLine("\n--- Cálculo ISR ---");
            Console.WriteLine("Salario Anual: RD$ {0:N2}", salarioAnual);
            Console.WriteLine("ISR Anual: RD$ {0:N2}", isrAnual);
            Console.WriteLine("ISR Mensual: RD$ {0:N2}", isrMensual);
            Console.ReadLine();
        }
    }
}