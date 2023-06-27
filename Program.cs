using System;

class Tarjeta_de_Acceso
{
    static void Main()
    {
        int[] codigoAcceso = GenerarCodigoAcceso(); 

        // Genera el arreglo con valores aleatorios
        MostrarCodigoAcceso(codigoAcceso);

        // Muestra el código de acceso generado
        int numeroUsuario = SolicitarNumeroUsuario(); 

        // Solicita el número al usuario
        VerificarCodigoAcceso(codigoAcceso, numeroUsuario);

        // Verifica si el número está en el código de acceso
        Console.ReadLine();
    }

    static int[] GenerarCodigoAcceso()
    {
        Random random = new Random();
        int[] codigoAcceso = new int[40];

        for (int i = 0; i < codigoAcceso.Length; i++)
        {
            codigoAcceso[i] = random.Next(1, 1001); 
          // Genera valores aleatorios entre 1 y 1000
        }

        return codigoAcceso;
    }

    static void MostrarCodigoAcceso(int[] codigoAcceso)
    {
        Console.WriteLine("Código de Acceso:");

        for (int i = 0; i < codigoAcceso.Length; i++)
        {
            Console.WriteLine(codigoAcceso[i]);
        }
    }

    static int SolicitarNumeroUsuario()
    {
        Console.WriteLine("Ingrese un número:");
        int numeroUsuario = int.Parse(Console.ReadLine());
        return numeroUsuario;
    }

    static void VerificarCodigoAcceso(int[] codigoAcceso, int numeroUsuario)
    {
        if (Array.IndexOf(codigoAcceso, numeroUsuario) != -1)
        {
            Console.WriteLine("El número ingresado está en el código de acceso.");
        }
        else
        {
            Console.WriteLine("El número ingresado NO está en el código de acceso.");
        }
    }
}
