// See https://aka.ms/new-console-template for more information
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