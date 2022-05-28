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
    public partial class frmConsultaRecibos : Form
    {
        public frmConsultaRecibos()
        {
            InitializeComponent();
        }


        private AdmSoftContext db = new AdmSoftContext();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        void BuscarDatos()
        {
            var qry = from p in db.Recibos
                      orderby(p.Fecha)
                      select new { p.ReciboId, p.Aptos.AptoCode, p.Fecha, p.Periodo, p.Importe, p.ImportePagado, Balance = p.Importe - p.ImportePagado, p.Pago, p.Anulado };

            if (textBox1.Text != "")
            {
                qry = qry.Where(s => s.AptoCode.Contains(textBox1.Text));

            }

            if (chkPagos.Checked==true)
            {

                qry = qry.Where(s => s.Pago ==true);
            }
            else
                qry = qry.Where(s => s.Pago == false);


            dg.DataSource = qry.ToList();


        }

        private void anularRecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i< dg.RowCount ; i++)
                {
                    if (dg.Rows[i].Selected == true)
                    {
                        int iReciboId  = Convert.ToInt32(dg.Rows[i].Cells[0].Value);
                        AnularRecibo(iReciboId);
                    }

                }
                db.SaveChanges();
                MessageBox.Show("Proceso conclido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error>" + ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }


        void AnularRecibo(int piReciboId)
        {

            var oRec = db.Recibos.Find(piReciboId);

            if (oRec.ImportePagado == 0)
            {
                oRec.Anulado = true;
                var oApto = db.Aptos.Find(oRec.AptoId);

                oApto.Deuda = oApto.Deuda - oRec.Importe;
                
            }
                

                         

        }

        private void editarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
            int iReciboId = Convert.ToInt32(dg.CurrentRow.Cells[0].Value);

            frmEditarRecibo x = new frmEditarRecibo(iReciboId);
             x.ShowDialog();
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error>" + ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }


    }
}
