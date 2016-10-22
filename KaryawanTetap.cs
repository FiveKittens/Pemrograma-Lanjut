using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan9279
{
    class KaryawanTetap : Karyawan
    {
        double tunj, bonus;

        public KaryawanTetap()
        {
            tunj = 500000;
            bonus = 350000;
        }
        public void TampilData()
        {
            Console.WriteLine("Nama Karyawan\t: " + nama);
            Console.WriteLine("NIM Karyawan\t: " + nim);
            Console.WriteLine("Gaji Pokok\t: " + gapok);
            Console.WriteLine("Tunjangan\t: " + tunj);
            Console.WriteLine("Bonus\t: " + bonus);
        }
    }
}
