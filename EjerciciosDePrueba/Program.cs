
using EjerciciosDePrueba.Clase;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiaDeVida();
        //ImprimirMinimoDe4();
        //Triangulos();
        //fechasValidasInvalidas();
        //CalcularValorPago();
        //PruebaDeObjetosSplit();
        //PruebaDeObjetosPersona();
        //PavaElectrica();
        //PruebaDeClasesAbstractasYherencias();
        //CalculadoraPasajePorReferencia();





    }

    private static void CalculadoraPasajePorReferencia()
    {
        //Declaramos las variables
        int a = 123;
        int b = 10;
        int total = 0;

        Calculadora calculadora = new Calculadora();
        calculadora.Sumar(a, b, ref total);
        Console.WriteLine("El resultado total es " + total);
    }

    private static void PruebaDeClasesAbstractasYherencias()
    {
        Gerente juan = new Gerente("Javier, Marcelo", "Perez");
        Console.WriteLine(juan.ImprimirDatos());
    }

    private static void PavaElectrica()
    {
        PavaElectrica MiPava = new PavaElectrica("Liliana");
        MiPava.PresionarBotonEncendido();
        MiPava.CambiarModo();
    }

    private static void PruebaDeObjetosPersona()
    {
        //Instanciamos el objeto split

        Persona Albert = new Persona("Albert Eintein", "9 de Julio 1111", 1879);
        Persona Robert = new Persona("Robert Oppenheider", "Videla 2222", 1904);
        Robert.Decir("Albert, sabes como se despiden los quimicos?");
        Albert.Decir("No, ni idea");
        Robert.Decir("Acido un placer");

    }

    private static void PruebaDeObjetosSplit()
    {
        //Instanciamos el objeto split
        
        //<laClase> <Nombre del objeto> = new <laCLase> (Informacion al objeto para que se asigne en cada uno de sus campos ) 
        Split miSplit = new Split("Blanco", 3000, "rca");
        //Sentencias
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PresionarBotonEncendido();
        miSplit.CambiarModo("Calor");
        miSplit.SubirTemperatura();
    }

    private static void CalcularValorPago()
    {
        //Declaramos las variables

        double valorCuota;
        int nroDia;

        // Leemos las variables 

        Console.Write("Ingrese el valor de la cuota ");
        valorCuota = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nro del día de pago");
        nroDia = int.Parse(Console.ReadLine());

        switch (nroDia)
        {
            case < 3:
                valorCuota -= (valorCuota * 0.03);
                break;
            case >= 6 and <= 10:
                valorCuota += (valorCuota * 0.01);
                break;
            case >= 11 and <= 20:
                valorCuota += (valorCuota * 0.12);
                break;
            case >= 21 and <= 31:
                valorCuota += (valorCuota * 0.12);
                break;

        }

        Console.WriteLine($"El valor del pago es: {valorCuota} ");
    }

    private static void fechasValidasInvalidas()
    {
        //definir variables  
        int dia, mes, año;

        // Pedir Informacion al usuario
        Console.WriteLine("Ingrese el día");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el mes");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el año");
        año = int.Parse(Console.ReadLine());


        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            Console.WriteLine("Fecha Valida");

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            Console.WriteLine("Fecha Valida ");

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            Console.WriteLine("Fecha Valida ");

        else
            Console.WriteLine("Fecha Invalida");
    }

    private static void Triangulos()
    {
        //Declarar las variables
        int lado1, lado2, lado3;

        //Pedimos al usuario que ingrese los numeros
        Console.Write("Ingrese lado1 del tringulo ");
        lado1=int.Parse(Console.ReadLine());

        Console.Write("Ingrese lado2 del tringulo ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese lado3 del tringulo ");
        lado3 = int.Parse(Console.ReadLine());

        //Comparamos los numeros 

        if (lado1 == lado2 && lado1 == lado3)
            Console.Write("El triangulo es EQUILATERO ");
        if (lado1 == lado2 && lado1 != lado3)
            Console.Write("El triangulo es ISOSCELES");
        if (lado1 != lado2 && lado1 != lado3)
            Console.Write("El triangulo es ESCALENO ");
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

        //Compamos los numeros 
        if (num1 < num2 && num1 < num3 && num1 < num4)
            Console.WriteLine("El numero menor es el primero: "+ num1);
        if (num2 < num1 && num2 < num3 && num2 < num4)
            Console.WriteLine("El numero menor es el segundo: " + num2);
        if (num3 < num1 && num3 < num2 && num3 < num4)
            Console.WriteLine("El numero menor es el tercero: " + num3);
        if (num4 < num1 && num4 < num3 && num4 < num2)
            Console.WriteLine("El numero menor es el cuarto: " + num4);
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



