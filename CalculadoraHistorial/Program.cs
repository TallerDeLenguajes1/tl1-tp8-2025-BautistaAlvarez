// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Console.WriteLine("Hello, World!");

Calculadora miCalculadora = new Calculadora();
int continuar = 0, operacion;
float num;
string? entrada;
do
{
    Console.WriteLine($"El resultado actual es: {miCalculadora.Resultado}");
    Console.WriteLine("Ingrese un numero de operacion, 1 para suma, 2 para restar, 3 para multiplicar, 4 para dividir o 5 para limpiar");
    entrada = Console.ReadLine();
    if (int.TryParse(entrada, out operacion) && operacion > 0 && operacion < 6)
    {
        switch (operacion)
        {
            case 1:
                Console.WriteLine("Ingrese un numero para sumar:");
                entrada = Console.ReadLine();
                if (float.TryParse(entrada, out num))
                {
                    miCalculadora.sumar(num);
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
                break;
            case 2:
                Console.WriteLine("Ingrese un numero para restar:");
                entrada = Console.ReadLine();
                if (float.TryParse(entrada, out num))
                {
                    miCalculadora.restar(num);
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
                break;
            case 3:
                Console.WriteLine("Ingrese un numero para multiplicar:");
                entrada = Console.ReadLine();
                if (float.TryParse(entrada, out num))
                {
                    miCalculadora.multiplicar(num);
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
                break;
            case 4:
                Console.WriteLine("Ingrese un numero para dividir:");
                entrada = Console.ReadLine();
                if (float.TryParse(entrada, out num))
                {
                    if (num != 0)
                    {
                        miCalculadora.dividir(num);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir en 0");
                    }
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
                break;
            case 5:
                miCalculadora.limpiar();
                Console.WriteLine("Se limpio el dato.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Numero invalido");
    }
    Console.WriteLine($"El resultado actual es: {miCalculadora.Resultado}");
    Console.WriteLine("Desea continuar? Ingrese 0 para finalizar o otro numero para continuar");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out continuar);
} while (continuar != 0);

//ejercicio2 tp8
miCalculadora.mostrarHistorial();
