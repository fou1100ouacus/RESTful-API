using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {



        // Import the SystemParametersInfo function from user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(
            uint action, uint uParam, string vParam, uint winIni);

        // Constants for the function
        public static readonly uint SPI_SETDESKWALLPAPER = 0x14;
        public static readonly uint SPIF_UPDATEINIFILE = 0x01;
        public static readonly uint SPIF_SENDCHANGE = 0x02;

       
        public static void SetWallpaper(string path)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
            Console.WriteLine("Wallpaper changed successfully!");
        }







        static void Main(string[] args)
        { // The path to the wallpaper image
            string wallpaperPath = @"D:\Downloads\wallper\513c1941-3aeb-4a44-ac80-6d070b5722a5";

            // Set the wallpaper
            SetWallpaper(wallpaperPath);
            Console.ReadKey();
        }
    }
}
