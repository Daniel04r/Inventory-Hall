namespace Inventory_Hall
{
    partial class agrempleado
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
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtdireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtemail = new TextBox();
            txtcargo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            mascaraDNI = new MaskedTextBox();
            label6 = new Label();
            Mascaratelefono = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            mascaracelular = new MaskedTextBox();
            btnguardar2 = new FontAwesome.Sharp.IconButton();
            btnnuevo2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(63, 97);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(219, 27);
            txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(63, 153);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(219, 27);
            txtapellido.TabIndex = 1;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(63, 211);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(219, 27);
            txtdireccion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 69);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 127);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 183);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 5;
            label3.Text = "Dirección";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(393, 97);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(219, 27);
            txtemail.TabIndex = 6;
            // 
            // txtcargo
            // 
            txtcargo.Location = new Point(393, 269);
            txtcargo.Name = "txtcargo";
            txtcargo.Size = new Size(219, 27);
            txtcargo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(393, 241);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 8;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(393, 69);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // mascaraDNI
            // 
            mascaraDNI.Location = new Point(63, 269);
            mascaraDNI.Mask = "000-000000-0";
            mascaraDNI.Name = "mascaraDNI";
            mascaraDNI.Size = new Size(85, 27);
            mascaraDNI.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(63, 241);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 11;
            label6.Text = "DNI";
            // 
            // Mascaratelefono
            // 
            Mascaratelefono.Location = new Point(393, 153);
            Mascaratelefono.Mask = "000-000000-0";
            Mascaratelefono.Name = "Mascaratelefono";
            Mascaratelefono.Size = new Size(85, 27);
            Mascaratelefono.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(396, 127);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 13;
            label7.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(393, 183);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 14;
            label8.Text = "Celular";
            // 
            // mascaracelular
            // 
            mascaracelular.Location = new Point(393, 211);
            mascaracelular.Mask = "000-000000-0";
            mascaracelular.Name = "mascaracelular";
            mascaracelular.Size = new Size(85, 27);
            mascaracelular.TabIndex = 15;
            // 
            // btnguardar2
            // 
            btnguardar2.BackColor = Color.FromArgb(0, 192, 0);
            btnguardar2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardar2.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnguardar2.IconColor = Color.White;
            btnguardar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar2.IconSize = 18;
            btnguardar2.Location = new Point(148, 370);
            btnguardar2.Name = "btnguardar2";
            btnguardar2.Size = new Size(112, 32);
            btnguardar2.TabIndex = 16;
            btnguardar2.Text = "Guardar";
            btnguardar2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar2.UseVisualStyleBackColor = false;
            btnguardar2.Click += btnguardar2_Click;
            // 
            // btnnuevo2
            // 
            btnnuevo2.BackColor = Color.Gold;
            btnnuevo2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnnuevo2.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnnuevo2.IconColor = Color.White;
            btnnuevo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevo2.IconSize = 18;
            btnnuevo2.Location = new Point(342, 370);
            btnnuevo2.Name = "btnnuevo2";
            btnnuevo2.Size = new Size(112, 29);
            btnnuevo2.TabIndex = 17;
            btnnuevo2.Text = "Nuevo";
            btnnuevo2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevo2.UseVisualStyleBackColor = false;
            btnnuevo2.Click += btnnuevo2_Click;
            // 
            // agrempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnnuevo2);
            Controls.Add(btnguardar2);
            Controls.Add(mascaracelular);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Mascaratelefono);
            Controls.Add(label6);
            Controls.Add(mascaraDNI);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtcargo);
            Controls.Add(txtemail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtdireccion);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "agrempleado";
            Text = "Registrar empleado";
            Load += agrempleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtdireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtemail;
        private TextBox txtcargo;
        private Label label4;
        private Label label5;
        private MaskedTextBox mascaraDNI;
        private Label label6;
        private MaskedTextBox Mascaratelefono;
        private Label label7;
        private Label label8;
        private MaskedTextBox mascaracelular;
        private FontAwesome.Sharp.IconButton btnguardar2;
        private FontAwesome.Sharp.IconButton btnnuevo2;
    }
}