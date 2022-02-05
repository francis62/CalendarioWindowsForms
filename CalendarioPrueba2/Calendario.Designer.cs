
namespace CalendarioPrueba2
{
    partial class Calendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.labelUsuarioEnSesion = new System.Windows.Forms.Label();
            this.labelUsuarioSesionNombre = new System.Windows.Forms.Label();
            this.mostradorDeCalendario = new System.Windows.Forms.MonthCalendar();
            this.labelFechaSeleccionada = new System.Windows.Forms.Label();
            this.dataGridViewCalendario = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCerrarSesion.Location = new System.Drawing.Point(18, 400);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(248, 38);
            this.buttonCerrarSesion.TabIndex = 0;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // labelUsuarioEnSesion
            // 
            this.labelUsuarioEnSesion.AutoSize = true;
            this.labelUsuarioEnSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelUsuarioEnSesion.Location = new System.Drawing.Point(40, 17);
            this.labelUsuarioEnSesion.Name = "labelUsuarioEnSesion";
            this.labelUsuarioEnSesion.Size = new System.Drawing.Size(136, 18);
            this.labelUsuarioEnSesion.TabIndex = 1;
            this.labelUsuarioEnSesion.Text = "Usuario en sesión: ";
            // 
            // labelUsuarioSesionNombre
            // 
            this.labelUsuarioSesionNombre.AutoSize = true;
            this.labelUsuarioSesionNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelUsuarioSesionNombre.Location = new System.Drawing.Point(172, 17);
            this.labelUsuarioSesionNombre.Name = "labelUsuarioSesionNombre";
            this.labelUsuarioSesionNombre.Size = new System.Drawing.Size(75, 18);
            this.labelUsuarioSesionNombre.TabIndex = 2;
            this.labelUsuarioSesionNombre.Text = "NOMBRE";
            // 
            // mostradorDeCalendario
            // 
            this.mostradorDeCalendario.BackColor = System.Drawing.SystemColors.Window;
            this.mostradorDeCalendario.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.mostradorDeCalendario.Location = new System.Drawing.Point(18, 50);
            this.mostradorDeCalendario.Name = "mostradorDeCalendario";
            this.mostradorDeCalendario.TabIndex = 3;
            this.mostradorDeCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mostradorDeCalendario_DateChanged);
            // 
            // labelFechaSeleccionada
            // 
            this.labelFechaSeleccionada.AutoSize = true;
            this.labelFechaSeleccionada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFechaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFechaSeleccionada.Location = new System.Drawing.Point(34, 370);
            this.labelFechaSeleccionada.Name = "labelFechaSeleccionada";
            this.labelFechaSeleccionada.Size = new System.Drawing.Size(142, 17);
            this.labelFechaSeleccionada.TabIndex = 4;
            this.labelFechaSeleccionada.Text = "Fecha seleccionada: ";
            // 
            // dataGridViewCalendario
            // 
            this.dataGridViewCalendario.AllowUserToAddRows = false;
            this.dataGridViewCalendario.AllowUserToDeleteRows = false;
            this.dataGridViewCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Actividades});
            this.dataGridViewCalendario.Location = new System.Drawing.Point(298, 17);
            this.dataGridViewCalendario.Name = "dataGridViewCalendario";
            this.dataGridViewCalendario.Size = new System.Drawing.Size(544, 421);
            this.dataGridViewCalendario.TabIndex = 5;
            this.dataGridViewCalendario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCalendario_CellEndEdit);
            // 
            // Hora
            // 
            this.Hora.HeaderText = "GMT-03";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Actividades
            // 
            this.Actividades.HeaderText = "Recordatorio";
            this.Actividades.Name = "Actividades";
            this.Actividades.Width = 350;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.dataGridViewCalendario);
            this.Controls.Add(this.labelFechaSeleccionada);
            this.Controls.Add(this.mostradorDeCalendario);
            this.Controls.Add(this.labelUsuarioSesionNombre);
            this.Controls.Add(this.labelUsuarioEnSesion);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Label labelUsuarioEnSesion;
        private System.Windows.Forms.Label labelUsuarioSesionNombre;
        private System.Windows.Forms.MonthCalendar mostradorDeCalendario;
        private System.Windows.Forms.Label labelFechaSeleccionada;
        private System.Windows.Forms.DataGridView dataGridViewCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividades;
    }
}