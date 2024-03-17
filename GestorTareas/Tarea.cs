using System;

namespace GestorTareas
{
    public class Tarea
    {
        public string Descripcion { get; }
        public bool Completada { get; private set; }
        public DateTime FechaVencimiento { get; }

        public Tarea(string descripcion, DateTime fechaVencimiento)
        {
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
            Completada = false;
        }

        public void MarcarComoCompletada()
        {
            Completada = true;
        }

        public override string ToString()
        {
            return $"{Descripcion} - Vence el {FechaVencimiento.ToShortDateString()}";
        }
    }
}

