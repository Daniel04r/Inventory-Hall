namespace Inventory_Hall
{
    partial class ultimoacerca2
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Este software fue creado por: Jhon Daniel Rojas Martinez 2022-2164", "", "Las Herramientas fueron: SQL version 2019, IDE: Visual Studio version 2022 community, Frameworks: .NET7, lenguaje: C#.", "", "Este programa esta basado en un control de inventario que puede realizar entrada de productos,suplidores ", "y empeleados, al mismo tiempo podemos ver la distribucion de productos y se puede modificar la seccion del mismo y", " hacer la consulta de todos estos.", "", "Fue creado con el objetivo de proyecto final de la materia Programacion basica(ISW-122-50)" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(842, 424);
            listBox1.TabIndex = 0;
            // 
            // ultimoacerca2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 450);
            Controls.Add(listBox1);
            Name = "ultimoacerca2";
            Text = "ultimoacerca2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}