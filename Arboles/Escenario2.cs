using Arboles.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Escenario2 : Form
    {
        public Escenario2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clickMakeTree(object sender, EventArgs e)
        {
            String inOrdenText = textBoxInOrden.Text;
            String preOrdentext = textBoxPreOrden.Text;
            string[] arrayInOrderString = inOrdenText.Split(',');
            string[] arrayPreorderString = preOrdentext.Split(",");
            int[] numbersArrayInOrder = Array.ConvertAll(arrayInOrderString, int.Parse);
            int[] numbersArrayPreOrder = Array.ConvertAll(arrayInOrderString, int.Parse);
            //Nodo raiz = TreeUtils.ConstruirArbol(numbersArrayPreOrder, numbersArrayInOrder);
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
