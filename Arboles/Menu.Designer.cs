namespace Arboles
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            escenario1ToolStripMenuItem = new ToolStripMenuItem();
            escenario2ToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { escenario1ToolStripMenuItem, escenario2ToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // escenario1ToolStripMenuItem
            // 
            escenario1ToolStripMenuItem.Name = "escenario1ToolStripMenuItem";
            escenario1ToolStripMenuItem.Size = new Size(78, 20);
            escenario1ToolStripMenuItem.Text = "Escenario 1";
            escenario1ToolStripMenuItem.Click += btnAccederEscenario1_Click;
            // 
            // escenario2ToolStripMenuItem
            // 
            escenario2ToolStripMenuItem.Name = "escenario2ToolStripMenuItem";
            escenario2ToolStripMenuItem.Size = new Size(78, 20);
            escenario2ToolStripMenuItem.Text = "Escenario 2";
            escenario2ToolStripMenuItem.Click += btnAccederEscenario2_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += btnSalir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem escenario1ToolStripMenuItem;
        private ToolStripMenuItem escenario2ToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}