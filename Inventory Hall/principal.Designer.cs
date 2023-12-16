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
            pRODUCTOToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            eMPLEADOToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            sUToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            pRODUCTOToolStripMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            cONSULTASToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            pRODUCTOToolStripMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            eMPLEADOToolStripMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            sUPLIDORToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            sISTEMAToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            aCERCADEToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.AutoSize = true;
            btncerrar.BackColor = SystemColors.ControlLightLight;
            btncerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncerrar.Image = Properties.Resources._330399_bad_cancel_clear_close_decline_icon;
            btncerrar.ImageAlign = ContentAlignment.TopCenter;
            btncerrar.Location = new Point(1422, 174);
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
            menuStrip2.Anchor = AnchorStyles.Top;
            menuStrip2.BackColor = Color.FromArgb(255, 128, 0);
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { eNTRADAToolStripMenuItem, pRODUCTOToolStripMenuItem1, cONSULTASToolStripMenuItem, sISTEMAToolStripMenuItem });
            menuStrip2.Location = new Point(354, -2);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RightToLeft = RightToLeft.No;
            menuStrip2.Size = new Size(728, 56);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // eNTRADAToolStripMenuItem
            // 
            eNTRADAToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
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
            pRODUCTOToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            pRODUCTOToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Box;
            pRODUCTOToolStripMenuItem.IconColor = Color.Black;
            pRODUCTOToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            pRODUCTOToolStripMenuItem.Size = new Size(168, 26);
            pRODUCTOToolStripMenuItem.Text = "PRODUCTO";
            pRODUCTOToolStripMenuItem.Click += pRODUCTOToolStripMenuItem_Click;
            // 
            // eMPLEADOToolStripMenuItem
            // 
            eMPLEADOToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            eMPLEADOToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            eMPLEADOToolStripMenuItem.IconColor = Color.Black;
            eMPLEADOToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            eMPLEADOToolStripMenuItem.Size = new Size(168, 26);
            eMPLEADOToolStripMenuItem.Text = "EMPLEADO";
            eMPLEADOToolStripMenuItem.Click += eMPLEADOToolStripMenuItem_Click;
            // 
            // sUToolStripMenuItem
            // 
            sUToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            sUToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Truck;
            sUToolStripMenuItem.IconColor = Color.Black;
            sUToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sUToolStripMenuItem.Name = "sUToolStripMenuItem";
            sUToolStripMenuItem.Size = new Size(168, 26);
            sUToolStripMenuItem.Text = "SUPLIDOR";
            sUToolStripMenuItem.Click += sUToolStripMenuItem_Click;
            // 
            // pRODUCTOToolStripMenuItem1
            // 
            pRODUCTOToolStripMenuItem1.BackColor = Color.FromArgb(255, 128, 0);
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
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 128);
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Store;
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.IconColor = Color.Black;
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.Name = "dISTRIBUCIÓNDEARTICULOSToolStripMenuItem";
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.Size = new Size(291, 26);
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.Text = "DISTRIBUCIÓN DE ARTICULOS";
            dISTRIBUCIÓNDEARTICULOSToolStripMenuItem.Click += dISTRIBUCIÓNDEARTICULOSToolStripMenuItem_Click;
            // 
            // cONSULTASToolStripMenuItem
            // 
            cONSULTASToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
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
            pRODUCTOToolStripMenuItem2.BackColor = Color.Yellow;
            pRODUCTOToolStripMenuItem2.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            pRODUCTOToolStripMenuItem2.IconColor = Color.Black;
            pRODUCTOToolStripMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pRODUCTOToolStripMenuItem2.Name = "pRODUCTOToolStripMenuItem2";
            pRODUCTOToolStripMenuItem2.Size = new Size(172, 26);
            pRODUCTOToolStripMenuItem2.Text = "PRODUCTO ";
            pRODUCTOToolStripMenuItem2.Click += pRODUCTOToolStripMenuItem2_Click;
            // 
            // eMPLEADOToolStripMenuItem1
            // 
            eMPLEADOToolStripMenuItem1.BackColor = Color.Yellow;
            eMPLEADOToolStripMenuItem1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            eMPLEADOToolStripMenuItem1.IconColor = Color.Black;
            eMPLEADOToolStripMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eMPLEADOToolStripMenuItem1.Name = "eMPLEADOToolStripMenuItem1";
            eMPLEADOToolStripMenuItem1.Size = new Size(172, 26);
            eMPLEADOToolStripMenuItem1.Text = "EMPLEADO";
            eMPLEADOToolStripMenuItem1.Click += eMPLEADOToolStripMenuItem1_Click;
            // 
            // sUPLIDORToolStripMenuItem
            // 
            sUPLIDORToolStripMenuItem.BackColor = Color.Yellow;
            sUPLIDORToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Truck;
            sUPLIDORToolStripMenuItem.IconColor = Color.Black;
            sUPLIDORToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sUPLIDORToolStripMenuItem.Name = "sUPLIDORToolStripMenuItem";
            sUPLIDORToolStripMenuItem.Size = new Size(172, 26);
            sUPLIDORToolStripMenuItem.Text = "SUPLIDOR";
            sUPLIDORToolStripMenuItem.Click += sUPLIDORToolStripMenuItem_Click;
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
            aCERCADEToolStripMenuItem.BackColor = Color.Red;
            aCERCADEToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            aCERCADEToolStripMenuItem.IconColor = Color.Black;
            aCERCADEToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            aCERCADEToolStripMenuItem.Size = new Size(224, 26);
            aCERCADEToolStripMenuItem.Text = "ACERCA DE ";
            aCERCADEToolStripMenuItem.Click += aCERCADEToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Nueva;
            pictureBox1.Location = new Point(380, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1096, 936);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1512, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btncerrar);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip2;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "principal";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Inventario";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncerrar;
        private MenuStrip menuStrip1;
        private Button button1;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem eNTRADAToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem pRODUCTOToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem cONSULTASToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem sISTEMAToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem pRODUCTOToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem eMPLEADOToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem sUToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem dISTRIBUCIÓNDEARTICULOSToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem pRODUCTOToolStripMenuItem2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem eMPLEADOToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem sUPLIDORToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem aCERCADEToolStripMenuItem;
    }
}