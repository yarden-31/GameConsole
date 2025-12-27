using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
    public class Screen
    {
        public string Title 
        { 
            get; set; 
        }

        //-----------------------------------------------------------

        public Screen(string title)
        {
            Title = title;
        }

        //-----------------------------------------------------------

        public virtual void Show()
        {
            // make background color black and text color cyan
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            int contentWidth = Title.Length + 2;
            int boxWidth = contentWidth + 2;
            int leftPadding = (Console.WindowWidth - boxWidth) / 2;

            // makes a frame box around the title
            string pad = new string(' ', leftPadding);
            Console.WriteLine(pad + "╔" + new string('═', contentWidth) + "╗");
            Console.WriteLine(pad + "║ " + Title + " ║");
            Console.WriteLine(pad + "╚" + new string('═', contentWidth) + "╝");
        }


        //-----------------------------------------------------------

        public void CenterText(string text)
        {
            Console.SetCursorPosition(Console.WindowTop + Console.WindowWidth / 2 - text.Length / 2, Console.CursorTop);
            Console.WriteLine(text);
        }
    }
}
