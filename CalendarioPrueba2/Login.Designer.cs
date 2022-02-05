
namespace CalendarioPrueba2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelPresentacionUno = new System.Windows.Forms.Label();
            this.labelPresentacionDos = new System.Windows.Forms.Label();
            this.buttonOcultarContraseña = new System.Windows.Forms.Button();
            this.buttonVerContraseña = new System.Windows.Forms.Button();
            this.buttonRegistrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelUsuario.Location = new System.Drawing.Point(55, 110);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(67, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelContraseña.Location = new System.Drawing.Point(55, 183);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(95, 20);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUsuario.Location = new System.Drawing.Point(59, 143);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(223, 20);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.Color.LightGray;
            this.textBoxContraseña.Location = new System.Drawing.Point(59, 216);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(224, 20);
            this.textBoxContraseña.TabIndex = 3;
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonIniciarSesion.Location = new System.Drawing.Point(12, 297);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(160, 31);
            this.buttonIniciarSesion.TabIndex = 4;
            this.buttonIniciarSesion.Text = "Iniciar Sesión";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(79, 307);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 5;
            // 
            // labelPresentacionUno
            // 
            this.labelPresentacionUno.AutoSize = true;
            this.labelPresentacionUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.labelPresentacionUno.Location = new System.Drawing.Point(114, 9);
            this.labelPresentacionUno.Name = "labelPresentacionUno";
            this.labelPresentacionUno.Size = new System.Drawing.Size(129, 29);
            this.labelPresentacionUno.TabIndex = 6;
            this.labelPresentacionUno.Text = "Agenda en";
            // 
            // labelPresentacionDos
            // 
            this.labelPresentacionDos.AutoSize = true;
            this.labelPresentacionDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.labelPresentacionDos.Location = new System.Drawing.Point(87, 38);
            this.labelPresentacionDos.Name = "labelPresentacionDos";
            this.labelPresentacionDos.Size = new System.Drawing.Size(187, 29);
            this.labelPresentacionDos.TabIndex = 7;
            this.labelPresentacionDos.Text = "Windows Forms";
            // 
            // buttonOcultarContraseña
            // 
            this.buttonOcultarContraseña.BackColor = System.Drawing.Color.White;
            this.buttonOcultarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOcultarContraseña.ForeColor = System.Drawing.Color.Black;
            this.buttonOcultarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("buttonOcultarContraseña.Image")));
            this.buttonOcultarContraseña.Location = new System.Drawing.Point(247, 216);
            this.buttonOcultarContraseña.Name = "buttonOcultarContraseña";
            this.buttonOcultarContraseña.Size = new System.Drawing.Size(36, 20);
            this.buttonOcultarContraseña.TabIndex = 10;
            this.buttonOcultarContraseña.UseVisualStyleBackColor = false;
            this.buttonOcultarContraseña.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOcultarContraseña_MouseClick);
            // 
            // buttonVerContraseña
            // 
            this.buttonVerContraseña.BackColor = System.Drawing.Color.White;
            this.buttonVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerContraseña.ForeColor = System.Drawing.Color.Black;
            this.buttonVerContraseña.Image = ((System.Drawing.Image)(resources.GetObject("buttonVerContraseña.Image")));
            this.buttonVerContraseña.Location = new System.Drawing.Point(247, 216);
            this.buttonVerContraseña.Name = "buttonVerContraseña";
            this.buttonVerContraseña.Size = new System.Drawing.Size(36, 20);
            this.buttonVerContraseña.TabIndex = 11;
            this.buttonVerContraseña.UseVisualStyleBackColor = false;
            this.buttonVerContraseña.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonVerContraseña_MouseClick);
            // 
            // buttonRegistrarUsuario
            // 
            this.buttonRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonRegistrarUsuario.Location = new System.Drawing.Point(178, 297);
            this.buttonRegistrarUsuario.Name = "buttonRegistrarUsuario";
            this.buttonRegistrarUsuario.Size = new System.Drawing.Size(160, 31);
            this.buttonRegistrarUsuario.TabIndex = 12;
            this.buttonRegistrarUsuario.Text = "Registrarse";
            this.buttonRegistrarUsuario.UseVisualStyleBackColor = true;
            this.buttonRegistrarUsuario.Click += new System.EventHandler(this.buttonRegistrarUsuario_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 345);
            this.Controls.Add(this.buttonRegistrarUsuario);
            this.Controls.Add(this.buttonVerContraseña);
            this.Controls.Add(this.buttonOcultarContraseña);
            this.Controls.Add(this.labelPresentacionDos);
            this.Controls.Add(this.labelPresentacionUno);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelPresentacionUno;
        private System.Windows.Forms.Label labelPresentacionDos;
        private System.Windows.Forms.Button buttonOcultarContraseña;
        private System.Windows.Forms.Button buttonVerContraseña;
        private System.Windows.Forms.Button buttonRegistrarUsuario;
    }
}

