namespace Arboles
{
    partial class Escenario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escenario2));
            textBoxPreOrden = new TextBox();
            textBoxInOrden = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPreOrden
            // 
            textBoxPreOrden.Enabled = false;
            textBoxPreOrden.Location = new Point(192, 47);
            textBoxPreOrden.Name = "textBoxPreOrden";
            textBoxPreOrden.Size = new Size(207, 23);
            textBoxPreOrden.TabIndex = 0;
            textBoxPreOrden.Text = "50, 17, 12, 9, 14, 23, 19, 72, 54, 67, 76";
            textBoxPreOrden.TextChanged += textBox1_TextChanged;
            // 
            // textBoxInOrden
            // 
            textBoxInOrden.Location = new Point(192, 85);
            textBoxInOrden.Name = "textBoxInOrden";
            textBoxInOrden.ScrollBars = ScrollBars.Vertical;
            textBoxInOrden.Size = new Size(207, 23);
            textBoxInOrden.TabIndex = 0;
            textBoxInOrden.Text = "9, 12, 14, 17, 19, 23, 50, 54, 67, 72, 76";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 55);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "preorden";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 93);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "inorden";
            // 
            // button1
            // 
            button1.Location = new Point(501, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Mostrar Arbol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clickMakeTree;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 154);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Escenario2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxInOrden);
            Controls.Add(textBoxPreOrden);
            Name = "Escenario2";
            Text = "Escenario2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPreOrden;
        private TextBox textBoxInOrden;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}