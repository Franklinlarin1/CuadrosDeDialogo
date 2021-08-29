using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulariomdi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void cuadroDeDialogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogos abrir_Dialogos = new Dialogos();
            abrir_Dialogos.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda abrir_ayuda = new ayuda();
            abrir_ayuda.MdiParent = this;
            abrir_ayuda.Show();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercade abrir_acercade = new acercade();
            abrir_acercade.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
