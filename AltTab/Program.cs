using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace com.praim.altTab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!OSFeature.Feature.IsPresent(OSFeature.LayeredWindows))
                // the system do not support alpha form (use a standard form as fallback)
                Application.Run(new StandardForm(50, new Point(0,0)));
            else
                // use the beautiful alpha enabled form
                Application.Run(new AlphaForm(50, new Point(0, 0)));
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            byte[] ba = null;
            string resource = "com.praim.altTab.Resources." + args.Name.Split(new char[] { ',' })[0] + ".dll";
            Assembly curAsm = Assembly.GetExecutingAssembly();
            using (Stream stm = curAsm.GetManifestResourceStream(resource))
            {
                ba = new byte[(int)stm.Length];
                stm.Read(ba, 0, (int)stm.Length);

                return Assembly.Load(ba);
            }
        }
    }
}