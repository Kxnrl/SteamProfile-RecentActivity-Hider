using System;
using System.Diagnostics;
using System.Threading;

namespace SteamProfile_RecentActivity_Hider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Steam Profile Recent Activity Hider";
            Console.ForegroundColor = ConsoleColor.Green;

            Process[] proc = Process.GetProcessesByName("Steam");
            if (proc.Length < 1)
            {
                Console.WriteLine("Please run steam first." + Environment.NewLine);
                Process.Start("steam://url/SteamIDMyProfile");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.WriteLine("Please do not operate steam until the end." + Environment.NewLine);

            // Set steam offline
            Console.WriteLine("Set steam friend offline..." + Environment.NewLine);
            Process.Start("steam://friends/status/offline");
            Thread.Sleep(3000);

            /* video */
            Console.WriteLine("Starting html5 player..." + Environment.NewLine);
            // dev1ce
            Process.Start("steam://run/413858");
            Thread.Sleep(5000);

            // Simp1e
            Process.Start("steam://run/585283");
            Thread.Sleep(5000);

            // Dupreeh
            Process.Start("steam://run/497811");
            Thread.Sleep(5000);

            // Olofmeister
            Process.Start("steam://run/413854");
            Thread.Sleep(5000);

            // steam
            foreach (Process p in proc)
            {
                Console.WriteLine("Kill {0} -> {1}", p.ProcessName, p.Id);
                p.Kill();
            }

            // h5player
            Process[] h5player = Process.GetProcessesByName("html5app_steam");
            foreach (Process p in h5player)
            {
                Console.WriteLine("Kill {0} -> {1}", p.ProcessName, p.Id);
                p.Kill();
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please verfiy that the history has been cleared.");
            Console.WriteLine("If not, please restart the program.");

            Process.Start("steam://url/SteamIDMyProfile");

            Console.ReadKey();
        }
    }
}
