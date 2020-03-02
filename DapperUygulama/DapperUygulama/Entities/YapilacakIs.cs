using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperUygulama.Entities
{
    public class YapilacakIs
    {
        public int Id { get; set; }
        [DisplayName("Ad")]
        public string Tanim { get; set; }
        [DisplayName("Detay")]
        public string Aciklama { get; set; }
        [DisplayName("Tarih")]
        public DateTime OlusturulmaTarih { get; set; } = DateTime.Now;
        public bool Durum { get; set; }
        public int KullaniciId { get; set; }
    }
}
