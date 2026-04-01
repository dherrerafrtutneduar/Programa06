namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
            // Intento de uso
            int edadCliente = 20;
            Console.WriteLine("\nVerificando cliente de " + edadCliente + " años...");
            
            if (edadCliente >= EDAD_MINIMA) {
                Console.WriteLine("Acceso CONCEDIDO.");
            } else {
                Console.WriteLine("Acceso DENEGADO.");
            }

            Console.ReadLine();

    }
}
