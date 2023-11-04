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
            btnloggin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnloggin.Location = new Point(150, 341);
            btnloggin.Name = "btnloggin";
            btnloggin.Size = new Size(131, 80);
            btnloggin.TabIndex = 0;
            btnloggin.Text = "Iniciar Sesión";
            btnloggin.UseVisualStyleBackColor = true;
            btnloggin.Click += btnloggin_Click;
            // 
            // bntcancelar
            // 
            bntcancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bntcancelar.Location = new Point(364, 341);
            bntcancelar.Name = "bntcancelar";
            bntcancelar.Size = new Size(131, 80);
            bntcancelar.TabIndex = 1;
            bntcancelar.Text = "Cancelar";
            bntcancelar.UseVisualStyleBackColor = true;
            bntcancelar.Click += btncancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(173, 118);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(322, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(60, 118);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblcontrasena
            // 
            lblcontrasena.AutoSize = true;
            lblcontrasena.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblcontrasena.Location = new Point(31, 234);
            lblcontrasena.Name = "lblcontrasena";
            lblcontrasena.Size = new Size(99, 23);
            lblcontrasena.TabIndex = 5;
            lblcontrasena.Text = "Contraseña";
            // 
            // mtxtcontrasena
            // 
            mtxtcontrasena.Location = new Point(173, 233);
            mtxtcontrasena.Name = "mtxtcontrasena";
            mtxtcontrasena.PasswordChar = '*';
            mtxtcontrasena.Size = new Size(322, 27);
            mtxtcontrasena.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources._47dd39cb_6c3a_48c7_a908_e344736fb2e2;
            pictureBox1.Location = new Point(537, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 333);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmloggin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1072, 450);
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