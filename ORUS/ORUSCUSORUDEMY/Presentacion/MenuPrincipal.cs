using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCUSORUDEMY.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Personal control = new Personal();
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

        }
    }
}
