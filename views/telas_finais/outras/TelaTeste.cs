using ProjetoSebo.dao;
using System.Windows.Forms;

namespace ProjetoSebo.views.telas_finais.outras
{
    public partial class TelaTeste : Form
    {
        private SeboContext Context{ get; set; }

        public TelaTeste(SeboContext context)
        {
            InitializeComponent();

            this.Context = context;

            this.txtProduto.SetContext(Context);
        }
    }
}
