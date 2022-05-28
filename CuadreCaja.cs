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
    public partial class CuadreCaja : Form
    {
        public CuadreCaja()
        {
            InitializeComponent();
        }

        int iCuadreId = -1;

        private AdmSoftContext db = new AdmSoftContext();

        private void CuadreCaja_Load(object sender, EventArgs e)
        {

        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            iCuadreId = -1;
            LimpiarDatos();
            splitGastos.Enabled = false;
            splitIngresos.Enabled = false;
            tabControl1.SelectedIndex = 1;
        }


        void LimpiarDatos()
        {
            txtFecha.Value = DateTime.Now.Date;

            txtImporteCheque.Text = "0";
            txtImporteDeposito.Text = "0";
            txtImporteEfectivo.Text = "0";
            txtImporteGastos.Text = "0";
            txtImportePagos.Text = "0";
            txtImporteTarjeta.Text = "0";
            txtImporteTransferencia.Text = "0";
            txtComentario.Text = "";
            textCuadreId.Text = "";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            splitGastos.Enabled = true;
            splitIngresos.Enabled = true;
            BuscarCuadres();
        }


        void BuscarCuadres()
        {

            DateTime dFecha  = txtFechaFind.Value.Date;
            DateTime dFechaHasta = txtFechaHasta.Value.Date;

            if (dFecha==dFechaHasta)
            {
                var oCuadre = from p in db.Cuadre
                              where p.Fecha == dFecha
                              select new { p.CuadreId,p.Fecha, Cobros=p.ImportePagos, Gasto=p.ImporteGastos, Deposito=p.ImporteDeposito, p.Comentario };


                dg.DataSource = oCuadre.ToList();

            }
            else
            {
                var oCuadre = from p in db.Cuadre
                              where (p.Fecha >= dFecha && p.Fecha <= dFechaHasta)
                              select new { p.CuadreId, Cobros=p.ImportePagos, Gasto=p.ImporteGastos,Deposito=p.ImporteDeposito, p.Comentario };


                dg.DataSource = oCuadre.ToList();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cuadre oCuadre = new Cuadre();

            if (iCuadreId != -1)
                oCuadre = db.Cuadre.Find(iCuadreId);


            oCuadre.Fecha = txtFecha.Value.Date;
            oCuadre.Comentario = txtComentario.Text;
                oCuadre.ImporteCheque = Convert.ToDecimal(txtImporteCheque.Text);
            oCuadre.ImporteDeposito = Convert.ToDecimal(txtImporteDeposito.Text);
            oCuadre.ImporteEfectivo = Convert.ToDecimal(txtImporteEfectivo.Text);
            oCuadre.ImporteGastos = Convert.ToDecimal(txtImporteGastos.Text);
            oCuadre.ImportePagos = Convert.ToDecimal(txtImportePagos.Text);
            oCuadre.ImporteTarjeta = Convert.ToDecimal(txtImporteTarjeta.Text);
            oCuadre.ImporteTransferencia = Convert.ToDecimal(txtImporteTransferencia.Text);
            oCuadre.FechaIni = txtFechaIni.Value.Date;
            oCuadre.FechaFin = txtFechaFin.Value.Date;


            if (iCuadreId == -1)
               db.Cuadre.Add(oCuadre);
  
            db.SaveChanges();


            splitGastos.Enabled = true;
            splitIngresos.Enabled = true;

            LimpiarDatos();

            tabControl1.SelectedIndex = 0;





        }

        private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void BuscarDatos()
        {

            Cuadre oCuadre = db.Cuadre.Find(iCuadreId);

            txtFecha.Value =    oCuadre.Fecha;
            txtComentario.Text = oCuadre.Comentario;
            txtImporteCheque.Text = oCuadre.ImporteCheque.ToString();
            txtImporteDeposito.Text = oCuadre.ImporteDeposito.ToString();
            txtImporteEfectivo.Text= oCuadre.ImporteEfectivo.ToString();
            txtImporteGastos.Text = oCuadre.ImporteGastos.ToString();
            txtImportePagos.Text = oCuadre.ImportePagos.ToString();
            txtImporteTarjeta.Text = oCuadre.ImporteTarjeta.ToString();
            txtImporteTransferencia.Text = oCuadre.ImporteTransferencia.ToString();
            textCuadreId.Text = iCuadreId.ToString();
            txtFechaIni.Value = oCuadre.FechaIni.Value;
            txtFechaFin.Value = oCuadre.FechaFin.Value;

            BuscarIngresos();
            BuscarGastos();
          

        }

        void BuscarIngresos()
        {

            decimal dMontoEfectivo = 0;
            decimal dMontoCheque = 0;
            decimal dMontoTransferencia = 0;
            decimal dMontoTarjeta = 0;


            var oGastos = from p in db.MovCaja
                           where (p.Tipo == TipoMovcaja.Pago && p.CuadreId == iCuadreId)
                          select new { p.MovcajaId, p.Concepto, p.TipoPago,p.Recibo, p.Importe };

     
            foreach (var q in oGastos.ToList())
            {
                switch (q.TipoPago)
                {
                    case TipoPago.Efectivo:
                        dMontoEfectivo += q.Importe;
                        break;
                    case TipoPago.Cheque:
                        dMontoCheque += q.Importe;
                        break;
                    case TipoPago.Tarjeta:
                        dMontoTarjeta += q.Importe;
                        break;
                    case TipoPago.Transferencia:
                        dMontoTransferencia += q.Importe;
                        break;

                }
            }


            txtImporteCheque.Text = dMontoCheque.ToString();
            txtImporteTarjeta.Text = dMontoTarjeta.ToString();
            txtImporteTransferencia.Text = dMontoTransferencia.ToString();
            txtImporteEfectivo.Text = dMontoEfectivo.ToString();

            txtImportePagos.Text = (dMontoEfectivo + dMontoCheque + dMontoTarjeta + dMontoTransferencia).ToString();

            dgIngresos.DataSource = oGastos.ToList();


        }

        void BuscarGastos()
        {

            var oGastos = from p in db.MovCaja
                          where (p.Tipo == TipoMovcaja.Gasto && p.CuadreId == iCuadreId)
                          select new { p.MovcajaId, p.Concepto, p.Importe };

            decimal dMontoGasto = 0;
            foreach (var q in oGastos.ToList())
            {
                dMontoGasto += q.Importe;

            }

             txtImporteGastos.Text = dMontoGasto.ToString();
            txtImporteDeposito.Text = (Convert.ToDecimal(txtImporteEfectivo.Text) - dMontoGasto).ToString();

            dgGastos.DataSource = oGastos.ToList();

        }

        private void dg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                iCuadreId = Convert.ToInt32(dg.CurrentRow.Cells[0].Value);
                BuscarDatos();
                tabControl1.SelectedIndex = 1;

            }
            catch (Exception ex)
            {

            }
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            DateTime dFechaDesde = txtFechaIni.Value.Date;
            DateTime dFechaHasta = txtFechaFin.Value.Date;


            /*
            var oPagos = from p in db.Pagos
                         orderby(p.Recibo)
                         where (p.Recibo >= iDesde && p.Recibo <= iHasta && p.Anulado == false)
                         select new { p.PagoId, p.Tipo, p.Recibo, p.Monto, p.Nombre, p.Comentario };
            */

            var oPagos = from p in db.PagosRecibos
                          where (p.Pagos.Fecha >= dFechaDesde && p.Pagos.Fecha <= dFechaHasta && p.Pagos.Anulado == false)
                         group p by new { p.PagoId, p.Pagos.Recibo, p.Pagos.Nombre, p.Pagos.Tipo, p.Recibos.Aptos.AptoCode } into g
                         orderby (g.Key.Recibo)
                          select new { g.Key.PagoId, g.Key.Tipo, g.Key.Recibo, g.Key.Nombre, g.Key.AptoCode, Monto=g.Min(p=>p.Pagos.Monto) };




             dgIngresos.DataSource = oPagos.ToList();

              decimal dMontoEfectivo = 0;
                decimal dMontoCheque = 0;
                decimal dMontoTransferencia = 0;
                 decimal dMontoTarjeta = 0;

            if (chkActulizarIngreso.Checked && chkBorrar.Checked)
            {
                //borrar movcaja para ese id, 
                var oMov = from p in db.MovCaja
                           where (p.CuadreId == iCuadreId && p.Tipo == TipoMovcaja.Pago)
                           select new { p.MovcajaId };

                foreach(var r in oMov.ToList())
                {
                    MovCaja oMovRemove = db.MovCaja.Find(r.MovcajaId);

                    db.MovCaja.Remove(oMovRemove);
                }


            }

            foreach(var q in oPagos.ToList())
            {
             

              
                switch(q.Tipo)
                {
                    case TipoPago.Efectivo:
                        dMontoEfectivo += q.Monto;
                        break;
                    case TipoPago.Cheque:
                        dMontoCheque += q.Monto;
                        break;
                    case TipoPago.Tarjeta:
                        dMontoTarjeta += q.Monto;
                        break;
                    case TipoPago.Transferencia:
                        dMontoTransferencia += q.Monto;
                        break;
                }

                if (chkActulizarIngreso.Checked)
                {
                    MovCaja oMov = new MovCaja();
                    oMov.Fecha = txtFecha.Value.Date;
                    oMov.TipoPago = q.Tipo;
                    oMov.CuadreId = iCuadreId;
                    oMov.Concepto = "Pago: " + q.Nombre + " (" + q.AptoCode +")";
                    oMov.Importe = q.Monto;
                    oMov.Tipo = TipoMovcaja.Pago;
                    oMov.Recibo = q.Recibo;

                    db.MovCaja.Add(oMov);

                }
                

            }

            txtImporteCheque.Text = dMontoCheque.ToString();
            txtImporteTarjeta.Text = dMontoTarjeta.ToString();
            txtImporteTransferencia.Text = dMontoTransferencia.ToString();
            txtImporteEfectivo.Text = dMontoEfectivo.ToString();

            txtImportePagos.Text = (dMontoEfectivo + dMontoCheque + dMontoTarjeta + dMontoTransferencia).ToString();

            db.SaveChanges();


        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            MovCaja oMovCaja = new MovCaja();
            oMovCaja.CuadreId = iCuadreId;
            oMovCaja.Tipo = TipoMovcaja.Gasto;
            oMovCaja.Importe = 0;
            oMovCaja.Recibo = 0;
            oMovCaja.TipoPago = 0;
            oMovCaja.Fecha = txtFecha.Value.Date;

            frmIngresoGastos oGasto = new frmIngresoGastos(oMovCaja);
            oGasto.ShowDialog();

            if (oGasto.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                oMovCaja.Importe = oGasto.MovCaja.Importe;
                oMovCaja.Recibo = oGasto.MovCaja.Recibo;
                oMovCaja.TipoPago = oGasto.MovCaja.TipoPago;
                oMovCaja.Concepto = oGasto.MovCaja.Concepto;
                oMovCaja.Comentario = oGasto.MovCaja.Comentario;

                db.MovCaja.Add(oMovCaja);

                db.SaveChanges();
            }

            var oGastos = from p in db.MovCaja
                          where (p.Tipo == TipoMovcaja.Gasto && p.CuadreId == iCuadreId)
                          select new { p.MovcajaId, p.Concepto, p.Importe };

            decimal dMontoGasto = 0;
            foreach(var q in oGastos.ToList())
            {
                dMontoGasto += q.Importe;

            }
            txtImporteGastos.Text = dMontoGasto.ToString();
            txtImporteDeposito.Text = (Convert.ToDecimal(txtImporteEfectivo.Text) - dMontoGasto).ToString();


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            var oGastos = from p in db.MovCaja
                          where (p.CuadreId == iCuadreId)
                          orderby p.Recibo
                          select new { p.MovcajaId, p.Concepto, p.TipoPago, p.Recibo, p.Importe, p.Tipo };
                      

            dsReporte.CuadreDataTable oTable = new dsReporte.CuadreDataTable();

            foreach(var q in oGastos)
            {
                dsReporte.CuadreRow oRow = oTable.NewCuadreRow();

                oRow.Concepto = q.Concepto;
                oRow.Fecha = txtFecha.Value.Date;
                oRow.Importe = q.Tipo == 0 ? q.Importe : q.Importe * -1;
                oRow.Tipo = (q.Tipo==0 ? "Cobro" : "Gasto");

                switch(q.TipoPago)
                {
                    case TipoPago.Cheque:
                        oRow.TipoPago = "Cheque";
                        break;

                    case TipoPago.Efectivo:
                        oRow.TipoPago = "Efectivo";
                        break;

                    case TipoPago.Transferencia:
                        oRow.TipoPago = "Transferencia";
                        break;

                    case TipoPago.Tarjeta:
                        oRow.TipoPago = "Tarjeta";
                        break;
                }

                oRow.NoRecibo = q.Recibo.ToString();

                oTable.Rows.Add(oRow);


            }

            oTable.TableName = "Cuadre";

            string sPath = @".\Reportes\CuadreDiario.rdlc";
            //string sPath = "OpeAgencia2.Reportes.CuadreCaja.rdlc";

            frmReportViewer x = new frmReportViewer(sPath, oTable, "Cuadre de operaciones");

            x.ShowDialog();


        }

    }
}
