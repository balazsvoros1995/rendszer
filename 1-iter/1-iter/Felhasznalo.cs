using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_iter
{
    class Felhasznalo
    {
        public string fnev;
        public string felnev;
        public string fpw;
        public string femail;
        public string ftel;
        public string fcim;
        public Felhasznalo(string _felnev, string _fpw, string _fnev, string _femail, string _ftel, string _fcim) {
            felnev = _felnev;
            fpw = _fpw;
            fnev = _fnev;
            femail = _femail;
            ftel = _ftel;
            fcim = _fcim;
        }
        public string getFnev()
        {
            return fnev;
        }
        public string getFelnev()
        {
            return felnev;
        }
        public string getFpw()
        {
            return fpw;
        }
        public string getFemail()
        {
            return femail;
        }
        public string getFtel()
        {
            return ftel;
        }
        public string getFcim()
        {
            return fcim;
        }
        
    }
}
