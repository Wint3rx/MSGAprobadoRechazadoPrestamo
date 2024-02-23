using System;

class Program
{
    static void Main()
    {
        try
        {
            // Solicitar al usuario el monto del préstamo
            Console.Write("Ingrese el monto del préstamo: Q.");
            double monto = Convert.ToDouble(Console.ReadLine());

            // Solicitar al usuario su edad
            Console.Write("Ingrese su edad: ");
            int edadUsuario = Convert.ToInt32(Console.ReadLine());

            // Verificar las condiciones para la aprobación del préstamo
            if (monto < 5000 || edadUsuario > 60)
            {
                // Aprobar el préstamo
                Console.WriteLine("¡Felicidades! Su préstamo ha sido aprobado.");
            }
            else
            {
                // Rechazar el préstamo
                Console.WriteLine("Lo siento, su préstamo ha sido rechazado.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor, ingrese valores numéricos válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}

