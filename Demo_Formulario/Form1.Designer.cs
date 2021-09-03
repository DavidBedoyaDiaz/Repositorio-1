
namespace Demo_Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btncolor = new System.Windows.Forms.Button();
            this.BtnSaludar = new System.Windows.Forms.Button();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.BtnRojo = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btncolor
            // 
            this.Btncolor.Location = new System.Drawing.Point(199, 221);
            this.Btncolor.Name = "Btncolor";
            this.Btncolor.Size = new System.Drawing.Size(84, 32);
            this.Btncolor.TabIndex = 0;
            this.Btncolor.Text = "Azul";
            this.Btncolor.UseVisualStyleBackColor = true;
            this.Btncolor.Visible = false;
            this.Btncolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSaludar
            // 
            this.BtnSaludar.Location = new System.Drawing.Point(470, 221);
            this.BtnSaludar.Name = "BtnSaludar";
            this.BtnSaludar.Size = new System.Drawing.Size(75, 32);
            this.BtnSaludar.TabIndex = 1;
            this.BtnSaludar.Text = "Saludar";
            this.BtnSaludar.UseVisualStyleBackColor = true;
            this.BtnSaludar.Visible = false;
            this.BtnSaludar.Click += new System.EventHandler(this.BtnSaludar_Click);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.Location = new System.Drawing.Point(192, 27);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(404, 93);
            this.LblBienvenido.TabIndex = 2;
            this.LblBienvenido.Text = "Bienvenido";
            // 
            // BtnRojo
            // 
            this.BtnRojo.Location = new System.Drawing.Point(199, 306);
            this.BtnRojo.Name = "BtnRojo";
            this.BtnRojo.Size = new System.Drawing.Size(84, 32);
            this.BtnRojo.TabIndex = 3;
            this.BtnRojo.Text = "Rojo";
            this.BtnRojo.UseVisualStyleBackColor = true;
            this.BtnRojo.Visible = false;
            this.BtnRojo.Click += new System.EventHandler(this.BtnRojo_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Location = new System.Drawing.Point(470, 306);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(75, 32);
            this.BtnUsuario.TabIndex = 4;
            this.BtnUsuario.Text = "Usuario";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(342, 374);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnUsuario);
            this.Controls.Add(this.BtnRojo);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.BtnSaludar);
            this.Controls.Add(this.Btncolor);
            this.Name = "Form1";
            this.Text = "Primera aplicación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btncolor;
        private System.Windows.Forms.Button BtnSaludar;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Button BtnRojo;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnLogin;
    }
}

