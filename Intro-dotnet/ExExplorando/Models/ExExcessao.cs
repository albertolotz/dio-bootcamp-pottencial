using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExExplorando.Models
{
    public class ExExcessao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            Metodo3();
        }   
        public void Metodo3()
        {
            Metodo4();
        }   
        public void Metodo4()
        {
            throw new Exception("Algum erro!");
        }       
    }

    
}