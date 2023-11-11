namespace Inventory_Hall
{
    partial class agrproducto
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
            ingresarproducto = new Label();
            txtnombre = new TextBox();
            txtdescripcion = new TextBox();
            txtstock = new TextBox();
            txtseccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtcategoria = new ComboBox();
            txtidsuplidor = new ComboBox();
            btnnuevo = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // ingresarproducto
            // 
            ingresarproducto.AutoSize = true;
            ingresarproducto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ingresarproducto.Location = new Point(265, 9);
            ingresarproducto.Name = "ingresarproducto";
            ingresarproducto.Size = new Size(206, 31);
            ingresarproducto.TabIndex = 0;
            ingresarproducto.Text = "Ingresar producto";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(119, 75);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(151, 27);
            txtnombre.TabIndex = 1;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(119, 164);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(151, 27);
            txtdescripcion.TabIndex = 2;
            // 
            // txtstock
            // 
            txtstock.Location = new Point(119, 202);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(151, 27);
            txtstock.TabIndex = 4;
            // 
            // txtseccion
            // 
            txtseccion.Location = new Point(119, 285);
            txtseccion.Name = "txtseccion";
            txtseccion.Size = new Size(151, 27);
            txtseccion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 167);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 8;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 121);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 9;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 209);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 10;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 245);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 11;
            label5.Text = "ID Suplidor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 288);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 12;
            label6.Text = "Sección";
            // 
            // txtcategoria
            // 
            txtcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcategoria.FormattingEnabled = true;
            txtcategoria.Location = new Point(119, 118);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(151, 28);
            txtcategoria.TabIndex = 13;
            txtcategoria.SelectedIndexChanged += txtcategoria_SelectedIndexChanged;
            // 
            // txtidsuplidor
            // 
            txtidsuplidor.DropDownStyle = ComboBoxStyle.DropDownList;
            txtidsuplidor.FormattingEnabled = true;
            txtidsuplidor.Location = new Point(119, 242);
            txtidsuplidor.Name = "txtidsuplidor";
            txtidsuplidor.Size = new Size(151, 28);
            txtidsuplidor.TabIndex = 14;
            txtidsuplidor.SelectedIndexChanged += txtidsuplidor_SelectedIndexChanged;
            // 
            // btnnuevo
            // 
            btnnuevo.BackColor = Color.FromArgb(192, 192, 0);
            btnnuevo.Cursor = Cursors.Hand;
            btnnuevo.FlatStyle = FlatStyle.Flat;
            btnnuevo.ForeColor = Color.White;
            btnnuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnnuevo.IconColor = Color.White;
            btnnuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevo.IconSize = 18;
            btnnuevo.Location = new Point(119, 338);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(151, 29);
            btnnuevo.TabIndex = 15;
            btnnuevo.Text = "Nuevo";
            btnnuevo.TextAlign = ContentAlignment.MiddleRight;
            btnnuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevo.UseVisualStyleBackColor = false;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Green;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 18;
            btnguardar.Location = new Point(119, 385);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(151, 29);
            btnguardar.TabIndex = 16;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // agrproducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(btnguardar);
            Controls.Add(btnnuevo);
            Controls.Add(txtidsuplidor);
            Controls.Add(txtcategoria);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtseccion);
            Controls.Add(txtstock);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnombre);
            Controls.Add(ingresarproducto);
            Name = "agrproducto";
            Text = "Entrada de producto";
            Load += agrproducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ingresarproducto;
        private TextBox txtnombre;
        private TextBox txtdescripcion;
        private TextBox txtstock;
        private TextBox txtseccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox txtcategoria;
        private ComboBox txtidsuplidor;
        private FontAwesome.Sharp.IconButton btnnuevo;
        private FontAwesome.Sharp.IconButton btnguardar;
    }
}