using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c1 = new Cachorro();
            c1.nome = "Bob";
            Console.WriteLine("\n O nome do cachorro é:"+ c1.nome );
            c1.comer();

            Peixe p1 = new Peixe();
            p1.nome = "Nemo";
            Console.WriteLine("\n O nome do peixe é:"+ p1.nome );
            p1.comer();
            
        }
    }
}
