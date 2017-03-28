using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_iter
{
    class Szoba
    {
        private int szobaszam;
        private string agy;
        private string kilatas;
        public Szoba(int _szam, string _agy, string _k)
        {
            szobaszam = _szam;
            agy = _agy;
            kilatas = _k;
        }
        public int getSzobaszam()
        {
            return szobaszam;
        }
        public string getAgy()
        {
            return agy;
        }
        public string getKilatas()
        {
            return kilatas;
        }

        public void szoba_kiir()
        {
            Console.WriteLine("Szobaszam:{0}\nAgy tipus:{1}\nKilatas:{2}\n", getSzobaszam(), getAgy(), getKilatas());
        }



    }
}
