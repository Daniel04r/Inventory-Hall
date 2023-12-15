namespace Inventory_Hall
{
    partial class agrsuplidor
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
            btnguardar3 = new FontAwesome.Sharp.IconButton();
            btnnuevo3 = new FontAwesome.Sharp.IconButton();
            txtdescripcion = new TextBox();
            txtdireccion = new TextBox();
            txtnombre = new TextBox();
            txtemail = new TextBox();
            mascararnc = new MaskedTextBox();
            mascaratelefono = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnguardar3
            // 
            btnguardar3.BackColor = Color.Lime;
            btnguardar3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardar3.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnguardar3.IconColor = Color.White;
            btnguardar3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar3.IconSize = 18;
            btnguardar3.Location = new Point(217, 436);
            btnguardar3.Name = "btnguardar3";
            btnguardar3.Size = new Size(127, 29);
            btnguardar3.TabIndex = 0;
            btnguardar3.Text = "Guardar";
            btnguardar3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar3.UseVisualStyleBackColor = false;
            btnguardar3.Click += btnguardar3_Click;
            // 
            // btnnuevo3
            // 
            btnnuevo3.BackColor = Color.Gold;
            btnnuevo3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnnuevo3.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnnuevo3.IconColor = Color.White;
            btnnuevo3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevo3.IconSize = 18;
            btnnuevo3.Location = new Point(403, 436);
            btnnuevo3.Name = "btnnuevo3";
            btnnuevo3.Size = new Size(114, 29);
            btnnuevo3.TabIndex = 1;
            btnnuevo3.Text = "Nuevo";
            btnnuevo3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevo3.UseVisualStyleBackColor = false;
            btnnuevo3.Click += btnnuevo3_Click;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(152, 335);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(192, 27);
            txtdescripcion.TabIndex = 2;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(152, 268);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(192, 27);
            txtdireccion.TabIndex = 3;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(152, 43);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(192, 27);
            txtnombre.TabIndex = 4;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(152, 95);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(192, 27);
            txtemail.TabIndex = 5;
            // 
            // mascararnc
            // 
            mascararnc.Location = new Point(152, 146);
            mascararnc.Mask = "000-0000-00";
            mascararnc.Name = "mascararnc";
            mascararnc.Size = new Size(75, 27);
            mascararnc.TabIndex = 6;
            // 
            // mascaratelefono
            // 
            mascaratelefono.Location = new Point(152, 205);
            mascaratelefono.Mask = "000-000-0000";
            mascaratelefono.Name = "mascaratelefono";
            mascaratelefono.Size = new Size(80, 27);
            mascaratelefono.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 43);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 150);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 9;
            label3.Text = "RNC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 209);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 10;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(58, 272);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 11;
            label5.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 336);
            label6.Name = "label6";
            label6.Size = new Size(103, 23);
            label6.TabIndex = 12;
            label6.Text = "Descripción";
            // 
            // agrsuplidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mascaratelefono);
            Controls.Add(mascararnc);
            Controls.Add(txtemail);
            Controls.Add(txtnombre);
            Controls.Add(txtdireccion);
            Controls.Add(txtdescripcion);
            Controls.Add(btnnuevo3);
            Controls.Add(btnguardar3);
            Name = "agrsuplidor";
            Text = "agrsuplidor";
            Load += agrsuplidor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnguardar3;
        private FontAwesome.Sharp.IconButton btnnuevo3;
        private TextBox txtdescripcion;
        private TextBox txtdireccion;
        private TextBox txtnombre;
        private TextBox txtemail;
        private MaskedTextBox mascararnc;
        private MaskedTextBox mascaratelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}