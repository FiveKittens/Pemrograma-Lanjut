using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan9279
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            char k, x;
            double TotalGaji;
            Karyawan karyawan = new Karyawan();

            KaryawanTetap tetap = new KaryawanTetap();
            KaryawanKontrak kontrak = new KaryawanKontrak();

            karyawan.TampilData();
            Console.WriteLine(" ");
            Console.WriteLine("Jenis Karyawan : ");
            Console.WriteLine("1. Karyawan Tetap");
            Console.WriteLine("2. Karyawan Kontrak");
            Console.Write("Pilihan : ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if(i == 1)
            {
                karyawan = tetap;

                Console.WriteLine("Jabatan Karyawan : ");
                Console.WriteLine("1. Direktur");
                Console.WriteLine("2. Manajer");
                Console.WriteLine("3. Kepala Bagian");
                Console.WriteLine("4. Staff");
                Console.Write("Pilihan : ");
                j = int.Parse(Console.ReadLine());
                if (j == 1)
                {
                    tetap.SetGapok(15000000);
                    tetap.SetBonus(5000000);
                }else if(j == 2)
                {
                    tetap.SetGapok(10000000);
                    tetap.SetBonus(3500000);
                }else if(j == 3)
                {
                    tetap.SetGapok(5500000);
                    tetap.SetBonus(2500000);
                }else if(j == 4)
                {
                    tetap.SetGapok(2500000);
                    tetap.SetBonus(1000000);
                }
                Console.WriteLine(" ");
                Console.Write("Apakah Anda Laki - Laki (y/n) : ");
                k = char.Parse(Console.ReadLine());
                if(k == 'y')
                {
                    Console.Write("Apakah Anda Sudah Menikah (y/n) : ");
                    x = char.Parse(Console.ReadLine());
                    if(x == 'y')
                    {
                        Console.WriteLine("Tunjangan Diberikan");
                        TotalGaji = tetap.GetGapok() + tetap.GetBonus()+tetap.GetTunjangan();
                        Console.WriteLine("Total Gaji\t: " + TotalGaji);
                    }
                    else
                    {

                        Console.WriteLine("Ngenes amat lu");
                        TotalGaji = tetap.GetGapok() + tetap.GetBonus();
                        Console.WriteLine("Total Gaji\t: " + TotalGaji);
                    }
                }
                else
                {
                    TotalGaji = tetap.GetGapok() + tetap.GetBonus();
                    Console.WriteLine("Total Gaji\t: " + TotalGaji);
                }
            }
            else
            {
                karyawan = kontrak;
                karyawan.TampilData();
            }
            /*karyawan = tetap;
            karyawan.TampilData();

            Console.ReadLine();

            karyawan = kontrak;
            karyawan.TampilData();
            */
            Console.ReadLine();
        }
    }
}
