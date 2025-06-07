namespace EspacioTarea
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string? Descripcion { get; set; }
        public int Duracion { get; set; }// Validar que esté entre 10 y 100 Puedes añadir un constructor y métodos auxiliares si lo consideras necesario

        public Tarea(int TareaID, string Descripcion, int Duracion)
        {
            this.TareaID = TareaID;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
        }

        public Tarea()
        {
        }
        public static void Buscar(List<Tarea> tarea, string clave)//cuenta como metodo porque esta dentro de clase
        {
            bool encontrado = false;
            foreach (var t in tarea)
            {
                if (t.Descripcion.IndexOf(clave) != -1)
                {
                    if (!encontrado)
                    {
                        encontrado = true;
                        Console.WriteLine("Lista de tareas pendientes:");
                    }
                    Console.WriteLine($"La tarea pendiente de ID {t.TareaID}: {t.Descripcion}, duracion de {t.Duracion} horas.");
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encontro ninguna tarea");
            }
        }
    }
}