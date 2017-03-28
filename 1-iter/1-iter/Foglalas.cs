using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_iter
{
    class Foglalas
    {
        private bool potagy;
        private int szemszam;
        private int szobaszam;
        private bool allat;
        private DateTime datum;
        private int ejszakak;
        private string felhasznalo;

        public  int getSzobaszam()
        {
            return szobaszam;
        }

        public DateTime getDatum()
        {
            return datum;
        }

        public bool getAllat()
        {
            return allat;
        }
        public bool getPotagy()
        {
            return potagy;
        }
        public string getFelhasznalo()
        {
            return felhasznalo;
        }

        public Foglalas(int _szobaszam, string _felhasznalo ,DateTime _datum, bool _potagy, bool _allat)
        {
            szobaszam = _szobaszam;
            felhasznalo = _felhasznalo;
            datum = _datum;
            potagy = _potagy;
            allat = _allat;
        }

        
    }
}
