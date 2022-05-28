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
    public partial class GenerarFact : Form
    {
        public GenerarFact()
        {
            InitializeComponent();
        }

        private AdmSoftContext db = new AdmSoftContext();

        private void GenerarFact_Load(object sender, EventArgs e)
        {
            txtFecha.Value = DateTime.Now;

            txtPeriodo.Text = txtFecha.Value.Year.ToString() + txtFecha.Value.Month.ToString().PadLeft(2, '0');
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere generar facturas de mantenimiento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                GenerarFacturas();
                MessageBox.Show("Proceso ejecutado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        void GenerarFacturas()
        {

            var qry = from p in db.Aptos
                      where (p.Activo == true)
                      select new { p.AptoId, p.Cuota, p.Deuda };

            //

            foreach(var oApto in qry.ToList())
            {
                var oExisteRecibo = from p in db.Recibos
                                    where (p.Periodo == txtPeriodo.Text && p.AptoId == oApto.AptoId)
                                    select new { p.ReciboId };

                if (oExisteRecibo.ToList().Count == 0)
                {


                    Recibos oRec = new Recibos();

                    oRec.AptoId = oApto.AptoId;
                    oRec.Concepto = "CUOTA DE MANTENIMIMIENTO " + txtPeriodo.Text;
                    oRec.Fecha = txtFecha.Value;
                    oRec.Importe = oApto.Cuota;
                    oRec.ImportePagado = 0;
                    oRec.Pago = false;
                    oRec.Periodo = txtPeriodo.Text;
                    oRec.Anulado = false;

                    db.Recibos.Add(oRec);

                    Aptos dbApto = new Aptos();

                    dbApto = db.Aptos.Find(oApto.AptoId);

                    if (oRec.Fecha <= DateTime.Now)
                         dbApto.Deuda += oApto.Cuota;


                    db.SaveChanges();
                }
            }

        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {
            txtPeriodo.Text = txtFecha.Value.Year.ToString() + txtFecha.Value.Month.ToString().PadLeft(2, '0');
        }
    }
}
