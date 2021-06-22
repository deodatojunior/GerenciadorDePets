using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPet.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastroDePets frmcadastrodepets = new FrmCadastroDePets();
            frmcadastrodepets.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmListagemDePets frmlistagemdepets = new FrmListagemDePets();
            frmlistagemdepets.Show();
        }
    }
}
