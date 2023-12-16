namespace Inventory_Hall
{
    partial class consultaempleado
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
            dataGridempleado = new DataGridView();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnrefresh = new FontAwesome.Sharp.IconButton();
            txtempleado = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridempleado).BeginInit();
            SuspendLayout();
            // 
            // dataGridempleado
            // 
            dataGridempleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridempleado.Location = new Point(12, 12);
            dataGridempleado.Name = "dataGridempleado";
            dataGridempleado.RowHeadersWidth = 51;
            dataGridempleado.RowTemplate.Height = 29;
            dataGridempleado.Size = new Size(1164, 346);
            dataGridempleado.TabIndex = 0;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.FromArgb(255, 128, 0);
            btnbuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.White;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 20;
            btnbuscar.Location = new Point(392, 381);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.FromArgb(255, 192, 128);
            btnrefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            btnrefresh.IconColor = Color.White;
            btnrefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnrefresh.IconSize = 20;
            btnrefresh.Location = new Point(492, 381);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(94, 29);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Refresh";
            btnrefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // txtempleado
            // 
            txtempleado.Location = new Point(130, 400);
            txtempleado.Name = "txtempleado";
            txtempleado.Size = new Size(134, 27);
            txtempleado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 377);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese Empleado";
            // 
            // consultaempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 450);
            Controls.Add(label1);
            Controls.Add(txtempleado);
            Controls.Add(btnrefresh);
            Controls.Add(btnbuscar);
            Controls.Add(dataGridempleado);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "consultaempleado";
            Text = "consultaempleado";
            Load += consultaempleado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridempleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridempleado;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnrefresh;
        private TextBox txtempleado;
        private Label label1;
    }
}