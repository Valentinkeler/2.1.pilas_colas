using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.pilas_colas
{
    interface Icollecction
    {
       bool estaVacia();
       int extraer();
       int primero();
       bool añadir(int A);

    }
}
