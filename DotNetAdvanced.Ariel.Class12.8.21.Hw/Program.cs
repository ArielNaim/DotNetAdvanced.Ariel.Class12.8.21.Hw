using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAdvanced.Ariel.Class12._8._21.Hw
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Random tempRandom = new Random();
            double[,] febMessurd = new double[2, 28];
            int day = 1;
            for (int i = 0; i < 2; i++) // בניית מערך אשר ממלא באופן רנדומלי טמפ' עבור 28 ימים 
            {
                for (int j = 0; j < 28; j++)
                {
                    febMessurd[0, j] = day;
                    day++;
                    febMessurd[1, j] = tempRandom.Next(24, 40) + tempRandom.NextDouble();
                }
            }
        }
      
    }
}
