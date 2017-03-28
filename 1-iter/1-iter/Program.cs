using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_iter
{
    class Program
    {
        static void Main(string[] args)
        {
            Szalloda szallo = new Szalloda();
            Felhasznalok lista = new Felhasznalok();
            
            Console.WriteLine("Isten hozta a {0}ban. \nCímünk: {1} \nElérhetőségeink:\nTel: {2}, E-mail: {3} \n", szallo.getNev(), szallo.getCim(), szallo.getTel(), szallo.getEmail());

            szallo.kezdoMenu();
            

            
        }
    }
}
