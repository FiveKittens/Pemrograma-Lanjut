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
            Karyawan karyawan = new Karyawan();

            KaryawanTetap tetap = new KaryawanTetap();
            KaryawanKontrak kontrak = new KaryawanKontrak();

            karyawan = tetap;
            karyawan.TampilData();

            Console.ReadLine();

            karyawan = kontrak;
            karyawan.TampilData();

            Console.ReadLine();
        }
    }
}
