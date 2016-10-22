using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan9279
{
    class Karyawan
    {
        protected string nama, nim;
        protected double gapok;

        /*public void SetNama(string nama)
        {
            this.nama = nama;
        }
        public string GetNama()
        {
            return nama;
        }
        public void SetNim(string nim)
        {
            this.nim = nim;
        }
        public string GetNim()
        {
            return nim;
        }
        public void SetGapok(double gapok)
        {
            this.gapok = gapok;
        }
        public double GetGapok()
        {
            return gapok;
        }*/
        public Karyawan()
        {
            nama = "Stevi Ema Wijayanti";
            nim = "15118669";
            gapok = 1000000;
        }
        public void TampilData()
        {
            Console.WriteLine("Nama Karyawan\t: " + nama);
            Console.WriteLine("NIM Karyawan\t: " + nim);
            Console.WriteLine("Gaji Pokok\t: " + gapok);
        }
    }
}
