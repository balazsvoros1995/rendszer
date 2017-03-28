using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_iter
{
    class Szalloda
    {
        public string nev = "Pan(n)o(n)ráma Hotel";
        public string cim = "Veszprém";
        public string email = "pannonrama@gmail.com";
        public string tel = "06-88-123-456";
        Felhasznalok tarolo = new Felhasznalok();
        Szobakezelo szobakez = new Szobakezelo();
        Foglalaskezelo foglalaskez = new Foglalaskezelo();
        public Szalloda()
        {
            
            
            
        }
        public string getNev()
        {
            return nev;
        }
        public string getCim()
        {
            return cim;
        }
        public string getEmail()
        {
            return email;
        }
        public string getTel()
        {
            return tel;
        }

        public int valasz()
        {
            int valasz = Convert.ToInt32(Console.ReadLine());
            return valasz;
        }

        public void szabad_szobak(DateTime date)
        {
            int i = 0;
            int j;
            do
            {
                lep = 0;
                j = 0;
                do {
                    if (szobakez.szobak[i].getSzobaszam() == foglalaskez.foglalasok[j].getSzobaszam())
                    {
                        if (date == foglalaskez.foglalasok[j].getDatum())
                        {

                        }
                        

                    }else
                        {
                            szobakez.szobak[i].szoba_kiir();
                        
                        }
                    j++;
                } while (j<foglalaskez.foglalasok.Count() || lep!=1);
                i++;
            } while (i<szobakez.szobak.Count());
        }

        public void kezdoMenu()
        {
            int response;
            do
            {
                Console.WriteLine("Válasszon menüpontot az alábbiak közül:\n1. Bejelentkezés vendégként\n2. Szabad szobák listázása\n3. Kilépés\n");

                response = valasz();
                switch (response)
                {
                    case 1:
                        Console.WriteLine("Felhasznalonev: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Jelszo: ");
                        string password = Console.ReadLine();
                        if (tarolo.LoginUser(username, password)==1) {
                            Console.WriteLine("hello {0}", username);
                            do
                            {
                                Console.WriteLine("Valasszon menüpontot az alábbiak közül:\n1. Szabad szobák listázása\n2. Szoba foglalása\n3. Vissza lépés");
                                response = valasz();
                                switch (response)
                                {
                                    case 1:
                                        Console.WriteLine("ezek a szabad szobak: az összes");
                                        break;
                                    case 2:
                                        Console.WriteLine("Adjon meg egy dátumomot (y.m.d.):");
                                        
                                        DateTime datum=Convert.ToDateTime(Console.ReadLine());
                                        
           
                                        
                                        szabad_szobak(datum);
                                        Console.WriteLine("Adja meg a szobaszamot:");
                                        int szam = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Potagy(y/n):");
                                        string pot = Console.ReadLine();
                                        bool pota;
                                        if (pot == "y")
                                        {
                                            pota = true;
                                        }
                                        else
                                        {
                                            pota = false; 
                                        }
                                        Console.WriteLine("Allat(y/n):");
                                        string allat = Console.ReadLine();
                                        bool allat1;
                                        if (allat == "y")
                                        {
                                            allat1 = true;
                                        }
                                        else
                                        {
                                            allat1 = false;
                                        }
                                        

                                        foglalaskez.lefoglal(szam, username, datum, pota, allat1);

                                        break;
                                    case 3:
                                        break;
                                    default:
                                        Console.WriteLine("nincs ilyen opcio");
                                        break;
                                }
                            } while (response != 3);



                        }
                        else
                        {
                            Console.WriteLine("nincs ilyen felhasznalo");
                        }
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:
                        Console.WriteLine("Nincs ilyen opcio.");
                        break;
                }
            } while (response != 3);
        }
    }
}
