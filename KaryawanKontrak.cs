using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan9279
{
    class KaryawanKontrak : Karyawan
    {
        double bonus;
        public KaryawanKontrak()
        {
            bonus = 250000;
        }
        public override void TampilData()
        {
            Console.WriteLine("Nama Karyawan\t: " + nama);
            Console.WriteLine("NIM Karyawan\t: " + nim);
            Console.WriteLine("Gaji Pokok\t: " + gapok);
            Console.WriteLine("Bonus\t: " + bonus);
        }
    }
}
