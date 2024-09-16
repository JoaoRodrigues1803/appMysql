using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AppMySql
{
    internal static class Program
    {
        public static Conexao cx;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            cx = new Conexao("localhost","app_mysql","root");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(cx.testarConexao())
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show(
                    $"Erro: {cx.getMsgErro()}",
                    "Erro ao coectar-se ao banco!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
            }
           
        }
    }
}
