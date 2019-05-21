using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    partial class TituloPanel
    { 
        private Form _tela;

    public TituloPanel(Form tela)
        {
            InitializeComponent();

            _tela = tela;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            _tela.Close();
        }

    }
}
