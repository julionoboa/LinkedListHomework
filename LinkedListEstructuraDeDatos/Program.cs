namespace LinkedListEstructuraDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Menu menu = new Menu(lista);

            int option;
            do
            {
                menu.ShowMenu();
                option = menu.GetOption();
                menu.ProcessOption(option);
            } while (option != 8);
        }
    }
}
