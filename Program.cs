using System;

namespace inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuClosed = false;
            Console.Clear();

            while(!menuClosed){
            Console.WriteLine("OPCIONES DE COLOR");
            Console.WriteLine("1. Rojo");
            Console.WriteLine("2. Verde");
            Console.WriteLine("3. Amarillo");
            Console.WriteLine("4. Salir");
            string response =Console.ReadLine();
            int menuSelected;
            //int response = Convert.ToInt16(Console.ReadLine());
            if (int.TryParse(response, out menuSelected) && (menuSelected>0 && menuSelected<5)){
                Console.Clear();
            switch (menuSelected)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Console is now red\n");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Console is now Green\n");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Console is now Yellow\n");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Terminando el programa...");
                    menuClosed = true;
                    break;
               
            }
            }else{
                Console.Clear();
                Console.WriteLine("Opcion solo 1-4");
            }


            
            }
        }
    }
}
