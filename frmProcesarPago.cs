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
    public partial class frmProcesarPago : Form
    {
        public frmProcesarPago()
        {
            InitializeComponent();
        }

        ICollection<Recibos> oRecibos;
        Aptos oAptos;
        decimal dMonto;
        Hashtable htPagoRec = new Hashtable();

        private AdmSoftContext db = new AdmSoftContext();


        public frmProcesarPago(decimal pdMonto,  ICollection<Recibos> poRecibos, ref Aptos poAptos, ref AdmSoftContext pdb, Hashtable phtPagoRec)
        {
            InitializeComponent();
            oRecibos = poRecibos;
            oAptos = poAptos;
            dMonto = pdMonto;
            db = pdb;
            htPagoRec = phtPagoRec;
        }


        private void frmProcesarPago_Load(object sender, EventArgs e)
        {
            txtMonto.Text = dMonto.ToString();
            txtNombre.Text = oAptos.AptoContact;
            //txtFecha.Value = oRecibos.FirstOrDefault().Fecha;
            cmbTipo.SelectedIndex = 0;
            BuscarSecuencia();

        }


        void BuscarSecuencia()
        {
            var oSec = db.Secuencia.Find(1);
            if (oSec != null)
            {
                txtRecibo.Text = (oSec.SecValue + 1).ToString();
            }
        }

        void GuardarSecuencia()
        {
            int iSecuencia = 0;

            if (int.TryParse(txtRecibo.Text, out iSecuencia) == true)
            {
                var oSec = db.Secuencia.Find(1);
                if (oSec != null)
                {
                    oSec.SecValue = Convert.ToInt32(txtRecibo.Text);
                }
                else
                {
                    oSec = new Secuencia();
                    oSec.SecCodigo = "SREC";
                    oSec.SecValue = Convert.ToInt32(txtRecibo.Text);
                    db.Secuencia.Add(oSec);
                   
                }
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pagos oPagos = new Pagos();
           

            oPagos.Anulado = false;
            oPagos.Comentario = txtComentario.Text;
            oPagos.Fecha = txtFecha.Value;
            oPagos.Nombre = txtNombre.Text;
            oPagos.Monto = dMonto;
            oPagos.Recibo = Convert.ToInt32(txtRecibo.Text);
            
            switch(cmbTipo.SelectedIndex)
            {
                case 0:
                    oPagos.Tipo = TipoPago.Efectivo;
                    break;
                case 1:
                    oPagos.Tipo = TipoPago.Cheque;
                    break;
                case 2:
                    oPagos.Tipo = TipoPago.Transferencia;
                    break;
                case 3:
                    oPagos.Tipo = TipoPago.Tarjeta;
                    break;

            }

            db.Pagos.Add(oPagos);

            foreach(var recibos in oRecibos)
            {
                PagosRecibos oPagosRec = new PagosRecibos();

                oPagosRec.PagoId = oPagos.PagoId;
                oPagosRec.ReciboId = recibos.ReciboId;
                oPagosRec.ImportePagado = Convert.ToDecimal(htPagoRec[recibos.ReciboId]);

                db.PagosRecibos.Add(oPagosRec);

            }
            
            GuardarSecuencia();

            db.SaveChanges();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            db.Dispose();

            this.Close();
        }
    }
}
