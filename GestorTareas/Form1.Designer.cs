namespace GestorTareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.agregarTareaButton = new System.Windows.Forms.Button();
            this.marcarCompletadaButton = new System.Windows.Forms.Button();
            this.tareasListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(12, 12);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 0;
            // 
            // fechaVencimientoDateTimePicker
            // 
            this.fechaVencimientoDateTimePicker.Location = new System.Drawing.Point(12, 38);
            this.fechaVencimientoDateTimePicker.Name = "fechaVencimientoDateTimePicker";
            this.fechaVencimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaVencimientoDateTimePicker.TabIndex = 1;
            // 
            // agregarTareaButton
            // 
            this.agregarTareaButton.Location = new System.Drawing.Point(12, 64);
            this.agregarTareaButton.Name = "agregarTareaButton";
            this.agregarTareaButton.Size = new System.Drawing.Size(200, 23);
            this.agregarTareaButton.TabIndex = 2;
            this.agregarTareaButton.Text = "Agregar Tarea";
            this.agregarTareaButton.UseVisualStyleBackColor = true;
            this.agregarTareaButton.Click += new System.EventHandler(this.AgregarTareaButton_Click);
            // 
            // marcarCompletadaButton
            // 
            this.marcarCompletadaButton.Location = new System.Drawing.Point(12, 93);
            this.marcarCompletadaButton.Name = "marcarCompletadaButton";
            this.marcarCompletadaButton.Size = new System.Drawing.Size(200, 23);
            this.marcarCompletadaButton.TabIndex = 3;
            this.marcarCompletadaButton.Text = "Marcar como Completada";
            this.marcarCompletadaButton.UseVisualStyleBackColor = true;
            this.marcarCompletadaButton.Click += new System.EventHandler(this.MarcarCompletadaButton_Click);
            // 
            // tareasListBox
            // 
            this.tareasListBox.FormattingEnabled = true;
            this.tareasListBox.Location = new System.Drawing.Point(218, 12);
            this.tareasListBox.Name = "tareasListBox";
            this.tareasListBox.Size = new System.Drawing.Size(200, 134);
            this.tareasListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 161);
            this.Controls.Add(this.tareasListBox);
            this.Controls.Add(this.marcarCompletadaButton);
            this.Controls.Add(this.agregarTareaButton);
            this.Controls.Add(this.fechaVencimientoDateTimePicker);
            this.Controls.Add(this.descripcionTextBox);
            this.Name = "Form1";
            this.Text = "Gestor de Tareas Pendientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaVencimientoDateTimePicker;
        private System.Windows.Forms.Button agregarTareaButton;
        private System.Windows.Forms.Button marcarCompletadaButton;
        private System.Windows.Forms.ListBox tareasListBox;
    }
}
