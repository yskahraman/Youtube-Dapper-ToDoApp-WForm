using DapperUygulama.Concrete.Dapper;
using System;

namespace DapperUygulama.Functions
{
    public static class Islemler
    {

        public static bool BosKontrol(string deger)
        {
            return !string.IsNullOrWhiteSpace(deger);
        }

    }
}
