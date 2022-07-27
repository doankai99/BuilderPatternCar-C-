using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar
{
    class MenuProgram
    {
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetUserChoice();
                DoTask(choice);
                running = IsContinue();
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("Choose Car From List");
            Console.WriteLine("1. Choice MazDaCar");
            Console.WriteLine("2. Choice Toyota");
        }
        private int GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        private bool IsContinue()
        {
            Console.Write("Do you want to continue? (y/n): ");
            string choice = Console.ReadLine();
            return choice == "y";
        }

        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: ChoiceMarda(); break;
                case 2: ChoiceToyota(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }

        public void ChoiceMarda()
        {
            Console.WriteLine("Enter infomation for Marda");
            ShopCar shopcar = new ShopCar(new MardaCar());
            shopcar.CreateCar();
            Car car = shopcar.GetCar();
            car.ShowInfo();
        }

        public void ChoiceToyota()
        {
            Console.WriteLine("Enter infomation for Toyota");
            ShopCar shopcar = new ShopCar(new ToyotaCar());
            shopcar.CreateCar();
            Car car = shopcar.GetCar();
            car.ShowInfo();
        }
    }
}
