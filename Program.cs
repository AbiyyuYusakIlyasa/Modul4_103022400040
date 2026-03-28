// See https://aka.ms/new-console-template for more information

using Modul4_103022400040;
using System;

class Program
{ 
    static void Main(string[] args)
    {
        KodePaket kp = new KodePaket();

        Console.WriteLine("Kode paket Basic: " + kp.GetKodePaket("Basic"));
        Console.WriteLine("Kode paket Premium: " + kp.GetKodePaket("Premium"));
        Console.WriteLine("Kode paket Student: " + kp.GetKodePaket("Student"));
        Console.WriteLine();

    }
}