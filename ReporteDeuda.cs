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
    public partial class ReporteDeuda : Form
    {
        public ReporteDeuda()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private AdmSoftContext db = new AdmSoftContext();


        dsReporte.DeudaDataTable oTable = new dsReporte.DeudaDataTable();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        void BuscarDatos()
        {
            var qry = from p in db.Recibos
                      where (p.Pago == false && p.Anulado == false && p.Fecha < DateTime.Now)
                      select new { Apto=p.Aptos.AptoCode, p.Fecha, p.Concepto, p.Anulado, p.Comentario, p.Importe, p.ImportePagado, p.ReciboId,
                          Edificio = p.Aptos.AptoCode.Substring(2,2),
                          Bloque = p.Aptos.AptoCode.Substring(0, 1),
                          Apartamento = p.Aptos.AptoCode.Substring(5, 3)
                      };

                      /*
                        group p by p.Aptos.AptoCode into g
                                select new {Bloque = g.Key.Substring(0,1), Edificio = g.Key.Substring(2,2),  Apto = g.Key, Recibos= g.Count()};
                      */

            if (textBox1.Text != "")
            {
                qry = qry.Where(s => s.Apto.Contains(textBox1.Text)).OrderBy(s=>s.Edificio);

            }

            oTable = new dsReporte.DeudaDataTable();

            foreach(var q in qry)
            {
                dsReporte.DeudaRow oRow = oTable.NewDeudaRow();

                oRow.Apartamento = q.Apto.Substring(5, 3);
                oRow.Bloque = q.Bloque;
                oRow.Edificio = q.Edificio;
                oRow.ReciboId = q.ReciboId;
                oRow.ImportePagado = q.ImportePagado;
                oRow.Importe = q.Importe;
                oRow.Comentario = q.Comentario;
                oRow.Anulado = q.Anulado;
                oRow.Concepto = q.Concepto;
                oRow.Fecha = q.Fecha;
                oRow.Apto = q.Apto;


              oTable.Rows.Add(oRow);


            }


            dg.DataSource = oTable;




        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            oTable.TableName = "Deuda";

            string sPath = @".\Reportes\rDeuda.rdlc";
            //string sPath = "OpeAgencia2.Reportes.CuadreCaja.rdlc";

            frmReportViewer x = new frmReportViewer(sPath, oTable,"Listado de Facturas Pendientes");

            x.ShowDialog();
        }

    }
}
