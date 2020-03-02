using Dapper;
using DapperUygulama.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DapperUygulama.Concrete.Dapper
{
    public class DapperYapilacakIsRepository
    {
        public void Ekle(YapilacakIs yapilacakIs)
        {
            using (DbConfig dbc= new DbConfig())
            {
                var con= dbc.BaglantiyiGetir();
                con.Open();
                con.Execute("insert into YapilacakIs values(@Tanim,@Aciklama,@OlusturulmaTarih,@Durum,@KullaniciId)", yapilacakIs);
                con.Close();
                con.Dispose();
            }
        }

        public List<YapilacakIs> BekleyenleriGetir(int kullaniciId)
        {
            using (var dbc = new DbConfig())
            {
                var con = dbc.BaglantiyiGetir();
                con.Open();
                var isler=  con.Query<YapilacakIs>("select * from YapilacakIs where KullaniciId=@pKullaniciId and Durum=0",new {pKullaniciId=kullaniciId}).ToList();
                con.Close();
                con.Dispose();
                return isler;
            }
        }

        public List<YapilacakIs> TamamlananlariGetir(int kullaniciId)
        {
            using (var dbc = new DbConfig())
            {
                var con = dbc.BaglantiyiGetir();
                con.Open();
                var isler = con.Query<YapilacakIs>("select * from YapilacakIs where KullaniciId=@pKullaniciId and Durum=1", new { pKullaniciId = kullaniciId }).ToList();
                con.Close();
                con.Dispose();
                return isler;
            }
        }

        public void Tamamla(int yapilacakIsId)
        {
            using (DbConfig dbc = new DbConfig())
            {
                var con = dbc.BaglantiyiGetir();
                con.Open();
                con.Execute("Update YapilacakIs set Durum=1 where Id=@id", new {id=yapilacakIsId });
                con.Close();
                con.Dispose();
            }
        }
    }
}
