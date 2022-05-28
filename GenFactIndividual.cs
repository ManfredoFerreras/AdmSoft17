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
    public partial class GenFactIndividual : Form
    {
        public GenFactIndividual()
        {
            InitializeComponent();
        }


        private AdmSoftContext db = new AdmSoftContext();

        int iAptoId = -1;

        private void GenFactIndividual_Load(object sender, EventArgs e)
        {
            txtFecha.Value = DateTime.Now;

            txtPeriodo.Text = txtFecha.Value.Year.ToString() + txtFecha.Value.Month.ToString().PadLeft(2, '0');
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApto_Leave(object sender, EventArgs e)
        {
            var sQry = from p in db.Aptos
                       where (p.AptoCode == txtApto.Text)
                       select new { p.AptoId, p.AptoContact };


            if (sQry.ToList().Count > 0)
            {
                iAptoId = sQry.ToList().FirstOrDefault().AptoId;
                lblApartamento.Name = sQry.ToList().FirstOrDefault().AptoContact.ToString();
            }
            else
            {
                iAptoId = -1;
                lblApartamento.Name = "";
                txtApto.Text = "";

            }
                


        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if( Validar())
            {
                GuardarFactura();
                MessageBox.Show("Factura generada con exito");
                txtApto.Focus();
               // this.Close();
            }
        }

        bool Validar()
        {
            bool bRetorno = true;
            decimal dImporte = 0;

            if (iAptoId == -1)
            {
                MessageBox.Show("Debe registrar un apto válido", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                bRetorno = false;
            }
            if (!decimal.TryParse(txtImporte.Text, out dImporte))
            {
                 MessageBox.Show("El importe de recibo no es válido", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                 bRetorno = false;
            }
            if (txtComentario.Text == "")
            {
                MessageBox.Show("Debe registrar el concepto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bRetorno = false;

            }

            return bRetorno;
        }


        void GuardarFactura()
        {
            for(int i=1; i <= txtCantidad.Value  ; i++)
            { 

                Recibos oRec = new Recibos();

                oRec.AptoId = iAptoId;
                oRec.Periodo = txtPeriodo.Text;
                oRec.Pago = false;
                oRec.ImportePagado = 0;
                oRec.Importe = Convert.ToDecimal(txtImporte.Text);
                oRec.Fecha = txtFecha.Value;
                oRec.Concepto = txtConcepto.Text +" " +txtPeriodo.Text;
                oRec.Comentario = txtComentario.Text;
                oRec.Anulado = false;

                db.Recibos.Add(oRec);

                txtFecha.Value = txtFecha.Value.AddMonths(1);
                txtPeriodo.Text = txtFecha.Value.Year.ToString() + txtFecha.Value.Month.ToString().PadLeft(2, '0');
          }
            try
            {
                db.SaveChanges();
                LimpiarDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error salvando registro \n" + ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            

        }


        void LimpiarDatos()
        {
            iAptoId = -1;
            // txtImporte.Text = "0.00";
            txtFecha.Value = DateTime.Now;
            lblApartamento.Text = ""; 
            txtApto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {
            txtPeriodo.Text = txtFecha.Value.Year.ToString() + txtFecha.Value.Month.ToString().PadLeft(2, '0');
        }
        
    }
}
