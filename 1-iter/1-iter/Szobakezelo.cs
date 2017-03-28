using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_iter
{
    class Szobakezelo
    {
        public List<Szoba> szobak;

        public Szobakezelo()
        {
            szobak = new List<Szoba>();
            using (StreamReader sr = new StreamReader("szobak.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split();
                    int szam = Convert.ToInt32(temp[0]);
                    string agy = temp[1];
                    string kilatas = temp[2];
                    Szoba sz = new Szoba(szam, agy, kilatas);
                    szobak.Add(sz);


                }
            }
        }
        public void szobak_kiir()
        {
            for(int i=0;i<szobak.Count();i++)
            {
                szobak[i].szoba_kiir();
            }
        }

       




    }
}
