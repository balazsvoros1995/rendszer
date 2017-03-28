using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_iter
{
    class Felhasznalok
    {
        public List<Felhasznalo> list;
        
        public Felhasznalok()
        {
            list = new List<Felhasznalo>();
            Felhasznalo pistike = new Felhasznalo("pistike", "asd123", "Kiss István", "kispista@kispista.kispista", "06901234567", "hawaii");
            Felhasznalo baluka = new Felhasznalo("baluka", "titkos", "Vörös Balázs", "voribali@gmail.com", "06701234567", "Körmend");
            list.Add(pistike);
            list.Add(baluka);
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}\n", pistike.getFelnev(), pistike.getFpw(), pistike.getFnev(), pistike.getFemail(), pistike.getFtel(), pistike.getFcim());
        }

        public int LoginUser(string username, string password)
        {
            for(int i=0; i<list.Count; i++)
            {
                if((username.Equals(list.ElementAt(i).getFelnev())) && (password.Equals(list.ElementAt(i).getFpw()))){
                    return 1;
                }
            }
            return 0;
        }





    }
}
