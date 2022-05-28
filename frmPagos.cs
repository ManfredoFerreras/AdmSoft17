using System;
using System.Collections;
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
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private AdmSoftContext db = new AdmSoftContext();

        int iAptoId = -1;

        private void txtId_Leave(object sender, EventArgs e)
        {
            BuscarDatos();
        }


        void BuscarDatos()
        {


            try
            {


                iAptoId = -1;

                var sQry = from p in db.Aptos
                           where (p.AptoCode == txtApto.Text)
                           select new { p.AptoId, p.AptoContact };


                if (sQry.ToList().Count == 0)
                {
                    MessageBox.Show("No existen registro para procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiar();
                    return;
                }

                iAptoId = sQry.ToList().FirstOrDefault().AptoId;
                lblApartamento.Text = sQry.ToList().FirstOrDefault().AptoContact.ToString();

                BuscarFacturas();


                decimal dImporteTotal = 0;

                for (int i = 0; i < dg.Rows.Count; i++)
                {

                    dImporteTotal += Convert.ToDecimal(dg.Rows[i].Cells[4].Value);
                }

                txtDeudaTotal.Text = dImporteTotal.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        void Limpiar()
        {
            txtApto.Focus();
            txtDeudaTotal.Text = "";
            txtMontoApagar.Text = "";
            dg.DataSource = null;
        }
        void BuscarFacturas()
        {
            if (chkFacturasSinVencer.Checked==true)
            {
                var qFact = from p in db.Recibos
                            where (p.AptoId == iAptoId && p.Pago == false && p.Anulado == false)
                            orderby p.Fecha ascending
                            select new { p.ReciboId, p.Fecha, p.Periodo, p.Importe, Balance = p.Importe - p.ImportePagado, p.Concepto };


                dg.DataSource = qFact.ToList();
            }
            else
            {
                var qFact = from p in db.Recibos
                            where (p.AptoId == iAptoId && p.Pago == false && p.Anulado == false && p.Fecha < DateTime.Now)
                            orderby p.Fecha ascending
                            select new { p.ReciboId, p.Fecha, p.Periodo, p.Importe, Balance = p.Importe - p.ImportePagado, p.Concepto };


                dg.DataSource = qFact.ToList();
            }

            
        }

        private void txtApto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            decimal dSeleccionado = 0;
            decimal dImporteTotal = 0;
            
            for(int i = 0; i < dg.Rows.Count; i++)
            {
                if (dg.Rows[i].Selected == true)
                {
                    dSeleccionado += Convert.ToDecimal(dg.Rows[i].Cells[4].Value);
                }
        
            }

      
            txtMontoApagar.Text = dSeleccionado.ToString();

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                if (MessageBox.Show("Está seguro que desea aplicar un monto de " + txtMontoApagar.Text + " ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ProcesarPago();
                   
                }
            }
            
        }

        bool Validaciones()
        {
            decimal dMonto;
            decimal dMontoTotal;
            bool bRetorno = true;

            if (decimal.TryParse(txtMontoApagar.Text,out dMonto) == false)
            {
                MessageBox.Show("Error en el monto a pagar", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bRetorno = false;

            }
            if (decimal.TryParse(this.txtDeudaTotal.Text, out dMontoTotal) == false)
            {
                MessageBox.Show("Error en el monto total de la deuda", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bRetorno = false;
            }
            if (bRetorno)
            {
                if (dMonto > dMontoTotal)
                {
                    MessageBox.Show("Error en el monto a pagar no puede ser mayor que la deuda total", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bRetorno = false;
                }
            }


            return bRetorno;
        }


        void ProcesarPago()
        {

            decimal dMontoAPagar = Convert.ToDecimal(txtMontoApagar.Text);
            bool bCobrado = false;
            List<Recibos> l_oRecibos = new List<Recibos>();
            Aptos oCliente = new Aptos();
            Hashtable htPagosRecibos = new Hashtable();
           

            for(int i = 0; i<dg.RowCount; i++)
            {
                if (dMontoAPagar ==0)
                    break;


                if (dg.Rows[i].Selected) 
                {
                    bCobrado = true;

                    int iReciboId = Convert.ToInt32(dg.Rows[i].Cells[0].Value);

                    var oRecibo = db.Recibos.Find(iReciboId);
                    oCliente = db.Aptos.Find(oRecibo.AptoId);

                    decimal deuda = (oRecibo.Importe - oRecibo.ImportePagado);

                    if (deuda > dMontoAPagar)
                    {
                        oRecibo.ImportePagado += dMontoAPagar;
                        oCliente.Deuda = oCliente.Deuda - dMontoAPagar;
                       
                        htPagosRecibos.Add(oRecibo.ReciboId, dMontoAPagar);
                        dMontoAPagar = 0;
                         
                    }
                    else if (deuda == dMontoAPagar){
                        oRecibo.ImportePagado += dMontoAPagar;
                        oCliente.Deuda = oCliente.Deuda - dMontoAPagar;
                        htPagosRecibos.Add(oRecibo.ReciboId, dMontoAPagar);
                        dMontoAPagar =0;
                    }
                        
                    else
                    {
                        oRecibo.ImportePagado = oRecibo.Importe;
                        oCliente.Deuda = oCliente.Deuda - oRecibo.ImportePagado;
                        htPagosRecibos.Add(oRecibo.ReciboId, oRecibo.ImportePagado);
                        dMontoAPagar = dMontoAPagar - oRecibo.Importe;

                    }
                    if (oRecibo.ImportePagado == oRecibo.Importe)
                    {
                        oRecibo.Pago = true;
                    }
                    l_oRecibos.Add(oRecibo);

                }
            }
            if (bCobrado == true)
            {
                frmProcesarPago x = new frmProcesarPago(Convert.ToDecimal(txtMontoApagar.Text), l_oRecibos, ref oCliente, ref db, htPagosRecibos);
                x.ShowDialog();
                if (x.DialogResult != System.Windows.Forms.DialogResult.Cancel)
                {
                    db = new AdmSoftContext();
                    BuscarFacturas();
                }
                   

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


    }
}
