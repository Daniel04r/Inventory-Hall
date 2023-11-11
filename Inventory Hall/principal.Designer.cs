namespace Inventory_Hall
{
    partial class principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncerrar = new Button();
            menuStrip2 = new MenuStrip();
            eNTRADAToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            pRODUCTOToolStripMenuItem = new ToolStripMenuItem();
            eMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            sUToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOToolStripMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem = new ToolStripMenuItem();
            cONSULTASToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            pRODUCTOToolStripMenuItem2 = new ToolStripMenuItem();
            eMPLEADOToolStripMenuItem1 = new ToolStripMenuItem();
            sUPLIDORToolStripMenuItem = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            aCERCADEToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.BackColor = SystemColors.ControlLightLight;
            btncerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncerrar.Image = Properties.Resources._330399_bad_cancel_clear_close_decline_icon;
            btncerrar.ImageAlign = ContentAlignment.TopCenter;
            btncerrar.Location = new Point(710, 70);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(78, 73);
            btncerrar.TabIndex = 0;
            btncerrar.Text = "Cerrar";
            btncerrar.TextAlign = ContentAlignment.BottomCenter;
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { eNTRADAToolStripMenuItem, pRODUCTOToolStripMenuItem1, cONSULTASToolStripMenuItem, sISTEMAToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 56);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // eNTRADAToolStripMenuItem
            // 
            eNTRADAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUCTOToolStripMenuItem, eMPLEADOToolStripMenuItem, sUToolStripMenuItem });
            eNTRADAToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            eNTRADAToolStripMenuItem.IconColor = Color.Black;
            eNTRADAToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eNTRADAToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            eNTRADAToolStripMenuItem.Size = new Size(138, 52);
            eNTRADAToolStripMenuItem.Text = "ENTRADA";
            eNTRADAToolStripMenuItem.Click += eNTRADAToolStripMenuItem_Click;
            // 
            // pRODUCTOToolStripMenuItem
            // 
            pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            pRODUCTOToolStripMenuItem.Size = new Size(224, 26);
            pRODUCTOToolStripMenuItem.Text = "PRODUCTO";
            pRODUCTOToolStripMenuItem.Click += pRODUCTOToolStripMenuItem_Click;
            // 
            // eMPLEADOToolStripMenuItem
            // 
            eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            eMPLEADOToolStripMenuItem.Size = new Size(224, 26);
            eMPLEADOToolStripMenuItem.Text = "EMPLEADO";
            eMPLEADOToolStripMenuItem.Click += eMPLEADOToolStripMenuItem_Click;
            // 
            // sUToolStripMenuItem
            // 
            sUToolStripMenuItem.Name = "sUToolStripMenuItem";
            sUToolStripMenuItem.Size = new Size(224, 26);
            sUToolStripMenuItem.Text = "SUPLIDOR";
            // 
            // pRODUCTOToolStripMenuItem1
            // 
            pRODUCTOToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { dISTRIBUCIÓNDEARTICULOSToolStripMenuItem });
            pRODUCTOToolStripMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Box;
            pRODUCTOToolStripMenuItem1.IconColor = Color.Black;
            pRODUCTOToolStripMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pRODUCTOToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            pRODUCTOToolStripMenuItem1.Name = "pRODUCTOToolStripMenuItem1";
            pRODUCTOToolStripMenuItem1.Size = new Size(147, 52);
            pRODUCTOToolStripMenuItem1.Text = "PRODUCTO";
            // 
            // dISTRIBUCIÓNDEARTICULOSToolStripMenuItem
            // 
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.Name = "dISTRIBUCIÓNDEARTICULOSToolStripMenuItem";
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.Size = new Size(291, 26);
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.Text = "DISTRIBUCIÓN DE ARTICULOS";
            // 
            // cONSULTASToolStripMenuItem
            // 
            cONSULTASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUCTOToolStripMenuItem2, eMPLEADOToolStripMenuItem1, sUPLIDORToolStripMenuItem });
            cONSULTASToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            cONSULTASToolStripMenuItem.IconColor = Color.Black;
            cONSULTASToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cONSULTASToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            cONSULTASToolStripMenuItem.Size = new Size(151, 52);
            cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            // 
            // pRODUCTOToolStripMenuItem2
            // 
            pRODUCTOToolStripMenuItem2.Name = "pRODUCTOToolStripMenuItem2";
            pRODUCTOToolStripMenuItem2.Size = new Size(172, 26);
            pRODUCTOToolStripMenuItem2.Text = "PRODUCTO ";
            // 
            // eMPLEADOToolStripMenuItem1
            // 
            eMPLEADOToolStripMenuItem1.Name = "eMPLEADOToolStripMenuItem1";
            eMPLEADOToolStripMenuItem1.Size = new Size(172, 26);
            eMPLEADOToolStripMenuItem1.Text = "EMPLEADO";
            // 
            // sUPLIDORToolStripMenuItem
            // 
            sUPLIDORToolStripMenuItem.Name = "sUPLIDORToolStripMenuItem";
            sUPLIDORToolStripMenuItem.Size = new Size(172, 26);
            sUPLIDORToolStripMenuItem.Text = "SUPLIDOR";
            // 
            // sISTEMAToolStripMenuItem
            // 
            sISTEMAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCERCADEToolStripMenuItem });
            sISTEMAToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            sISTEMAToolStripMenuItem.IconColor = Color.Black;
            sISTEMAToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sISTEMAToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            sISTEMAToolStripMenuItem.Size = new Size(134, 52);
            sISTEMAToolStripMenuItem.Text = "SISTEMA ";
            // 
            // aCERCADEToolStripMenuItem
            // 
            aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            aCERCADEToolStripMenuItem.Size = new Size(174, 26);
            aCERCADEToolStripMenuItem.Text = "ACERCA DE ";
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btncerrar);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "principal";
            Text = "Inventario";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncerrar;
        private MenuStrip menuStrip1;
        private Button button1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem dISTRIBUCIÓNDEARTICULOSToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOToolStripMenuItem2;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem1;
        private ToolStripMenuItem sUPLIDORToolStripMenuItem;
        private ToolStripMenuItem aCERCADEToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem eNTRADAToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOToolStripMenuItem;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private ToolStripMenuItem sUToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem pRODUCTOToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem cONSULTASToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem sISTEMAToolStripMenuItem;
    }
}