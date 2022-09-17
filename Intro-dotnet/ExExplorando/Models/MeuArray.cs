using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExExplorando.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[10];

        public void AdicinarElementoArray(T elemento)
        {
            if (contador + 1 < capacidade)
            {
                array[contador] = elemento;
            }
            contador++;
        } 

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}