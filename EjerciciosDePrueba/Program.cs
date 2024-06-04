
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiaDeVida();
        ImprimirMinimoDe4();
    }

    private static void ImprimirMinimoDe4()
    {
        //Declarar las variables
        int num1, num2, num3, num4;

        //Pedimos al usuario el ingreso de los numeros
        Console.Write("Ingrese el primer numero");
        num1= int.Parse(Console.ReadLine());
        Console.Write("Ingrese el primer numero");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el primer numero");
        num3 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el primer numero");
        num4 = int.Parse(Console.ReadLine());
    }

    // Creamos un metodo que pida el nombre y apellido del Usuario

    private static void PedirNombreYSaludar()
    {
        //Declaramos las variables
        string nombre, apellido;

        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su apellido");
        apellido = Console.ReadLine();

        Console.WriteLine($"Bienvenido {apellido},{nombre}");
    }

    //Creamos un metodo que nos pida los años, meses y dias de vida y muestre al final la cantidad total de dias de vida
    private static void CalcularDiaDeVida()
    {
        //Declaramos las variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida ");
        años=int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida ");
        meses=int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus dias de vida ");
        dias=int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;

        Console.WriteLine($"Los dias de iida totales son: {diasDeVida}");

    }


}



