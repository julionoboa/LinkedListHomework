using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEstructuraDeDatos
{
    internal class Lista
    {
        private Nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        public Nodo newNodo(int item)
        {
            return new Nodo() { data = item, next = null };
        }

        public void InsertFinal(int item)
        {
            Nodo aux = newNodo(item);

            if (inicio == null)
            {
                inicio = aux;
            }
            else
            {
                Nodo pointer = inicio;
                while (pointer.next != null)
                {
                    pointer = pointer.next;
                }
                pointer.next = aux;
            }
        }

        public void InsertHead(int item)
        {
            Nodo aux = newNodo(item);

            if (inicio == null)
            {
                inicio = aux;
            }
            else
            {
                Nodo pointer = inicio;
                inicio = aux;
                aux.next = pointer;
            }
        }

        public void DeleteHead()
        {
            if (inicio == null)
            {
                Console.WriteLine("Empty list, item cannot be deleted");
            } else
            {
                inicio = inicio.next;
            }
        }

        public void DeleteFinal()
        {
            if (inicio == null)
            {
                Console.WriteLine("Empty list, item cannot be deleted"); 
            } else
            {
                Nodo previousPointer, nextPointer;
                previousPointer = inicio;
                nextPointer = inicio;

                while (nextPointer.next != null)
                {
                    previousPointer = nextPointer;
                    nextPointer = nextPointer.next;
                }
                previousPointer.next = null;
            }
        }

        public void InsertPosition(int item, int position)
        {
            Nodo aux = newNodo(item);

            if (inicio == null)
            {
                Console.WriteLine("Empty list, therefore, it will be inserted in the first position.");
                inicio = aux;
            }
            else
            {
                Nodo pointer = inicio;
                if (position == 1)
                {
                    aux.next = pointer;
                    inicio = aux;
                }
                else
                {
                    int currentPosition = 1;
                    while (currentPosition < position - 1 && pointer.next != null)
                    {
                          pointer = pointer.next;
                          currentPosition++;
                     }

                    Nodo nextPointer = pointer.next;
                    pointer.next = aux;
                    aux.next = nextPointer;

                    if (nextPointer == null)
                    {
                        Console.WriteLine($"Position {position} is greater than the number of existing nodes. Inserted at the end of the list.");
                    }
                }
            }
        }

        public void ShowList()
        {
            if (inicio == null)
            {
                Console.WriteLine("Empty list");
            } else
            {
                Nodo pointer = inicio;
                Console.Write("{0} -> \t", pointer.data);
                while (pointer.next != null)
                {
                    pointer = pointer.next;
                    Console.Write("{0} -> \t", pointer.data);
                }
            }
            Console.WriteLine();
        }

        public void InsertByOrder(int item)
        {
            Nodo aux = newNodo(item);

            if (inicio == null)
            {
                inicio = aux; //Special case: empty list
                return;
            }

            //Case: insert at the beginning if the item is less than the first node
            if (item < inicio.data)
            {
                aux.next = inicio;
                inicio = aux;
                return;
            }

            //Case: Search for the correct position to insert the item
            Nodo current = inicio;
            while (current.next != null && current.next.data < item)
            {
                current = current.next;
            }

            aux.next = current.next;
            current.next = aux;
        }
    }
}
