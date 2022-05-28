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


    public partial class frmAgregarApto : Form
    {
        public int Id;

        public frmAgregarApto()
        {
            InitializeComponent();
        }

        public frmAgregarApto(int pId)
        {
            InitializeComponent();
            Id = pId;
        }

        private AdmSoftContext db = new AdmSoftContext();

        private void frmAgregarApto_Load(object sender, EventArgs e)
        {
            
            if (Id != -1)
            {
               // txtCode.Enabled = false;
                FindData();
            }

        }


        void FindData()
        {
            Aptos oAptos = db.Aptos.Find(Id);

            if (oAptos == null)
            {
                MessageBox.Show("No exite el apartamento buscado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txtCode.Text = oAptos.AptoCode;
            textName.Text = oAptos.AptoContact;
            txtEmail.Text = oAptos.AptoEmail;
            txtPhone.Text = oAptos.AptoPhone;
            chkrented.Checked = oAptos.isRented;
            txtDoc.Text = oAptos.AptoDoc;
            txtComments.Text = oAptos.Comment;
            txtCuota.Text = oAptos.Cuota.ToString();
            txtDeuda.Text = oAptos.Deuda.ToString();
            chkActivo.Checked = oAptos.Activo;
      
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Id == -1)
            {
                Aptos oAptos = new Aptos();
                oAptos.AptoCode = txtCode.Text;
                oAptos.AptoDoc = txtDoc.Text;
                oAptos.AptoContact = textName.Text;
                oAptos.AptoEmail = txtEmail.Text;
                oAptos.AptoPhone = txtPhone.Text;
                oAptos.isRented = chkrented.Checked;
                oAptos.Comment = txtComments.Text;
                oAptos.Cuota = Convert.ToDecimal(txtCuota.Text);
                oAptos.Activo = chkActivo.Checked;

                try
                {
                    db.Aptos.Add(oAptos);
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                
                }

        
            }
            else
            {
                Aptos oAptos = db.Aptos.Find(Id);
                oAptos.AptoCode = txtCode.Text;
                oAptos.AptoContact = textName.Text;
                oAptos.AptoEmail = txtEmail.Text;
                oAptos.AptoDoc = txtDoc.Text;
                oAptos.AptoPhone = txtPhone.Text;
                oAptos.isRented = chkrented.Checked;
                oAptos.Comment = txtComments.Text;
                oAptos.Cuota = Convert.ToDecimal(txtCuota.Text);
                oAptos.Activo = chkActivo.Checked;
                oAptos.Deuda = Convert.ToDecimal(txtDeuda.Text);
                try
                {
                    //db.Entry(oAptos).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
           
                }
                


            }

            this.Close();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarDeuda_Click(object sender, EventArgs e)
        {
            BuscarFacturas();
        }


        void BuscarFacturas()
        {
            decimal dDeuda = 0;

            var qFact = from p in db.Recibos
                        where (p.AptoId == Id && p.Pago == false && p.Anulado == false && p.Fecha <= DateTime.Now)
                        select new { p.ReciboId, p.Fecha, p.Periodo, p.Importe, Balance = p.Importe - p.ImportePagado, p.Concepto };

            try
            {
                 dDeuda = qFact.Sum(q => q.Balance);

            }
            catch(Exception ex)
            {
                dDeuda = 0;
            }
            

            txtDeuda.Text = dDeuda.ToString();

        }
    }
}
