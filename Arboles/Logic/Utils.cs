using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles.Logic
{
    public static class TreeUtils
    {
        public static Nodo contruirArbol()
        {
            // Construir el árbol
            Nodo raiz = new Nodo(70);
            raiz.Izquierdo = new Nodo(20);
            raiz.Derecho = new Nodo(98);

            raiz.Izquierdo.Izquierdo = new Nodo(15);
            raiz.Izquierdo.Derecho = new Nodo(59);
            raiz.Izquierdo.Izquierdo.Izquierdo = new Nodo(10);
            raiz.Izquierdo.Izquierdo.Izquierdo.Izquierdo = new Nodo(2);

            raiz.Izquierdo.Derecho.Izquierdo = new Nodo(29);
            raiz.Izquierdo.Derecho.Derecho = new Nodo(69);

            raiz.Derecho.Izquierdo = new Nodo(77);
            raiz.Derecho.Izquierdo.Izquierdo = new Nodo(75);
            raiz.Derecho.Izquierdo.Izquierdo.Izquierdo = new Nodo(78);
            raiz.Derecho.Izquierdo.Izquierdo.Derecho = new Nodo(86);
            raiz.Derecho.Izquierdo.Derecho = new Nodo(91);

            // Mostrar estructura del árbol
            ImprimirArbol(raiz, "", true);
            return raiz;
        }
        public static string RecorridoPreorden(Nodo nodo)
        {
            if (nodo == null)
                return "";

            string resultado = $"{nodo.Valor} ";
            resultado += RecorridoPreorden(nodo.Izquierdo);
            resultado += RecorridoPreorden(nodo.Derecho);

            return resultado;
        }

        public static string RecorridoInorden(Nodo nodo)
        {
            if (nodo == null)
                return "";

            string resultado = RecorridoInorden(nodo.Izquierdo);
            resultado += $"{nodo.Valor} ";
            resultado += RecorridoInorden(nodo.Derecho);

            return resultado;
        }

        public static string RecorridoPostorden(Nodo nodo)
        {
            if (nodo == null)
                return "";

            string resultado = RecorridoPostorden(nodo.Izquierdo);
            resultado += RecorridoPostorden(nodo.Derecho);
            resultado += $"{nodo.Valor} ";

            return resultado;
        }

        static void ImprimirArbol(Nodo nodo, string prefijo, bool esIzquierdo)
        {
            if (nodo != null)
            {
                Console.WriteLine(prefijo + (esIzquierdo ? "├── " : "└── ") + nodo.Valor);

                ImprimirArbol(nodo.Izquierdo, prefijo + (esIzquierdo ? "│   " : "    "), true);
                ImprimirArbol(nodo.Derecho, prefijo + (esIzquierdo ? "│   " : "    "), false);
            }
        }
    }

}
