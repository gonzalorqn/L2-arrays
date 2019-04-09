using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades
{
    public class Paleta
    {
        private Tempera[] _temperas;
        private int _cantidadMaxima;

        private Paleta(int cant)
        {
            this._cantidadMaxima = cant;
            this._temperas = new Tempera[cant];
        }

        private Paleta() :this(5)
        {

        }

        public static implicit operator Paleta(int cant)
        {
            return new Paleta(cant);
        }

        private string Mostrar()
        {
            string retorno = "";
            retorno += "Cantidad maxima: " + this._cantidadMaxima.ToString() + " - Temperas: ";
            foreach(Tempera t in this._temperas)
            {
                retorno += "\n" + Tempera.Mostrar(t);
            }
            return retorno;
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Paleta p,Tempera t)
        {
            foreach (Tempera item in p._temperas)
            {
                if (item == t)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            if(p != t)
            {
                p._temperas[p.ObtenerIndice()] = t;
            }
            else
            {
                
            }
            return p;
        }

        private int ObtenerIndice()
        {
            int retorno = -1;
            foreach (Tempera item in this._temperas)
            {
                retorno++;
                if (item == null)
                    break;
            }
            return retorno;
        }
    }
}
