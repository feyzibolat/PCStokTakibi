using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCStokTakibi
{
    public class Sirket
    {
        // sirket nesnesi olustur
        private static Sirket instance = new Sirket();

        // newlemeyi engeller.
        private Sirket() { }


        public static Sirket getInstance()
        {
            return instance;
        }

        public void Hosgeldiniz()
        {
            System.Windows.Forms.MessageBox.Show("Hoşgeldiniz!");
        }
    }
}
