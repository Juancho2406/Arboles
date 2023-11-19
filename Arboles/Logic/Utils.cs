using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles.Logic
{
    public static class TreeUtils
    {
        public static Nodo contruirArbolEscenario1()
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
            raiz.Derecho.Izquierdo.Derecho = new Nodo(91);
            raiz.Derecho.Izquierdo.Derecho.Izquierdo = new Nodo(78);
            raiz.Derecho.Izquierdo.Derecho.Izquierdo.Derecho = new Nodo(86);

            // Mostrar estructura del árbol
            TreeUtils.ImprimirArbol(raiz, "", true);
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

        public static void ImprimirArbol(Nodo nodo, string prefijo, bool esIzquierdo)
        {
            StringBuilder sb = new StringBuilder();

            if (nodo != null)
            {
                Console.WriteLine(prefijo + (esIzquierdo ? "├── " : "└── ") + nodo.Valor);
                ImprimirArbol(nodo.Izquierdo, prefijo + "│  ", true);
                ImprimirArbol(nodo.Derecho, prefijo + "  ", false);
            }
        }


        public static Nodo ConstruirArbol(int[] preorden, int[] inorden)
        {
            return ConstruirArbolRecursivo(preorden, inorden, 0, inorden.Length - 1);
        }

        public static Nodo ConstruirArbolRecursivo(int[] preorden, int[] inorden, int inordenInicio, int inordenFin)
        {
            int preordenIndex = 0;
            if (inordenInicio > inordenFin)
                return null;

            Nodo nodoActual = new Nodo(preorden[preordenIndex++]);

            if (inordenInicio == inordenFin)
                return nodoActual;

            int inordenIndex = BuscarIndiceInorden(inorden, inordenInicio, inordenFin, nodoActual.Valor);

            nodoActual.Izquierdo = ConstruirArbolRecursivo(preorden, inorden, inordenInicio, inordenIndex - 1);
            nodoActual.Derecho = ConstruirArbolRecursivo(preorden, inorden, inordenIndex + 1, inordenFin);

            return nodoActual;
        }

        public static int BuscarIndiceInorden(int[] inorden, int inicio, int fin, int valor)
        {
            for (int i = inicio; i <= fin; i++)
            {
                if (inorden[i] == valor)
                    return i;
            }
            return -1;
        }

        
    }
}
