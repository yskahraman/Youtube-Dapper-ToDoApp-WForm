using System.Collections.Generic;

namespace DapperUygulama.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public List<YapilacakIs> YapilacakIsler { get; set; }
    }
}
