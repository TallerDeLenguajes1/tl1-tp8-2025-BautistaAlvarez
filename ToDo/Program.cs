using EspacioTarea;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Tarea> TareasPendientes = new List<Tarea>();//creo lista
/*Tarea tarea1 = new Tarea(1,"Lavar lugar",20);
TareasPendientes.Add(tarea1);*/// agregar de manera simple
//2
Console.WriteLine("Ingrese cuantas tareas agregara:");
string? entrada = Console.ReadLine();
int cantTareas = 0, duracion = 0;
if (int.TryParse(entrada, out cantTareas))
{
    for (int i = 0; i < cantTareas; i++)
    {
        int idTarea = i + 1;
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
                } else {
                    Console.WriteLine("Ingrese una duracion valida.");
                }
            }
        } while (duracion < 10 || duracion > 100);
    }
} else{
    Console.WriteLine("Numero invalido");
}

//3
List<Tarea> tareasRealizadas = new List<Tarea>();
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
}else{
    Console.WriteLine("Numero invalido");
}
Console.WriteLine("------------------Lista Tareas Pendientes------------");
foreach (var tarea in TareasPendientes)
{
    Console.WriteLine($"La tarea de ID {tarea.TareaID}: {tarea.Descripcion}, duracion de {tarea.Duracion} horas");
}
Console.WriteLine("------------------Lista Tareas Realizadas------------");

foreach (var tarea in tareasRealizadas)
{
    Console.WriteLine($"La tarea de ID {tarea.TareaID}: {tarea.Descripcion}, duracion de {tarea.Duracion} horas");
}
//4

