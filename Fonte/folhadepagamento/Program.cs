using folhadepagamento.Model;
using folhadepagamento.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace folhadepagamento
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new DadosCadastrais());
            Application.Run(new frmFormPrincipal());
        }
    }
}
