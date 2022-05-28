using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmSoft.DAL
{
    //DropCreateDatabaseAlways<AdmSoftContext>
     //DropCreateDatabaseIfModelChanges<AdmSoftContext>
    public class DBInitializer : DropCreateDatabaseAlways<AdmSoftContext>
    {
        protected override void Seed(AdmSoftContext context)
        {

            int[] dAptos = new int[] { 101, 102, 201, 202, 301, 302, 401, 402 };


            for (int i = 1; i <= 48; i++)
            {
                for (int j = 1; j <= 8; j++)
                {

                    string sCode = "K-" + i.ToString().PadLeft(2, '0') + "-" + dAptos[j-1].ToString();

                    var Apto = from p in context.Aptos
                               where (p.AptoCode == sCode)
                               select new { p.AptoId };

                    if (Apto.ToList().Count == 0)
                    {
                        Models.Aptos oApto = new Models.Aptos();

                        oApto.AptoCode = sCode;
                        oApto.AptoContact = "";
                        oApto.AptoDoc = "";
                        oApto.AptoEmail = "";
                        oApto.Activo = true;
                        oApto.AptoPhone = "";
                        oApto.Comment = "";
                        oApto.Cuota = 600;
                        oApto.Deuda = 0;
                        oApto.isRented = false;

                        context.Aptos.Add(oApto);
                        context.SaveChanges();

                    }

                }
            }
        }
    }
}
    
