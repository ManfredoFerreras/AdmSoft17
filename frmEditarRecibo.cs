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
    public partial class frmEditarRecibo : Form
    {
        public frmEditarRecibo()
        {
            InitializeComponent();
        }

        private AdmSoftContext db = new AdmSoftContext();
        int iReciboId; 

        public frmEditarRecibo(int piReciboId)
        {
            InitializeComponent();
            
            iReciboId = piReciboId;
        }

        private void frmEditarRecibo_Load(object sender, EventArgs e)
        {

            var oRecibo = db.Recibos.Find(iReciboId);


            if (oRecibo.Pago || oRecibo.Anulado)
            {
                btnAceptar.Enabled = false;

            }
            else
            {
                btnAceptar.Enabled = true;
            }
            //
            txtFecha.Value = oRecibo.Fecha;
            txtPeriodo.Text = oRecibo.Periodo;
            txtConcepto.Text = oRecibo.Concepto;
            txtImporte.Text = oRecibo.Importe.ToString();
            txtPagado.Text = oRecibo.ImportePagado.ToString();
            txtComentario.Text = oRecibo.Comentario;


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var oRecibo = db.Recibos.Find(iReciboId);

            oRecibo.Concepto = txtConcepto.Text;
            oRecibo.Comentario = txtComentario.Text;
            oRecibo.Importe = Convert.ToDecimal(txtImporte.Text);
            oRecibo.ImportePagado = Convert.ToDecimal(txtPagado.Text);

            db.SaveChanges();

            this.Close();

        }
    }
}
