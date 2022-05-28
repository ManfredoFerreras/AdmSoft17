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
    public partial class frmIngresoGastos : Form
    {
        public frmIngresoGastos()
        {
            InitializeComponent();
        }


        public MovCaja MovCaja { set; get; }
     

        public frmIngresoGastos(MovCaja pMovCaja)
        {
            InitializeComponent();

            MovCaja = pMovCaja;
        }



        private void frmIngresoGastos_Load(object sender, EventArgs e)
        {

            txtMovCajaId.Text = MovCaja.MovcajaId.ToString();
            txtImporte.Text = MovCaja.Importe.ToString();
            txtConcepto.Text = MovCaja.Concepto;
            txtComentario.Text = MovCaja.Comentario;
            cmbTipo.SelectedIndex = Convert.ToInt32(MovCaja.TipoPago);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            MovCaja.Importe = Convert.ToDecimal(txtImporte.Text);
            MovCaja.Concepto = txtConcepto.Text;
            MovCaja.Comentario = txtComentario.Text;
        
            MovCaja.Tipo = TipoMovcaja.Gasto;

            switch (cmbTipo.SelectedIndex)
            {
                case 0:
                    MovCaja.TipoPago = TipoPago.Efectivo;
                    break;
                case 1:
                    MovCaja.TipoPago = TipoPago.Cheque;
                    break;
                case 2:
                    MovCaja.TipoPago = TipoPago.Transferencia;
                    break;
                case 3:
                    MovCaja.TipoPago = TipoPago.Tarjeta;
                    break;

            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
