using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEstructuraDeDatos
{
    internal class Menu
    {
        private Lista Lista; // Linked list object
        private int value; // Value to insert
        private int position; // Position to insert

        // Constructor: Initializes the menu with the specified linked list
        public Menu(Lista lista)
        {
            Lista = new Lista();
        }

        // Display the menu options
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

        // Get a valid integer value from the user
        public int GetValidInteger(string prompt)
        {
            int value; // Variable to store the integer value
            while (true) // Repeat until a valid integer is entered
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out value)) // Try to parse the input as an integer
                {
                    return value; // Return the integer value
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter an integer."); // Display an error message
                }
            }
        }

        // Process the selected option
        public void ProcessOption(int option)
        {
            switch (option)
            { 
                case 1: // Insert at the beginning
                    value = GetValidInteger("Enter the item to insert at the beginning:"); // Get the value to insert
                    Lista.InsertHead(value); // Insert the value at the beginning of the list
                    ShowMessage("Item has been inserted at the beginning, press any key to continue"); 
                    break;
                case 2: // Insert at the end
                    value = GetValidInteger("Enter the item to insert at the end:"); // Get the value to insert
                    Lista.InsertFinal(value); // Insert the value at the end of the list
                    ShowMessage("Item has been inserted at the end, press any key to continue"); 
                    break;
                case 3: // Insert at a position
                    value = GetValidInteger("Enter the item to insert:"); // Get the value to insert
                    position = GetValidInteger("Enter the position:"); // Get the position to insert
                    Lista.InsertPosition(value, position); // Insert the value at the specified position
                    ShowMessage("Item has been inserted at the position, press any key to continue"); 
                    break; 
                case 4: // Insert ordered
                    value = GetValidInteger("Enter the item to insert:"); // Get the value to insert
                    Lista.InsertByOrder(value); // Insert the value in ascending order
                    ShowMessage("Item has been inserted in order, press any key to continue"); 
                    break;
                case 5: // Delete from the beginning
                    Console.WriteLine("Deleting from the beginning..."); 
                    Lista.DeleteHead(); // Delete the first node
                    ShowMessage("Item has been deleted from the beginning, press any key to continue"); 
                    break;
                case 6: // Delete from the end
                    Console.WriteLine("Deleting from the end"); 
                    Lista.DeleteFinal(); // Delete the last node
                    ShowMessage("Item has been deleted from the end, press any key to continue"); 
                    break;
                case 7: // Display list
                    Lista.ShowList(); // Display the list
                    ShowMessage("Press any key to continue"); 
                    break;
                case 8: // Exit
                    Console.WriteLine("Exiting..."); 
                    break;
                default: // Invalid option
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
                Console.Write("Select an option (1-8): ");
                if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 8)
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select an option (1-8):");
                }
            }
        }
    }
}
