namespace Inventory_Hall
{
    partial class Consultasuplidor
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
            dataGrididsuplidor = new DataGridView();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnrefresh = new FontAwesome.Sharp.IconButton();
            txtidsuplidor = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrididsuplidor).BeginInit();
            SuspendLayout();
            // 
            // dataGrididsuplidor
            // 
            dataGrididsuplidor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrididsuplidor.Location = new Point(12, 12);
            dataGrididsuplidor.Name = "dataGrididsuplidor";
            dataGrididsuplidor.RowHeadersWidth = 51;
            dataGrididsuplidor.RowTemplate.Height = 29;
            dataGrididsuplidor.Size = new Size(949, 334);
            dataGrididsuplidor.TabIndex = 0;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.FromArgb(255, 128, 0);
            btnbuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.White;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 20;
            btnbuscar.Location = new Point(376, 392);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(111, 29);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.FromArgb(255, 192, 128);
            btnrefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            btnrefresh.IconColor = Color.White;
            btnrefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnrefresh.IconSize = 20;
            btnrefresh.Location = new Point(517, 392);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(107, 28);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Refresh";
            btnrefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // txtidsuplidor
            // 
            txtidsuplidor.Location = new Point(133, 394);
            txtidsuplidor.Name = "txtidsuplidor";
            txtidsuplidor.Size = new Size(125, 27);
            txtidsuplidor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 371);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese suplidor";
            // 
            // Consultasuplidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 450);
            Controls.Add(label1);
            Controls.Add(txtidsuplidor);
            Controls.Add(btnrefresh);
            Controls.Add(btnbuscar);
            Controls.Add(dataGrididsuplidor);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Consultasuplidor";
            Text = "Consultasuplidor";
            Load += Consultasuplidor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrididsuplidor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrididsuplidor;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnrefresh;
        private TextBox txtidsuplidor;
        private Label label1;
    }
}