using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forro_de_PVC
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Campos criados: EscolhaProduto 1 to 15
            //Campos criados: ControleDoMultiplo 1 to 15
            //Campos criados: MultiploDoProduto 1 to 15
            //Campos criados: ValorDoMetro 1 to 15
            //Campos criados: PrecoRecomendado 1 to 15
            //Campos criados: PrecoDeRevenda 1 to 15

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
