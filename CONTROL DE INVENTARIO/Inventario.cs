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

        /*public void Agregar(Productos nuevo)
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
        }*/

        public void Agregar(Productos nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
                Agregar(inicio, nuevo);
        }

        private void Agregar(Productos ultimo,Productos nuevo)
        {
            if (ultimo.siguiente == null)
                ultimo.siguiente = nuevo;
            else
                Agregar(ultimo.siguiente, nuevo);
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

        public void Insertar(Productos nuevo, int posicion)
        {
            int contador = 1;
            Productos temp = inicio;
            if (posicion == 1)
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
            }
            else
            {
                while (temp.siguiente != null && contador < posicion - 1)
                {
                    temp = temp.siguiente;
                    contador++;
                }
                nuevo.siguiente = temp.siguiente;
                temp.siguiente = nuevo;
            }
        }

        public void AgregarInicio (Productos nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
            }
        }
    }
}
//Hola