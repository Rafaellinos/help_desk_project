using PIM4SEMVER1._0.GUI;
using System;
using System.Windows.Forms;


namespace PIM4SEMVER1._0
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string usu;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TelaLogin tl = new TelaLogin();
            
            if(tl.ShowDialog()== DialogResult.OK) //se receber ok da tela de login, inicia a tela inicial
            {
                usu = tl.usua; //carrega o usuário para a tela principal
                Application.Run(new TelaInicial(usu));
            }
            

        }
    }
}
