using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan9279
{
    class KaryawanTetap : Karyawan
    {
        double tunj, bonus, total;

        public KaryawanTetap()
        {
            tunj = 500000;
            bonus = 350000;
        }
        /*public void SetTunjangan(double tunj)
        {
            this.tunj = tunj;
        }
        public double GetTunjangan()
        {
            return tunj;
        }*/   
        public void SetBonus(double bonus)
        {
            this.bonus = bonus;
        }
        public double GetBonus()
        {
            return bonus;
        }
        public void SetGapok(double gapok)
        {
            this.gapok = gapok;
        }
        public double GetGapok()
        {
            return gapok;
        }
        public double GetTunjangan()
        {
            return tunj;
        }
        public void SetTotalGaji()
        {
            total = GetGapok() + GetBonus();
        }
        public double GetTotalGaji()
        {
            return total;
        }
        public override void TampilData()
        {
            Console.WriteLine("Nama Karyawan\t: " + nama);
            Console.WriteLine("NIM Karyawan\t: " + nim);
            Console.WriteLine("Gaji Pokok\t: " + GetGapok());
            Console.WriteLine("Tunjangan\t: " + tunj);
            Console.WriteLine("Bonus\t: " + GetBonus());
            Console.WriteLine("Total Gaji\t: " + GetTotalGaji());

        }
    }
}
