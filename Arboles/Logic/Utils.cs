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
        public static void RecorridoPreorden(Nodo nodo)
        {
            if (nodo != null)
            {
                Console.Write($"{nodo.Valor} ");
                RecorridoPreorden(nodo.Izquierdo);
                RecorridoPreorden(nodo.Derecho);
            }
        }

        public static void RecorridoInorden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorridoInorden(nodo.Izquierdo);
                Console.Write($"{nodo.Valor} ");
                RecorridoInorden(nodo.Derecho);
            }
        }

        public static void RecorridoPostorden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorridoPostorden(nodo.Izquierdo);
                RecorridoPostorden(nodo.Derecho);
                Console.Write($"{nodo.Valor} ");
            }
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
