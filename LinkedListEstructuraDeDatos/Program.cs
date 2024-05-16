namespace LinkedListEstructuraDeDatos
{
    class Program
    {
        // Main method
        static void Main(string[] args)
        {
            Lista lista = new Lista(); // Create a new linked list
            Menu menu = new Menu(lista); // Create a new menu

            int option; // Variable to store the selected option
            do // Display the menu until the user selects the exit option
            {
                menu.ShowMenu(); // Display the menu
                option = menu.GetOption(); // Get the selected option
                menu.ProcessOption(option); // Process the selected option
            } while (option != 8); // Exit when the user selects the exit option
        }
    }
}
