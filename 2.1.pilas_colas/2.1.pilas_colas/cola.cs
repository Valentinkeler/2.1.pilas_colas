using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.pilas_colas
{
    internal class cola : Icollecction
    {
        List<object> _colas;
        public bool añadir(int A)
        {
            _colas.Add(A);
            return true;
        }

        public bool estaVacia()
        {
            if (_colas.Count==-1)
            {
                return true;
            }
            return false;
        }

        public int extraer()
        {
            int A  = Convert.ToInt32(_colas.Remove(0));
            return A;
        }

        public int primero()
        {
            int A=0;
            for (int i = 0; i < 1; i++)
            {
                A =Convert.ToInt32(_colas[i]);
            }
            return  A;
        }
    }
}
