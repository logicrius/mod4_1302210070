// See https://aka.ms/new-console-template for more information
using MOD4_1302210070;
using System;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        KodeBuah kdbuah = new KodeBuah();
        Console.WriteLine("Apel" + kdbuah.getKodeBuah(KodeBuah.NamaBuah.Apel));
        Console.WriteLine("Alpukat" + kdbuah.getKodeBuah(KodeBuah.NamaBuah.Alpukat));
        Console.WriteLine("Aprikot" + kdbuah.getKodeBuah(KodeBuah.NamaBuah.Aprikot));
        Console.WriteLine("Paprika" + kdbuah.getKodeBuah(KodeBuah.NamaBuah.Paprika));

        posisiKarakterGame initData = new posisiKarakterGame();
        initData.tombolAktif(posisiKarakterGame.Tombol.TombolW);
        initData.tombolAktif(posisiKarakterGame.Tombol.TombolW);
        initData.tombolAktif(posisiKarakterGame.Tombol.TombolS);
        initData.tombolAktif(posisiKarakterGame.Tombol.TombolS);
    }
}