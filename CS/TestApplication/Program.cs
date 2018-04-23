using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace TestApplication {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            InitDAL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void InitDAL() {
            string serviceUrl = "http://localhost:2224/XpoGate/MyXpoService.asmx";
            XpoDefault.DataLayer = new SimpleDataLayer(new MyWebDataStore(serviceUrl));
        }
    }
}