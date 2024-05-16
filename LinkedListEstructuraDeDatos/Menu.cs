using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEstructuraDeDatos
{
    internal class Menu
    {
        private Lista Lista;
        private int value;
        private int position;

        public Menu(Lista lista)
        {
            Lista = new Lista();
        }

        public void ShowMenu()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Insert at the beginning");
            Console.WriteLine("2. Insert at the end");
            Console.WriteLine("3. Insert at a position");
            Console.WriteLine("4. Insert ordered");
            Console.WriteLine("5. Delete from the beginning");
            Console.WriteLine("6. Delete from the end");
            Console.WriteLine("7. Display list");
            Console.WriteLine("8. Exit");
        }
        public int GetValidInteger(string prompt)
        {
            int value;
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
                }
            }
        }
        public void ProcessOption(int option)
        {
            switch (option)
            {
                case 1:
                    value = GetValidInteger("Enter the item to insert at the beginning:");
                    Lista.InsertHead(value);
                    ShowMessage("Item has been inserted at the beginning, press any key to continue");
                    break;
                case 2:
                    value = GetValidInteger("Enter the item to insert at the end:");
                    Lista.InsertFinal(value);
                    ShowMessage("Item has been inserted at the end, press any key to continue");
                    break;
                case 3:
                    value = GetValidInteger("Enter the item to insert:");
                    position = GetValidInteger("Enter the position:");
                    Lista.InsertPosition(value, position);
                    ShowMessage("Item has been inserted at the position, press any key to continue");
                    break;
                case 4:
                    value = GetValidInteger("Enter the item to insert:");
                    Lista.InsertByOrder(value);
                    ShowMessage("Item has been inserted in order, press any key to continue");
                    break;
                case 5:
                    Console.WriteLine("Deleting from the beginning...");
                    Lista.DeleteHead();
                    ShowMessage("Item has been deleted from the beginning, press any key to continue");
                    break;
                case 6:
                    Console.WriteLine("Deleting from the end");
                    Lista.DeleteFinal();
                    ShowMessage("Item has been deleted from the end, press any key to continue");
                    break;
                case 7:
                    Lista.ShowList();
                    ShowMessage("Press any key to continue");
                    break;
                case 8:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please enter a valid one");
                    break;
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
        }

        public int GetOption()
        {
            int option;
            while (true)
            {
                Console.Write("Seleccione una opción (1-8): ");
                if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 8)
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor ingrese un número del 1 al 8.");
                }
            }
        }

        public int GetItem()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetPosition()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
