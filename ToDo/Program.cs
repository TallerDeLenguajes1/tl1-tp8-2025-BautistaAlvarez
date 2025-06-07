using System.Runtime.InteropServices.Marshalling;
using EspacioTarea;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Tarea> TareasPendientes = new List<Tarea>();//creo lista
List<Tarea> tareasRealizadas = new List<Tarea>();
/*Tarea tarea1 = new Tarea(1,"Lavar lugar",20);
TareasPendientes.Add(tarea1);*/// agregar de manera simple
int continuar = 0, operacion = 0, idTarea = 0;
string? entrada;

do
{
    Console.WriteLine("Ingrese un numero de operacion, 1 para ingresar nuevas tareas pendientes, 2 mover tareas pendientes a realizadas, 3 listado de tareas pendientes y realizadas, 4 buscar tareas por descripcion");
    entrada = Console.ReadLine();
    if (int.TryParse(entrada, out operacion))
    {
        switch (operacion)
        {

            case 1:
                //2
                    Console.WriteLine("Ingrese cuantas tareas agregara:");
                    entrada = Console.ReadLine();
                    int cantTareas = 0, duracion = 0;
                    if (int.TryParse(entrada, out cantTareas))
                    {
                        for (int i = 0; i < cantTareas; i++)
                        {
                        idTarea++;
                            Console.WriteLine("Ingrese una descripcion de la tarea");
                            string? descripcion = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Ingrese la duracion de la tarea (de 10 a 100)");
                                entrada = Console.ReadLine();
                                if (int.TryParse(entrada, out duracion))
                                {
                                    if (duracion >= 10 && duracion <= 100)
                                    {
                                        TareasPendientes.Add(new Tarea(idTarea, descripcion, duracion));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese una duracion valida.");
                                    }
                                }
                            } while (duracion < 10 || duracion > 100);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Numero invalido");
                    }
                break;
            case 2:
                //3
                if (TareasPendientes.Count != 0)
                {
                    foreach (var tarea in TareasPendientes)
                    {
                        Console.WriteLine($"La tarea de ID {tarea.TareaID}: {tarea.Descripcion}, duracion de {tarea.Duracion} horas");
                    }
                    Console.WriteLine("Ingrese el ID de la tarea que desee mover a la lista de realizados");
                    int idTareaMover;
                    entrada = Console.ReadLine();
                    //Tarea aux= null; otra forma de hacer el movimiento entre lista
                    if (int.TryParse(entrada, out idTareaMover))
                    {
                        foreach (var tarea in TareasPendientes)
                        {
                            if (tarea.TareaID == idTareaMover)
                            {
                                tareasRealizadas.Add(tarea);
                                TareasPendientes.Remove(tarea);
                                //aux = tarea;
                                break;
                            }
                        }
                        /*if(aux!=null)
                        {
                            tareasRealizadas.Add(aux);
                            TareasPendientes.Remove(aux);
                        }*/
                    }
                    else
                    {
                        Console.WriteLine("Numero invalido");
                    }
                }
                else
                {
                    Console.WriteLine("La lista de pendiente esta vacia");
                }
                break;
            case 3:
                //5
                if (TareasPendientes.Count != 0)
                {
                    Console.WriteLine("------------------Lista Tareas Pendientes------------");
                    foreach (var tarea in TareasPendientes)
                    {
                        Console.WriteLine($"La tarea de ID {tarea.TareaID}: {tarea.Descripcion}, duracion de {tarea.Duracion} horas");
                    }
                }
                else
                {
                    Console.WriteLine("La lista de tareas pendientes esta vacia");
                }
                if (tareasRealizadas.Count != 0)
                {
                    Console.WriteLine("------------------Lista Tareas Realizadas------------");

                    foreach (var tarea in tareasRealizadas)
                    {
                        Console.WriteLine($"La tarea de ID {tarea.TareaID}: {tarea.Descripcion}, duracion de {tarea.Duracion} horas");
                    }
                }
                else
                {
                    Console.WriteLine("La lista de tareas realizadas esta vacia");
                }
                break;
            case 4:
                //4
                if (TareasPendientes.Count != 0)
                {
                    string? descripcionUsuario;
                    Console.WriteLine("Ingrese una cadena de texto para buscar coincidencias entre tareas pendientes.");
                    descripcionUsuario = Console.ReadLine();
                    Tarea.Buscar(TareasPendientes, descripcionUsuario);//llamo la clase y la funcion, ingreso la lista de tareas que cree y la descripcion como argumento.
                }
                else
                {
                    Console.WriteLine("La lista de tareas pendientes esta vacias");
                }
                break;
        }
    }
    else
    {
        Console.WriteLine("Numero invalido");
    }
    Console.WriteLine("Desea hacer otra operacion? 0 para terminar, 1 para seguir");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out continuar);
} while (continuar != 0);



