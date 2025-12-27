using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
    internal class MenuScreen : Screen
    {
        private List<MenuItem> items;

        //-----------------------------------------------------------

        public MenuScreen(string title) : base(title)
        {
            items = new List<MenuItem>();
        }

        //-----------------------------------------------------------

        public void AddMenuItem(MenuItem item)
        {
            if (items == null)
            {
                items = new List<MenuItem>();
            }
            items.Add(item);
        }

        //-----------------------------------------------------------

        public void AddMenuItem(string displayName, Screen screen)
        {
            items.Add(new MenuItem(displayName, screen));
        }

        //-----------------------------------------------------------

        public override void Show()
        {
            base.Show();

            CenterText("Choose your screen: ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            bool exit = false;
            int choose = 0;
            while (!exit)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {items[i].DisplayName}");
                }
                Console.WriteLine($"{items.Count + 1} - Exit");

                Console.WriteLine("Select an option by number:");
                string inputNum = Console.ReadLine();
                int.TryParse(inputNum, out choose);
                if (choose > 0 && choose <= items.Count)
                {
                    exit = true;
                }

                Console.Clear();

                if (choose <= items.Count)
                {
                    
                    items[choose - 1].screen.Show();
                    Console.Clear();
                    Show();
                }

                else if (choose == items.Count + 1)
                {
                    exit = true;
                }
            }
        }
    }
}
