using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.pilas_colas
{
    internal class pila : Icollecction
    {
        object[] array;

        public pila()
        {
            array = new object[10];
        }
        public bool estaVacia()
        {
            if (array.Length==-1)
            {
                return true;
            }
            return false;
        }
        public int extraer()
        {
            int A =Convert.ToInt32(array[0]);
            array[0]=null;
            return A;
        }
        public int primero()
        {
            return Convert.ToInt32(array[0]);
        }
        public bool añadir(int A)
        {
            bool estado =  false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]!=null)
                {
                    array[i]  = A;
                    estado = true;
                }
                else
                {
                    estado = false;
                }
            }
            return estado;
        }        
    }
}
