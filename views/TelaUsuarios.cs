using ProjetoSebo.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    public partial class TelaUsuarios : Form
    {
        private SeboContext _context;
        public TelaUsuarios(SeboContext context)
        {
            _context = context;

            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
