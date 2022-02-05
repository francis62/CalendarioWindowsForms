
namespace CalendarioPrueba2
{
    partial class RegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuario));
            this.labelRegUsuario = new System.Windows.Forms.Label();
            this.labelRegContraseña = new System.Windows.Forms.Label();
            this.labelReg1 = new System.Windows.Forms.Label();
            this.labelReg2 = new System.Windows.Forms.Label();
            this.buttonVerContraseña = new System.Windows.Forms.Button();
            this.buttonOcultarContraseña = new System.Windows.Forms.Button();
            this.textBoxRegContraseña = new System.Windows.Forms.TextBox();
            this.textBoxRegUsuario = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelVolverLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRegUsuario
            // 
            this.labelRegUsuario.AutoSize = true;
            this.labelRegUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelRegUsuario.Location = new System.Drawing.Point(105, 99);
            this.labelRegUsuario.Name = "labelRegUsuario";
            this.labelRegUsuario.Size = new System.Drawing.Size(147, 20);
            this.labelRegUsuario.TabIndex = 0;
            this.labelRegUsuario.Text = "Ingrese su usuario";
            // 
            // labelRegContraseña
            // 
            this.labelRegContraseña.AutoSize = true;
            this.labelRegContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelRegContraseña.Location = new System.Drawing.Point(90, 167);
            this.labelRegContraseña.Name = "labelRegContraseña";
            this.labelRegContraseña.Size = new System.Drawing.Size(175, 20);
            this.labelRegContraseña.TabIndex = 2;
            this.labelRegContraseña.Text = "Ingrese su contraseña";
            // 
            // labelReg1
            // 
            this.labelReg1.AutoSize = true;
            this.labelReg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg1.Location = new System.Drawing.Point(22, 9);
            this.labelReg1.Name = "labelReg1";
            this.labelReg1.Size = new System.Drawing.Size(309, 25);
            this.labelReg1.TabIndex = 4;
            this.labelReg1.Text = "Registrate para poder acceder ";
            // 
            // labelReg2
            // 
            this.labelReg2.AutoSize = true;
            this.labelReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg2.Location = new System.Drawing.Point(78, 34);
            this.labelReg2.Name = "labelReg2";
            this.labelReg2.Size = new System.Drawing.Size(198, 25);
            this.labelReg2.TabIndex = 5;
            this.labelReg2.Text = "a tu propia agenda!";
            // 
            // buttonVerContraseña
            // 
            this.buttonVerContraseña.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerContraseña.Image = ((System.Drawing.Image)(resources.GetObject("buttonVerContraseña.Image")));
            this.buttonVerContraseña.Location = new System.Drawing.Point(243, 190);
            this.buttonVerContraseña.Name = "buttonVerContraseña";
            this.buttonVerContraseña.Size = new System.Drawing.Size(43, 20);
            this.buttonVerContraseña.TabIndex = 9;
            this.buttonVerContraseña.UseVisualStyleBackColor = true;
            this.buttonVerContraseña.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonVerContraseña_MouseClick);
            // 
            // buttonOcultarContraseña
            // 
            this.buttonOcultarContraseña.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonOcultarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOcultarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("buttonOcultarContraseña.Image")));
            this.buttonOcultarContraseña.Location = new System.Drawing.Point(243, 190);
            this.buttonOcultarContraseña.Name = "buttonOcultarContraseña";
            this.buttonOcultarContraseña.Size = new System.Drawing.Size(43, 20);
            this.buttonOcultarContraseña.TabIndex = 7;
            this.buttonOcultarContraseña.UseVisualStyleBackColor = true;
            this.buttonOcultarContraseña.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOcultarContraseña_MouseClick);
            // 
            // textBoxRegContraseña
            // 
            this.textBoxRegContraseña.BackColor = System.Drawing.Color.LightGray;
            this.textBoxRegContraseña.Location = new System.Drawing.Point(63, 190);
            this.textBoxRegContraseña.Name = "textBoxRegContraseña";
            this.textBoxRegContraseña.PasswordChar = '*';
            this.textBoxRegContraseña.Size = new System.Drawing.Size(223, 20);
            this.textBoxRegContraseña.TabIndex = 10;
            // 
            // textBoxRegUsuario
            // 
            this.textBoxRegUsuario.BackColor = System.Drawing.Color.LightGray;
            this.textBoxRegUsuario.Location = new System.Drawing.Point(63, 122);
            this.textBoxRegUsuario.Name = "textBoxRegUsuario";
            this.textBoxRegUsuario.Size = new System.Drawing.Size(223, 20);
            this.textBoxRegUsuario.TabIndex = 11;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.LightGray;
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonAddUser.ForeColor = System.Drawing.Color.Black;
            this.buttonAddUser.Location = new System.Drawing.Point(63, 250);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(216, 44);
            this.buttonAddUser.TabIndex = 12;
            this.buttonAddUser.Text = "Registrar Usuario";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelVolverLogin
            // 
            this.labelVolverLogin.AutoSize = true;
            this.labelVolverLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelVolverLogin.Location = new System.Drawing.Point(50, 319);
            this.labelVolverLogin.Name = "labelVolverLogin";
            this.labelVolverLogin.Size = new System.Drawing.Size(246, 18);
            this.labelVolverLogin.TabIndex = 13;
            this.labelVolverLogin.Text = "Ya tienes una cuenta? Ingresa ahora";
            this.labelVolverLogin.Click += new System.EventHandler(this.labelVolverLogin_Click);
            this.labelVolverLogin.MouseEnter += new System.EventHandler(this.labelVolverLogin_MouseEnter);
            this.labelVolverLogin.MouseLeave += new System.EventHandler(this.labelVolverLogin_MouseLeave);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 346);
            this.Controls.Add(this.labelVolverLogin);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.textBoxRegUsuario);
            this.Controls.Add(this.labelReg2);
            this.Controls.Add(this.labelReg1);
            this.Controls.Add(this.labelRegContraseña);
            this.Controls.Add(this.labelRegUsuario);
            this.Controls.Add(this.buttonVerContraseña);
            this.Controls.Add(this.buttonOcultarContraseña);
            this.Controls.Add(this.textBoxRegContraseña);
            this.Name = "RegistrarUsuario";
            this.Text = "RegistrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegUsuario;
        private System.Windows.Forms.Label labelRegContraseña;
        private System.Windows.Forms.Label labelReg1;
        private System.Windows.Forms.Label labelReg2;
        private System.Windows.Forms.Button buttonVerContraseña;
        private System.Windows.Forms.Button buttonOcultarContraseña;
        private System.Windows.Forms.TextBox textBoxRegContraseña;
        private System.Windows.Forms.TextBox textBoxRegUsuario;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelVolverLogin;
    }
}