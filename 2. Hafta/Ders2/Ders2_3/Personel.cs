using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2_3
{
    class Personel
    {
        public string Sicil { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // EkGosterge = 1 => +%5, 2 => +%10 , değilse +%20
        public int EkGosterge { get; set; }

        private double _maas; //field
        public double Maas // Sarmalama / Paketleme (Encapsulation)
        {
            get
            {
                if (EkGosterge == 1)
                    return _maas + _maas * 0.05;
                else if (EkGosterge == 2)
                    return _maas + _maas * 0.1;
                else
                    return _maas + _maas * 0.2;
            }
            set { _maas = value; }
        }

        public void ZamYap(double miktar)
        {
            _maas += miktar; // _maas = _maas+ miktars
        }
    }
}
