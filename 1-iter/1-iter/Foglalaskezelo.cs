using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _1_iter
{
    class Foglalaskezelo
    {
        public List<Foglalas> foglalasok;

        public Foglalaskezelo()
        {
            foglalasok = new List<Foglalas>();
            using (StreamReader sr = new StreamReader("foglalas.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split();
                    int szobaszam = Convert.ToInt32(temp[0]);
                    string felhasznalo = temp[1];
                    DateTime k_datum = Convert.ToDateTime(temp[2]);
                    bool potagy = Convert.ToBoolean(temp[3]);
                    bool allat = Convert.ToBoolean(temp[4]);
                    Foglalas f = new Foglalas(szobaszam, felhasznalo, k_datum, potagy, allat);
                    foglalasok.Add(f);


                }
            }
        }

        public void lefoglal(int szobaszam,string felhasznalo, DateTime k_datum, bool potagy, bool allat)
        {

            Foglalas f = new Foglalas(szobaszam, felhasznalo, k_datum, potagy, allat);
            foglalasok.Add(f);



            using (StreamWriter sw = new StreamWriter("foglalas.txt"))
            {
                for (int i = 0; i < foglalasok.Count(); i++)
                {
                    string szobaszam1 = Convert.ToString(foglalasok[i].getSzobaszam());
                    string felhasznalo1 = foglalasok[i].getFelhasznalo();
                    string k_datum1 = Convert.ToString(foglalasok[i].getDatum().Year + "." + foglalasok[i].getDatum().Month + "." + foglalasok[i].getDatum().Day + ".");
                    string potagy1 = Convert.ToString(foglalasok[i].getPotagy());
                    string allat1 = Convert.ToString(foglalasok[i].getAllat());
                    string[] foglalas = new string[] { $"{szobaszam1} {felhasznalo1} {k_datum1} {potagy1} {allat1}" };


                    foreach (string s in foglalas)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
               

            }



        }
    }

