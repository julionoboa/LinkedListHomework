using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEstructuraDeDatos
{
    internal class Lista
    {
        private Nodo inicio; // Starting point of the linked list

        // Constructor: Initializes an empty linked list
        public Lista()
        {
            inicio = null;
        }

        // Creates a new node with the specified data value
        public Nodo newNodo(int item)
        {
            return new Nodo() { data = item, next = null };
        }

        // Inserts a new node with data 'item' at the end of the list
        public void InsertFinal(int item)
        {
            Nodo aux = newNodo(item);

            if (inicio == null)
            {
                inicio = aux; // If list is empty, the new node becomes the start
            }
            else
            {
                Nodo pointer = inicio; // Pointer to traverse the list
                while (pointer.next != null) 
                {
                    pointer = pointer.next; // Traverse the list until the last node is reached
                }
                pointer.next = aux; // The new node is added at the end of the list
            }
        }

        // Inserts a new node with data 'item' at the beginning of the list
        public void InsertHead(int item)
        {
            Nodo aux = newNodo(item); // Create a new node with the specified data

            if (inicio == null)
            {
                inicio = aux; // If list is empty, the new node becomes the start
            }
            else
            {
                Nodo pointer = inicio; // Pointer to the first node
                inicio = aux; // The new node becomes the start
                aux.next = pointer; // The new node points to the previous first node
            }
        }

        // Deletes the first node of the list
        public void DeleteHead()
        {
            if (inicio == null) // If the list is empty, there is nothing to delete
            {
                Console.WriteLine("Empty list, item cannot be deleted"); 
            } else
            {
                inicio = inicio.next; // The second node becomes the first node
            }
        }

        // Deletes the last node of the list
        public void DeleteFinal()
        {
            if (inicio == null) // If the list is empty, there is nothing to delete
            {
                Console.WriteLine("Empty list, item cannot be deleted"); 
            } else
            {
                Nodo previousPointer, nextPointer; // Pointers to traverse the list
                previousPointer = inicio; // Pointer to the first node
                nextPointer = inicio; // Pointer to the first node

                while (nextPointer.next != null) // Traverse the list until the last node is reached
                {
                    previousPointer = nextPointer; // Move the previous pointer to the current node
                    nextPointer = nextPointer.next; // Move the next pointer to the next node
                }
                previousPointer.next = null; // The previous node points to null, removing the last node
            }
        }

        // Inserts a new node with data 'item' at the specified position
        public void InsertPosition(int item, int position)
        {
            Nodo aux = newNodo(item); // Create a new node with the specified data

            if (inicio == null) // If the list is empty, the new node becomes the start
            {
                Console.WriteLine("Empty list, therefore, it will be inserted in the first position."); 
                inicio = aux; 
            }
            else
            {
                Nodo pointer = inicio; // Pointer to traverse the list
                if (position == 1) // If the position is 1, the new node becomes the start
                {
                    aux.next = pointer; 
                    inicio = aux;
                }
                else
                {
                    int currentPosition = 1; // Current position in the list
                    while (currentPosition < position - 1 && pointer.next != null) // Traverse the list until the position is reached
                    {
                        pointer = pointer.next; // Move the pointer to the next node
                        currentPosition++; // Increment the current position
                    }

                    Nodo nextPointer = pointer.next; // Pointer to the next node
                    pointer.next = aux; // The previous node points to the new node
                    aux.next = nextPointer; // The new node points to the next node

                    if (nextPointer == null) // If the next node is null, the new node is inserted at the end of the list
                    {
                        Console.WriteLine($"Position {position} is greater than the number of existing nodes. Inserted at the end of the list.");
                    }
                }
            }
        }

        // Displays the list
        public void ShowList()
        {
            if (inicio == null)
            {
                Console.WriteLine("Empty list"); // If the list is empty, there is nothing to display
            } else
            {
                Nodo pointer = inicio; // Pointer to traverse the list
                Console.Write("{0} -> \t", pointer.data); // Display the first node
                while (pointer.next != null) // Traverse the list until the last node is reached
                {
                    pointer = pointer.next; // Move the pointer to the next node
                    Console.Write("{0} -> \t", pointer.data); // Display the current node
                }
            }
            Console.WriteLine(); // Move to the next line
        }

        // Inserts a new node with data 'item' in ascending order
        public void InsertByOrder(int item)
        {
            Nodo aux = newNodo(item); // Create a new node with the specified data

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
            while (current.next != null && current.next.data < item) // Traverse the list until the correct position is found
            {
                current = current.next; // Move the pointer to the next node
            }
            
            aux.next = current.next; // The new node points to the next node
            current.next = aux; // The current node points to the new node
        }
    }
}
