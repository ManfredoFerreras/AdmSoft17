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
    public partial class frmConsultaPagos : Form
    {
        public frmConsultaPagos()
        {
            InitializeComponent();
        }

        private AdmSoftContext db = new AdmSoftContext();

        int iAptoId = -1;



        void Limpiar()
        {
//            txtApto.Focus();
           // txtDeudaTotal.Text = "";
           //txtMontoApagar.Text = "";
            dg.DataSource = null;
        }
        void BuscarFacturas()
        {

            if (txtCodigo.Text != "")
            {

                var qFact = from p in db.PagosRecibos
                            where (p.Recibos.Aptos.AptoCode.Contains(txtCodigo.Text))
                            group p by new {p.PagoId, p.Pagos.Fecha, p.Pagos.Recibo, p.Pagos.Nombre, p.Pagos.Anulado, p.Recibos.Aptos.AptoCode} into g
                            select new { g.Key.PagoId, g.Key.Fecha, g.Key.Recibo, g.Key.Nombre, g.Key.Anulado, g.Key.AptoCode, Importe= g.Sum(p=>p.ImportePagado) };



                dg.DataSource = qFact.ToList();

            }
            else
            {

            
            if (txtDesde.Value == txtHasta.Value)
            {

                DateTime dFechaD = txtDesde.Value.Date;
                DateTime dFechaH = txtDesde.Value.Date.AddDays(1);

            var qFact = from p in db.Pagos
                        where (p.Fecha >= dFechaD && p.Fecha < dFechaH)
                        select new { p.PagoId, p.Fecha, p.Recibo,p.Nombre, p.Monto,p.Comentario,p.Anulado };




            dg.DataSource = qFact.ToList();
            }
            else
            {
                var qFact = from p in db.Pagos
                            where (p.Fecha >= txtDesde.Value && p.Fecha <= txtHasta.Value.Date)
                            select new { p.PagoId, p.Recibo, p.Nombre, p.Monto, p.Comentario, p.Anulado };


               

                dg.DataSource = qFact.ToList();

            }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuscarFacturas();
        }

        private void anularPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que quiere anular los pagos seleccionados","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                for(int i = 0 ; i < dg.Rows.Count; i++)
                {
                    int PagoId = 0;
                     if (dg.Rows[i].Selected == true)
                     {
                         PagoId = Convert.ToInt32(dg.Rows[i].Cells[0].Value);
                         AnulaPago(PagoId);
                     }
                }

                MessageBox.Show("Proceso concluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void AnulaPago(int PagoId)
        {
            var pago = db.Pagos.Find(PagoId);
            if (pago.Anulado == false)
            {

            
            var pagosRecibo = from p in db.PagosRecibos
                              where (p.PagoId == pago.PagoId)
                              select new { p.PagoRecId, p.ReciboId, p.ImportePagado};

            foreach(var oPagoRec in pagosRecibo.ToList())
            {
                var oRecibo = db.Recibos.Find(oPagoRec.ReciboId);

                if (oRecibo.ImportePagado >0 && (oRecibo.ImportePagado - oPagoRec.ImportePagado >= 0))
                     oRecibo.ImportePagado = oRecibo.ImportePagado - oPagoRec.ImportePagado;

                oRecibo.Pago = false;

                var oApto = db.Aptos.Find(oRecibo.AptoId);

                oApto.Deuda = oApto.Deuda - oPagoRec.ImportePagado;
                
            }
            pago.Anulado = true;
            
            db.SaveChanges();
            }

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PagoId = -1;
            try
            {
                PagoId = Convert.ToInt32(dg.Rows[dg.CurrentCell.RowIndex].Cells[0].Value);
                frmEditarPago x = new frmEditarPago(PagoId);
                x.ShowDialog();

            }
            catch(Exception ex)
            {

            }
        }

        private void imprimirPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PagoId = -1;
            try
            {
               
                PagoId = Convert.ToInt32(dg.Rows[dg.CurrentCell.RowIndex].Cells[0].Value);
                ImprimirPagos(PagoId);

            }
            catch (Exception ex)
            {

            }
        }

        private void ImprimirPagos(int IdPago)
        {
            /*
             *  PagoId
  Fecha
  Nombre
  Comentario
  Anulado
  Concepto
  ImportePagado
  AptoCode
            */


            var oPagosRecibos= from p in db.PagosRecibos
                          where (p.PagoId == IdPago)
                          select new { p.PagoId, p.Pagos.Fecha, p.Pagos.Nombre, p.Pagos.Comentario, p.Pagos.Anulado,
                              p.Recibos.Concepto, p.ImportePagado, p.Recibos.Aptos.AptoCode, p.Recibos.ReciboId };

            dsReporte.ReciboPagosDataTable oTable = new dsReporte.ReciboPagosDataTable();

            foreach (var q in oPagosRecibos)
            {
                dsReporte.ReciboPagosRow oRow = oTable.NewReciboPagosRow();

                oRow.PagoId = q.PagoId;
                oRow.Fecha = q.Fecha;
                oRow.Nombre = q.Nombre;
                oRow.Comentario = q.Comentario;
                oRow.Anulado = q.Anulado;
                oRow.Concepto = q.Concepto + "- Recibo No:" + q.ReciboId.ToString() ;
                oRow.ImportePagado = q.ImportePagado;
                oRow.AptoCode = q.AptoCode;
              

                oTable.Rows.Add(oRow);


            }

            oTable.TableName = "ReciboPago";

            string sPath = @".\Reportes\rReportPago.rdlc";
            //string sPath = "OpeAgencia2.Reportes.CuadreCaja.rdlc";

            frmReportViewer x = new frmReportViewer(sPath, oTable, "Registro de pagos");

            x.ShowDialog();



        }



    }
}
