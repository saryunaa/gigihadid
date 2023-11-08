using System;
using gigihadid.Classes;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Выберите зверя (1-лев;2-слон;3-тигр;4-медведь;5-волк):");
            int choice = Convert.ToInt32(Console.ReadLine());

            Animal animal = AnimalFactory.CreateAnimal(choice);
            if (animal != null)
            {
                animal.MakeSound();
            }
            else
            {
                Console.WriteLine("Некорректный выбор");
            }
            Console.WriteLine("Для выхода из приложения нажмите 'q', для продолжения - любую другую клавишу");
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.Q || key == ConsoleKey.Q)
            {
                exit = true;
            }
        }
        
    }
}