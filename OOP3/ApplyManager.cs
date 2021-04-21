using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplyManager //Başvuru MAnager
    {
        //public void MakeApplication() // Başvuru Yap
        //{
        //    HouseCreditManager houseCreditManager = new HouseCreditManager();
        //    houseCreditManager.Calculate();
        //    //Bu şekilde yaparsak tüm kredi başvuruları konut kredisiymiş gibi hesaplandığı için doğru bir kullanım olmaz.
        //}


        public void MakeAplication(ICreditManager creditManager)//Başvuru Yap //Yapıyı bu şekilde oluşturduğumuzda creditManager a hangi tür kredi gönderilirse ona göre hesaplama yapar. 
        {
            creditManager.Calculate(); 
        }

        public void MakeCreditPreliminaryInformation(List<ICreditManager> credits) //Kredi Ön Bilgilendirmesi Yap  //Burada kaç tane kredi türü seçilirse seçilsen hepsinin hesaplamasını yapar
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
