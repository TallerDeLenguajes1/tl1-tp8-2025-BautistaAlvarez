namespace EspacioCalculadora
{
    public enum TipoOperacion {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Representa la acción de borrar el resultado actual o el historial
    }
    public class Operacion
    {
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;
        public double Resultado //propiedad calculada sin respaldo privado (sirve para usar las propiedades del objeto y dar un resultado directo)
        {
            get
            {
                switch (operacion)
                {
                    case TipoOperacion.Suma:
                        return resultadoAnterior + nuevoValor;
                    case TipoOperacion.Resta:
                        return resultadoAnterior - nuevoValor;
                    case TipoOperacion.Multiplicacion:
                        return resultadoAnterior * nuevoValor;
                    case TipoOperacion.Division:
                        if (nuevoValor != 0)
                        {
                            return resultadoAnterior / nuevoValor;
                        }
                        else
                        {
                            return double.NaN; //en caso de division por sero, esto significa "Not a number"
                        }
                    case TipoOperacion.Limpiar:
                        return 0;
                    default://si o si tiene que devolver algo aunque siempre existira operacion
                        return resultadoAnterior;
                }
            }
        }
        // Propiedad pública para acceder al nuevo valor utilizado en la operación
        public double NuevoValor
        {
            get => nuevoValor;
        }
        //propiedades
        public double ResultadoAnterior
        {
            get => resultadoAnterior;
        }
        public TipoOperacion Op
        {
            get => operacion;
        }
        // Constructor u otros métodos necesarios para inicializar y gestionar la operación
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion) //constructor
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }


    }
}