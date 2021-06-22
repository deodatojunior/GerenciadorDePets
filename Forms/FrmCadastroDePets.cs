using CadastroPet.Database;
using CadastroPet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPet.Forms
{
    public partial class FrmCadastroDePets : Form
    {
        private int petId;
        public FrmCadastroDePets(int petId = 0)
        {
            
            InitializeComponent();
            this.petId = petId;
        }

       

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdadePet.Text);
            DateTime dataNascimento = Convert.ToDateTime(dtDataNascimentoPet.Value);
            try
            {
                Pet pet = new Pet(txtNomePet.Text, idade, txtSexoPet.Text, txtTutorPet.Text, dataNascimento, txtEspeciePet.Text, txtRacaPet.Text, txtPortePet.Text);

                bool ehEdicao = petId != 0;

                if (ehEdicao)
                {
                    using (Context db = new Context())
                    {
                        db.Entry(pet).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    MessageBox.Show("Pet alterado com sucesso!");
                }
                else
                {
                    using (Context db = new Context())
                    {
                        db.Pets.Add(pet);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Pet criado com sucesso!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
