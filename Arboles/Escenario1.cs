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
            Console.WriteLine("Recorrido Preorden:");
            TreeUtils.RecorridoPreorden(TreeUtils.contruirArbol());
            Console.WriteLine();
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Recorrido Inorden:");
            TreeUtils.RecorridoInorden(TreeUtils.contruirArbol());
            Console.WriteLine();
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Recorrido Postorden:");
            TreeUtils.RecorridoPostorden(TreeUtils.contruirArbol());
            Console.WriteLine();
        }
    }
}
