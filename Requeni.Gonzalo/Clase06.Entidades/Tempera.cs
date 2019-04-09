using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;

        public Tempera(ConsoleColor color,string marca,sbyte cantidad)
        {
            this._color = color;
            this._cantidad = cantidad;
            this._marca = marca;
        }

        private string Mostrar()
        {
            return "Color: " + this._color.ToString() + " - Marca: " + this._marca + " - Cantidad: " + this._cantidad.ToString();
        }

        public static string Mostrar(Tempera t)
        {
            string retorno = "";
            if (t != null)
                retorno = t.Mostrar();
            return retorno;
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            if (Object.Equals(t1, null) && Object.Equals(t2, null))
                return true;
            else if (Object.Equals(t1, null) || Object.Equals(t2, null))
                return false;
            else
                return (t1._marca == t2._marca && t1._color == t2._color);
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t,sbyte cant)
        {
            if(cant > 0)
                t._cantidad += cant;
            return t;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
                t1 += t2._cantidad;
            return t1;
        }

        public static implicit operator sbyte(Tempera t)
        {
            return t._cantidad;
        }
    }
}
