using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark
{
    class Otopark
    {
        //const sabit bir değeri atarken kullanılır Pi=3,14 gibi
        public const int Otomobil = 5;
        public const int DigerAraç = 10;
        public string OtoparkAdı { get; set; }
        public int ToplamYerSayısı { get; set; }
        public int BosYerSayısı { get; set; }
        public int OtoparktakiAraçSayısı { get; set; }
        public int Bakiye { get; set; }
        //yapılandırıcı metot 
        public Otopark(string otoparkAdı, int kapasite)
        {
            OtoparkAdı = otoparkAdı;
            ToplamYerSayısı = kapasite;
            BosYerSayısı = kapasite;
            Bakiye = 0;
            OtoparktakiAraçSayısı = 0;
        }
        public void OtoparkGiriş(bool otomobilMi)
        {
            BosYerSayısı--;
            OtoparktakiAraçSayısı++;
            if (otomobilMi)
            { Bakiye += Otomobil; }
            else
            { Bakiye +=DigerAraç; }

        }
        public void OtoparkÇıkış()
        {
            if (BosYerSayısı!=ToplamYerSayısı)
            {
                BosYerSayısı++;
            } 
            OtoparktakiAraçSayısı--;
        }
        public int BakiyeOgren()
        {
            return Bakiye;
        }
        public int KapasiteOgren()
        {
            return BosYerSayısı;

        }
    }
}
