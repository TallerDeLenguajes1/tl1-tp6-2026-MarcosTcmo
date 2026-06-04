// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");
int a;

int b;

a = 10;

b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

int numeroAdarVuelta, auxiliar;
string entrada = Console.ReadLine();
bool resultado = int.TryParse(entrada, out numeroAdarVuelta);
auxiliar = 0;
if (resultado)
{
    int resto = 0;
    while (numeroAdarVuelta > 0)
    {
        resto = numeroAdarVuelta % 10;
        auxiliar = auxiliar * 10 + resto;
        numeroAdarVuelta = numeroAdarVuelta / 10;
    }
    Console.WriteLine("Valor invertido: " + auxiliar);
}
bool salida = true;
do
{
    Console.WriteLine("Ingrese una opcion para calcular");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    int opcion;
    string ingresoOpcion = Console.ReadLine();
    if (int.TryParse(ingresoOpcion, out opcion))
    {
        double numero1, numero2;
        string ingresoNum1 = Console.ReadLine(), ingresoNum2 = Console.ReadLine();
        bool validacionNum1 = double.TryParse(ingresoNum1, out numero1);
        bool validacionNum2 = double.TryParse(ingresoNum2, out numero2);
        string confirmacionSalida = " ";
        
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Sumando " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                Console.WriteLine("Desea realizar otro calculo? (Y/N)");
                confirmacionSalida = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Restando " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                Console.WriteLine("Desea realizar otro calculo? (Y/N)");
                confirmacionSalida = Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("multiplicando " + numero1 + " X " + numero2 + " = " + (numero1 * numero2));
                Console.WriteLine("Desea realizar otro calculo? (Y/N)");
                confirmacionSalida = Console.ReadLine();
                break;
            case 4:
                Console.WriteLine("Dividiendo " + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                Console.WriteLine("Desea realizar otro calculo? (Y/N)");
                confirmacionSalida = Console.ReadLine();
                break;
            default:
                Console.WriteLine("Ingreso una opcion invalida");
                break;
        }
        if (confirmacionSalida == "n" || confirmacionSalida == "N")
        {
            salida = false;
        }
    }
} while (salida);