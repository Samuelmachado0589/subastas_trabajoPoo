namespace subastas.pro
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            participacionToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem1 = new ToolStripMenuItem();
            resgistrosToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { participacionToolStripMenuItem, gestionToolStripMenuItem, resgistrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1324, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // participacionToolStripMenuItem
            // 
            participacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem });
            participacionToolStripMenuItem.Name = "participacionToolStripMenuItem";
            participacionToolStripMenuItem.Size = new Size(88, 20);
            participacionToolStripMenuItem.Text = "&Participacion";
            participacionToolStripMenuItem.Click += participacionToolStripMenuItem_Click;
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(106, 22);
            cerrarToolStripMenuItem.Text = "&Cerrar";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem1 });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(59, 20);
            gestionToolStripMenuItem.Text = "&Gestion";
            gestionToolStripMenuItem.Click += gestionToolStripMenuItem_Click;
            // 
            // cerrarToolStripMenuItem1
            // 
            cerrarToolStripMenuItem1.Name = "cerrarToolStripMenuItem1";
            cerrarToolStripMenuItem1.Size = new Size(180, 22);
            cerrarToolStripMenuItem1.Text = "&cerrar";
            cerrarToolStripMenuItem1.Click += cerrarToolStripMenuItem1_Click;
            // 
            // resgistrosToolStripMenuItem
            // 
            resgistrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem2 });
            resgistrosToolStripMenuItem.Name = "resgistrosToolStripMenuItem";
            resgistrosToolStripMenuItem.Size = new Size(72, 20);
            resgistrosToolStripMenuItem.Text = "&Resgistros";
            resgistrosToolStripMenuItem.Click += resgistrosToolStripMenuItem_Click;
            // 
            // cerrarToolStripMenuItem2
            // 
            cerrarToolStripMenuItem2.Name = "cerrarToolStripMenuItem2";
            cerrarToolStripMenuItem2.Size = new Size(180, 22);
            cerrarToolStripMenuItem2.Text = "&Cerrar";
            cerrarToolStripMenuItem2.Click += cerrarToolStripMenuItem2_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 593);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem participacionToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem resgistrosToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem1;
        private ToolStripMenuItem cerrarToolStripMenuItem2;
    }
}
