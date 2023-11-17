namespace Arboles
{
    partial class Escenario1
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
            graficaToolStripMenuItem = new ToolStripMenuItem();
            recorridosToolStripMenuItem = new ToolStripMenuItem();
            preOrdenToolStripMenuItem = new ToolStripMenuItem();
            inOrdenToolStripMenuItem = new ToolStripMenuItem();
            postOrdenToolStripMenuItem = new ToolStripMenuItem();
            volverAlMenuToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { graficaToolStripMenuItem, recorridosToolStripMenuItem, volverAlMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // graficaToolStripMenuItem
            // 
            graficaToolStripMenuItem.Name = "graficaToolStripMenuItem";
            graficaToolStripMenuItem.Size = new Size(56, 20);
            graficaToolStripMenuItem.Text = "Grafica";
            graficaToolStripMenuItem.Click += TogglePictureBoxVisibility;
            // 
            // recorridosToolStripMenuItem
            // 
            recorridosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preOrdenToolStripMenuItem, inOrdenToolStripMenuItem, postOrdenToolStripMenuItem });
            recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            recorridosToolStripMenuItem.Size = new Size(75, 20);
            recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // preOrdenToolStripMenuItem
            // 
            preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            preOrdenToolStripMenuItem.Size = new Size(130, 22);
            preOrdenToolStripMenuItem.Text = "PreOrden";
            // 
            // inOrdenToolStripMenuItem
            // 
            inOrdenToolStripMenuItem.Name = "inOrdenToolStripMenuItem";
            inOrdenToolStripMenuItem.Size = new Size(130, 22);
            inOrdenToolStripMenuItem.Text = "InOrden";
            // 
            // postOrdenToolStripMenuItem
            // 
            postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            postOrdenToolStripMenuItem.Size = new Size(130, 22);
            postOrdenToolStripMenuItem.Text = "PostOrden";
            // 
            // volverAlMenuToolStripMenuItem
            // 
            volverAlMenuToolStripMenuItem.Name = "volverAlMenuToolStripMenuItem";
            volverAlMenuToolStripMenuItem.Size = new Size(97, 20);
            volverAlMenuToolStripMenuItem.Text = "Volver al menu";
            volverAlMenuToolStripMenuItem.Click += btnCerrarForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arbol;
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(561, 363);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Escenario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Escenario1";
            Text = "Escenario1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem graficaToolStripMenuItem;
        private ToolStripMenuItem recorridosToolStripMenuItem;
        private ToolStripMenuItem preOrdenToolStripMenuItem;
        private ToolStripMenuItem inOrdenToolStripMenuItem;
        private ToolStripMenuItem postOrdenToolStripMenuItem;
        private ToolStripMenuItem volverAlMenuToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}