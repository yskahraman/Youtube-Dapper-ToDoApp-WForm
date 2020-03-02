using DapperUygulama.Entities;
using Dapper;
namespace DapperUygulama.Concrete.Dapper
{
    public class DapperKullaniciRepository
    {
     
        public DapperKullaniciRepository()
        {
          
        }

        public void Kaydet(Kullanici kullanici)
        {

            using (DbConfig dbc= new DbConfig())
            {
                var con = dbc.BaglantiyiGetir();
                con.Open();
                con.Execute("insert into Kullanici values(@kullaniciAd,@sifre,@ad,@soyad)", kullanici);
                con.Close();
                con.Dispose();
            }
        }

        public Kullanici KullaniciGirisKontrol(string kullaniciAd, string sifre)
        {
            using (DbConfig dbc = new DbConfig())
            {
                var con = dbc.BaglantiyiGetir();
                con.Open();
                var kullaniciId= con.ExecuteScalar<int>("select Id from Kullanici where KullaniciAd=@pKullaniciAd and Sifre=@pSifre",new { pKullaniciAd=kullaniciAd,pSifre=sifre});

                Kullanici gelenKullanici = null;
                if (kullaniciId != 0)
                {
                    gelenKullanici = new Kullanici();
                    gelenKullanici= con.QuerySingle<Kullanici>("select * from Kullanici where Id=@id", new
                    {
                        id = kullaniciId
                    });
                }

                con.Close();
                con.Dispose();

                return gelenKullanici;
            }
        }
       
    }
}
