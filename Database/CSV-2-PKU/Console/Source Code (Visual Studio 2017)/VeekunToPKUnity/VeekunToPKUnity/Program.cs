using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
    
namespace VeekunToPKUnity
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Introducing the user to the Tool
            Console.Title = "Veekun To Pokemon Unity Database Converter";
            Console.WriteLine("Welcome to Veekun To Pokemon Unity Database Converter.");
            Console.WriteLine("This tool is made for the Pokemon Unity Community.");
            Console.WriteLine("Check out their GitHub here: https://github.com/PokemonUnity/PokemonUnity");

            Console.WriteLine();

            //Getting the Veekun Database Folder
            Console.WriteLine("Please select a folder where the .csv files from Veekun are located...");
            int csvFiles = 0;
            while (csvFiles != 172)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string[] files = Directory.GetFiles(fbd.SelectedPath, "*.csv");
                        csvFiles = files.Length;
                        if(csvFiles != 172)
                        {
                            Console.WriteLine($"Your Veekun Database folder does not contain 172 .csv  files, yours contains {files.Length}.");
                            Console.WriteLine("In my PokemonUnityInessentials GitHub Repository is a full Veekun Database and the most recent version of this tool.");
                            Console.WriteLine("Consider checking it out: https://github.com/Velorexe/PKUnityInessentials");
                        }
                    }
                }
            }
            Console.Clear();

            //Setting the Generation
            string[] Generations = new string[16]
            {
                "Blue and Red", "Yellow", "Gold and Silver", "Crystal", "Ruby and Sapphire", "Emerald", "FireRed and LeafGreen", "Diamond and Pearl", "Platinum", "Heartgold and Soulsilver", "Black and White", "Black 2 and White 2", "X and Y", "Omega Ruby and Alpha Sapphire", "Sun and Moon", "Ultra Sun and Ultra Moon"
            };
            Console.WriteLine("Wich generation would you like to convert?");
            Console.WriteLine("---------------------------");

            int SelectedItem = PrintGenerations(0, Generations);
            Console.WriteLine("---------------------------");
            var k = Console.ReadKey();

            while (k.Key != ConsoleKey.Enter)
            {
                if (k.Key == ConsoleKey.UpArrow)
                {
                    SelectedItem--;
                }
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    SelectedItem++;
                }
                Console.Clear();

                Console.WriteLine("Wich generation would you like to convert?");
                Console.WriteLine("---------------------------");

                SelectedItem = PrintGenerations(SelectedItem, Generations);
                Console.WriteLine("---------------------------");

                k = Console.ReadKey();
            }
            
            Console.ReadKey();
        }
        public static int PrintGenerations(int SelectedItem, string[] Generations)
        {
            for (int i = 0; i < Generations.Length; i++)
            {
                if (SelectedItem == Generations.Length)
                {
                    SelectedItem = 0;
                }
                else if (SelectedItem == -1)
                {
                    SelectedItem = Generations.Length - 1;
                }
                if (i == SelectedItem)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(Generations[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(Generations[i]);
                }
            }
            return SelectedItem;
        }
    }
}
