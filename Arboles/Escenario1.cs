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
    public partial class Escenario1 : Form
    {
        public Escenario1()
        {
            InitializeComponent();
        }

        private void TogglePictureBoxVisibility(object sender, EventArgs e)
        {
            // Verifica el estado actual de visibilidad del PictureBox
            if (pictureBox1.Visible)
            {
                // Si está visible, ocúltalo
                pictureBox1.Visible = false;
            }
            else
            {
                // Si está oculto, muéstralo
                pictureBox1.Visible = true;
            }
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recorrido Preorden:");
            String recorrido = TreeUtils.RecorridoPreorden(TreeUtils.contruirArbol());
            textBoxRecorrido.Text = recorrido;
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recorrido Inorden:");
            String recorrido = TreeUtils.RecorridoInorden(TreeUtils.contruirArbol());
            textBoxRecorrido.Text = recorrido;
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recorrido Postorden:");
            String recorrido = TreeUtils.RecorridoPostorden(TreeUtils.contruirArbol());
            textBoxRecorrido.Text = recorrido;
        }
    }
}
