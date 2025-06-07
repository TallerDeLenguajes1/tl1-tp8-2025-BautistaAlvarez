namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public Calculadora(double dato = 0)
        { //constructor ¿inicializar en 0?
            this.dato = dato;
        }
        /*public Calculadora (double inicio = 0){
            dato = inicio;
        }*///esto es otra manera de inicializar, es lo mismo que el de arriba


        //-----------------------------agrego una lista vacia de operacion para el tema del historial (ejercicio2 tp8)---------------------------------
        private List<Operacion> historial = new List<Operacion>();
        public List<Operacion> Historial
        {
            get => historial;
        }
        //public List<Operacion> Historial => historial; forma alternativa
        //-----------------------------agrego una lista vacia de operacion para el tema del historial (ejercicio2 tp8)---------------------------------


        public void sumar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Suma));
            dato += termino;
        }

        public void restar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Resta));
            dato -= termino;
        }

        public void multiplicar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Multiplicacion));
            dato = dato * termino;
        }

        public void dividir(double termino)
        {
            if (termino != 0)
            {
                historial.Add(new Operacion(dato, termino, TipoOperacion.Division));
                dato = dato / termino;
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0");
            }
        }

        public void limpiar()
        {
            dato = 0;
            //aqui agrego algo del tp8 ejercicio2, para limpiar el historial
            historial.Clear(); //limpio la list armada de la calculadora
        }

        public double Resultado //Propiedad(una funcion para obtener el dato privado) en este caso solo get, el set es para poder darle un valor fuera
        {
            get => dato;
        }

        //uso un metodo para mostrar por pantalla el historial, no uso una propiedad porque eso para acceder a valores
        public void mostrarHistorial()
        {
            if (historial.Count != 0)
            {
                Console.WriteLine("Historial de operaciones");
                foreach (var op in historial)
                {
                    Console.WriteLine($"{op.Op} de {op.ResultadoAnterior} y {op.NuevoValor} = {op.Resultado}");
                }
            }
            else
            {
                Console.WriteLine("El historial esta vacio");
            }
        }

    }
}