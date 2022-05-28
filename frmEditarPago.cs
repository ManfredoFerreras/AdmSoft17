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
    public partial class frmEditarPago : Form
    {
        public frmEditarPago()
        {
            InitializeComponent();
        }

        int iPagoId = -1;

        public frmEditarPago(int piPagoId)
        {
            InitializeComponent();
            iPagoId = piPagoId;
        }
        private AdmSoftContext db = new AdmSoftContext();

        private void frmEditarPago_Load(object sender, EventArgs e)
        {

            var oPagos = db.Pagos.Find(iPagoId);

            txtFecha.Value = oPagos.Fecha;
            cmbTipo.SelectedIndex = Convert.ToInt32(oPagos.Tipo);
            txtNombre.Text = oPagos.Nombre;
            txtRecibo.Text = oPagos.Recibo.ToString();
            txtComentario.Text = oPagos.Comentario;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            var oPagos = db.Pagos.Find(iPagoId);

            oPagos.Fecha =  txtFecha.Value ;
            oPagos.Nombre = txtNombre.Text;
            oPagos.Recibo = Convert.ToInt32(txtRecibo.Text);
            oPagos.Comentario = txtComentario.Text;
            switch (cmbTipo.SelectedIndex)
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

            db.SaveChanges();

            this.Close();

        }
    }
}
