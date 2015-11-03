using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_Library.ProcessHandler
{
    public class ProcessHandler
    {
        public static int? StartProcess(string path)
        {
            // Start the child process.
            Process p = new Process();
            int? result = null;
            try
            {
                // Redirect the output stream of the child process.
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = path;// "C:\Path\To\App.exe";
                p.Start();

                p.WaitForExit(); //will synchronously wait
                result = p.ExitCode;
            }
            catch (Exception e)
            {
                //TODO: error message
                //failed start
                result = 3;
                Environment.Exit(3);
            }

            return result;
        }
    }
}
