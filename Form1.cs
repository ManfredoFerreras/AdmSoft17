using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminitraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apartamentos x = new Apartamentos();
            x.MdiParent = this;
            x.Show();
        }

        private void generaciónDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarFact x = new GenerarFact();
            x.MdiParent = this;
            x.Show();
        }

        private void generaciónIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenFactIndividual x = new GenFactIndividual();
            x.MdiParent = this;
            x.Show();
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagos x = new frmPagos();
            x.MdiParent = this;
            x.Show();
        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRecibos x = new frmConsultaRecibos();
            x.MdiParent = this;
            x.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPagos x = new frmConsultaPagos();
            x.MdiParent = this;
            x.Show();
        }

        private void deudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteDeuda x = new ReporteDeuda();
            x.MdiParent = this;
            x.Show();
        }

        private void cuadreDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuadreCaja x = new CuadreCaja();
            x.MdiParent = this;
            x.Show();
        }
    }
}
