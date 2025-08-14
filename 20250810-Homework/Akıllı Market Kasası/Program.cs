using Akıllı_Market_Kasası;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akıllı_Market_Kasası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Clone Class
            products products = new products();
            Methots methots = new Methots();
            #endregion
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "*** Süper Market Sipariş Uygulaması ***";
            methots.WelcomeSeen();





        }
    }
}
