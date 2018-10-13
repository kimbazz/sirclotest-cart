using System;
using System.Collections.Generic;
using Carts.Model;
using System.Linq;

namespace Carts
{
    public class Cart
    {
        private List<Produk> lProduk = new List<Produk>();

        public void TambahProduk(string kodeProduk, int kuantitas)
        {
            Produk o = lProduk.Where(x => x.KodeProduk == kodeProduk).FirstOrDefault();

            if (o == null)            
                lProduk.Add(new Produk
                {
                    KodeProduk = kodeProduk,
                    Kuantitas = kuantitas
                });            
            else
                o.Kuantitas += kuantitas;            
        }

        public void HapusProduk(string kodeProduk)
        {
            Produk o = lProduk.Where(x => x.KodeProduk == kodeProduk).FirstOrDefault();

            if (o != null)
                lProduk.Remove(o);
        }

        public void TampilkanCart()
        {
            foreach(Produk x in lProduk)            
                Console.WriteLine(x.KodeProduk + "\t \t" + '(' + x.Kuantitas + ')');            
        }
    }
}
