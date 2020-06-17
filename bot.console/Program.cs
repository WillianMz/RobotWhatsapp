using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace bot.console
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();


        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando.....");
            /* --->CHAMAR UM PROGRAMA
             
            var fire = Process.Start("chrome.exe");

            Console.WriteLine("ID do processo: " + fire.Id);
            
            while (true)
            {
                IntPtr hWnd = GetForegroundWindow();

                if (hWnd == fire.MainWindowHandle)
                {
                    Console.WriteLine("Janela ativa");
                }
                else
                {
                    Console.WriteLine("Janela inativa");
                }

                Thread.Sleep(500);
                
            }*/

            //SIMULAR SENDKEYS
        }
        
    }
}
