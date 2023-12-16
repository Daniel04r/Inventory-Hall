namespace Inventory_Hall
{
    partial class consultaproducto
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
            dataGridproducto = new DataGridView();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnrefresh = new FontAwesome.Sharp.IconButton();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridproducto).BeginInit();
            SuspendLayout();
            // 
            // dataGridproducto
            // 
            dataGridproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridproducto.Location = new Point(12, 12);
            dataGridproducto.Name = "dataGridproducto";
            dataGridproducto.RowHeadersWidth = 51;
            dataGridproducto.RowTemplate.Height = 29;
            dataGridproducto.Size = new Size(1044, 371);
            dataGridproducto.TabIndex = 0;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Gold;
            btnbuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.White;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 20;
            btnbuscar.Location = new Point(375, 444);
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
            btnrefresh.Location = new Point(512, 444);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(94, 29);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Refresh";
            btnrefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(186, 446);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 3;
            // 
            // consultaproducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 496);
            Controls.Add(txtID);
            Controls.Add(btnrefresh);
            Controls.Add(btnbuscar);
            Controls.Add(dataGridproducto);
            Name = "consultaproducto";
            Text = "consultaproducto";
            Load += consultaproducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridproducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridproducto;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnrefresh;
        private TextBox txtID;
    }
}