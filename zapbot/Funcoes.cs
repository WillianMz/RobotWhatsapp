using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zapbot
{
    public class Funcoes
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        public void iniciarProcesso(string programa)
        {
            var p = Process.Start(programa);
            while(true)
            {
                IntPtr hWnd = GetForegroundWindow();

                if (hWnd == p.MainWindowHandle)
                {                    
                }
                else
                {

                }                
            }
        }
    }
}
