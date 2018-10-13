using System;
using Carts;

namespace CartMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart keranjang = new Cart();

            keranjang.TambahProduk("Topi Putih", 2);

            keranjang.TambahProduk("Kemeja Hitam", 3);

            keranjang.TambahProduk("Sepatu Merah", 1);
            keranjang.TambahProduk("Sepatu Merah", 4);
            keranjang.TambahProduk("Sepatu Merah", 2);

            keranjang.HapusProduk("Kemeja Hitam");

            keranjang.HapusProduk("Baju Hijau");

            keranjang.TampilkanCart();

            Console.ReadLine();
        }
    }
}
