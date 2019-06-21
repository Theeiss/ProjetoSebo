using ProjetoSebo.controller;
using ProjetoSebo.dao;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaVendas : Form
    {
        public VendasController VendasCtrl { private get; set; }

        public TelaVendas(SeboContext context)
        {
            this.VendasCtrl = new VendasController()
            {
                Context = context
            };

            InitializeComponent();
        }
    }
}
