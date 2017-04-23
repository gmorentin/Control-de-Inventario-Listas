using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL_DE_INVENTARIO
{
    class Inventario
    {
        private Productos inicio;

        /*private int _contador;
        public int contador { get { return _contador; } }

        public Inventario()
        {
            _contador = 0;
        }*/

        public void Agregar(Productos nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                Productos temp = inicio;
                while (temp.siguiente != null)
                    temp = temp.siguiente;
                temp.siguiente = nuevo;
            }
            }          

        public Productos Buscar(int codigo)
        {
            Productos produ = null;
            Productos temp = inicio;
            while (temp.siguiente != null)
            {
                if (temp.siguiente.codigo == codigo)
                {
                    produ = temp.siguiente;
                }
                temp = temp.siguiente;
            }
            return produ;
        }

        public void Borrar(int codigo)
        {
            Productos temp = inicio;
            while (temp.siguiente != null)
            {
                if (temp.siguiente.codigo == codigo)
                {
                    temp.siguiente = temp.siguiente.siguiente;
                    break;
                }
                temp = temp.siguiente;
            }
        }

        public string Reporte()
        {
            string datos = "";
        Productos t = inicio;
            while (t != null)
            {
                datos += t.ToString();
                t = t.siguiente;
            }
            return datos;
        }

        /*public void Insertar(Productos p, int posicion)
        {
                if (Buscar(p.codigo) == null)
                {
                    Productos aux;
                    aux = prod[_contador - 1];
                    for (int i = _contador - 1; i > posicion; i--)
                        prod[i] = prod[i - 1];
                    prod[_contador] = aux;
                    prod[posicion] = p;
                    _contador++;
                }
        }*/
    }
}
