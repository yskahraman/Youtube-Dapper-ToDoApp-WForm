create database DapperUygulama;
use DapperUygulama;
create table Kullanici(
Id int identity(1,1) primary key,
KullaniciAd nvarchar(100),
Sifre nvarchar(100),
Ad nvarchar(100),
Soyad nvarchar(100)
);
create table YapilacakIs(
Id int identity(1,1) primary key,
Tanim nvarchar(100),
Aciklama ntext,
OlusturulmaTarih datetime,
Durum bit,
KullaniciId int,
foreign key(KullaniciId) references Kullanici(Id)
)

select * from Kullanici
select * from YapilacakIs

