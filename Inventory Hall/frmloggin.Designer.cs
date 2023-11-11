namespace Inventory_Hall
{
    partial class frmloggin
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
            btnloggin = new Button();
            bntcancelar = new Button();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblcontrasena = new Label();
            mtxtcontrasena = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnloggin
            // 
            btnloggin.BackColor = Color.DarkGreen;
            btnloggin.Cursor = Cursors.Hand;
            btnloggin.FlatAppearance.BorderColor = Color.Black;
            btnloggin.FlatAppearance.MouseDownBackColor = Color.White;
            btnloggin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnloggin.ForeColor = SystemColors.ButtonHighlight;
            btnloggin.Location = new Point(161, 277);
            btnloggin.Name = "btnloggin";
            btnloggin.Size = new Size(131, 80);
            btnloggin.TabIndex = 0;
            btnloggin.Text = "Iniciar Sesión";
            btnloggin.UseVisualStyleBackColor = false;
            btnloggin.Click += btnloggin_Click;
            // 
            // bntcancelar
            // 
            bntcancelar.BackColor = Color.Red;
            bntcancelar.Cursor = Cursors.Hand;
            bntcancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bntcancelar.ForeColor = SystemColors.ButtonHighlight;
            bntcancelar.Location = new Point(344, 277);
            bntcancelar.Name = "bntcancelar";
            bntcancelar.Size = new Size(131, 80);
            bntcancelar.TabIndex = 1;
            bntcancelar.Text = "Cancelar";
            bntcancelar.UseVisualStyleBackColor = false;
            bntcancelar.Click += btncancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(173, 67);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(322, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.Maroon;
            lblUsuario.Location = new Point(85, 71);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblcontrasena
            // 
            lblcontrasena.AutoSize = true;
            lblcontrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblcontrasena.ForeColor = Color.Maroon;
            lblcontrasena.Location = new Point(56, 125);
            lblcontrasena.Name = "lblcontrasena";
            lblcontrasena.Size = new Size(99, 23);
            lblcontrasena.TabIndex = 5;
            lblcontrasena.Text = "Contraseña";
            // 
            // mtxtcontrasena
            // 
            mtxtcontrasena.Location = new Point(173, 125);
            mtxtcontrasena.Name = "mtxtcontrasena";
            mtxtcontrasena.PasswordChar = '*';
            mtxtcontrasena.Size = new Size(322, 27);
            mtxtcontrasena.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_Dark_Violet_Purple_User_Interface_Login_Mobile_Prototipe__5_;
            pictureBox1.Location = new Point(572, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 319);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmloggin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1074, 394);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(mtxtcontrasena);
            Controls.Add(lblcontrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(bntcancelar);
            Controls.Add(btnloggin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmloggin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CONTROL DE ACCESO";
            Load += frmloggin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnloggin;
        private Button bntcancelar;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblcontrasena;
        private MaskedTextBox mtxtcontrasena;
        private PictureBox pictureBox1;
    }
}