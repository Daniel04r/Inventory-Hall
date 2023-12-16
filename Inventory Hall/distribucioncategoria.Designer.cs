namespace Inventory_Hall
{
    partial class distribucioncategoria
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
            datagridcategoria = new DataGridView();
            comboBoxIDcategoria = new ComboBox();
            nuevasesion = new TextBox();
            mascaraIdcategoria = new Label();
            label1 = new Label();
            btnactualizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)datagridcategoria).BeginInit();
            SuspendLayout();
            // 
            // datagridcategoria
            // 
            datagridcategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridcategoria.Location = new Point(12, 12);
            datagridcategoria.Name = "datagridcategoria";
            datagridcategoria.RowHeadersWidth = 51;
            datagridcategoria.RowTemplate.Height = 29;
            datagridcategoria.Size = new Size(922, 354);
            datagridcategoria.TabIndex = 0;
            // 
            // comboBoxIDcategoria
            // 
            comboBoxIDcategoria.FormattingEnabled = true;
            comboBoxIDcategoria.Location = new Point(191, 409);
            comboBoxIDcategoria.Name = "comboBoxIDcategoria";
            comboBoxIDcategoria.Size = new Size(151, 28);
            comboBoxIDcategoria.TabIndex = 1;
            comboBoxIDcategoria.SelectedIndexChanged += comboBoxIDcategoria_SelectedIndexChanged;
            // 
            // nuevasesion
            // 
            nuevasesion.Location = new Point(519, 409);
            nuevasesion.Name = "nuevasesion";
            nuevasesion.Size = new Size(187, 27);
            nuevasesion.TabIndex = 2;
            // 
            // mascaraIdcategoria
            // 
            mascaraIdcategoria.AutoSize = true;
            mascaraIdcategoria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mascaraIdcategoria.Location = new Point(191, 383);
            mascaraIdcategoria.Name = "mascaraIdcategoria";
            mascaraIdcategoria.Size = new Size(111, 23);
            mascaraIdcategoria.TabIndex = 3;
            mascaraIdcategoria.Text = "ID Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(519, 383);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 4;
            label1.Text = "Agregar Nueva Sesion";
            // 
            // btnactualizar
            // 
            btnactualizar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnactualizar.IconColor = Color.Green;
            btnactualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnactualizar.IconSize = 20;
            btnactualizar.Location = new Point(370, 477);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(116, 38);
            btnactualizar.TabIndex = 5;
            btnactualizar.Text = "Actualizar";
            btnactualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // distribucioncategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 527);
            Controls.Add(btnactualizar);
            Controls.Add(label1);
            Controls.Add(mascaraIdcategoria);
            Controls.Add(nuevasesion);
            Controls.Add(comboBoxIDcategoria);
            Controls.Add(datagridcategoria);
            Name = "distribucioncategoria";
            Text = "distribucioncategoria";
            Load += distribucioncategoria_Load;
            ((System.ComponentModel.ISupportInitialize)datagridcategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridcategoria;
        private ComboBox comboBoxIDcategoria;
        private TextBox nuevasesion;
        private Label mascaraIdcategoria;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnactualizar;
    }
}