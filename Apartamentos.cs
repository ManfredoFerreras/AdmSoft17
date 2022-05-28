using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdmSoft.DAL;
using AdmSoft.Models;

namespace AdmSoft
{
    public partial class Apartamentos : Form
    {
        public Apartamentos()
        {
            InitializeComponent();
        }

        private AdmSoftContext db = new AdmSoftContext();

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarApto x = new frmAgregarApto(-1);
            x.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }


        void BuscarDatos()
        {
            var qry = from p in db.Aptos
                      select new { p.AptoId, p.AptoCode, p.AptoContact, p.Deuda, p.AptoPhone, p.AptoEmail };

            if (textBox1.Text != "")
            {
                qry = qry.Where(s => s.AptoCode.Contains(textBox1.Text));

            }


            dg.DataSource = qry.ToList();

            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iId = -1;

            int.TryParse(dg.CurrentRow.Cells[0].Value.ToString(), out iId);

            if (iId > 0)
            {
                frmAgregarApto x = new frmAgregarApto(iId);
                x.ShowDialog();
            }





        }

    }
}
