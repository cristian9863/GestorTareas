using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorTareas
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarTareaButton_Click(object sender, EventArgs e)
        {
            string descripcion = descripcionTextBox.Text;
            DateTime fechaVencimiento = fechaVencimientoDateTimePicker.Value;
            Tarea nuevaTarea = new Tarea(descripcion, fechaVencimiento);
            tareas.Add(nuevaTarea);
            MostrarTareasPendientes();
        }

        private void MarcarCompletadaButton_Click(object sender, EventArgs e)
        {
            if (tareasListBox.SelectedIndex != -1)
            {
                tareas[tareasListBox.SelectedIndex].MarcarComoCompletada();
                MostrarTareasPendientes();
            }
        }

        private void MostrarTareasPendientes()
        {
            tareasListBox.Items.Clear();
            foreach (Tarea tarea in tareas)
            {
                if (!tarea.Completada)
                {
                    tareasListBox.Items.Add(tarea);
                }
            }
        }
    }
}
