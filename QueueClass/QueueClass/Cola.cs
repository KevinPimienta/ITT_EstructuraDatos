using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    public class Cola
    {
        private ArrayList pcola;
        public Cola()
        {
            pcola = new ArrayList();
        }
        public void EnQueue(object item)
        { //Añade el objeto de entrada al arraylist
            //el objeto puede ser cualquier tipo de dato.
            pcola.Add(item);
        }
        public void DeQueue()
        {
            //Elimina el valor de la posicion 0 del ArrayList
            pcola.RemoveAt(0);
        }

        public object Peek()
        {
            //Visualiza el elemento 0
            //pero en la mente de Jesus es el 1
            return pcola[0];
        }
        public void ClearQueue()
        {
            //Limpia la Cola
            pcola.Clear();
        }

        public int Count()
        {
            //Regresa la cantidad de elementos de l a cola.
            return pcola.Count;
        }
    }


}
