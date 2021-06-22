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
    public partial class FrmListagemDePets : Form
    {
        public FrmListagemDePets()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNomePet.Text == "")
            {
                MessageBox.Show("Digite algum nome para pesquisa!");
            }
            else
            {
                DadosPet();
            }
        }

        public void DadosPet()
        {
            string pesquisa = txtNomePet.Text;

            List<Pet> pets;
            DataTable dataTable = new DataTable();

            using (Context db = new Context())
            {
                pets = db.Pets
                    .Where(x => x.nome.Contains(pesquisa))
                    .AsNoTracking()
                    .ToList();
            }
            
            if (pets.Count == 0)
            {
                MessageBox.Show("Sem resultados!");
            }
            else
            {
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("nome", typeof(string));
                dataTable.Columns.Add("idade", typeof(string));
                dataTable.Columns.Add("sexo", typeof(string));
                dataTable.Columns.Add("tutor", typeof(string));
                dataTable.Columns.Add("dataNascimento", typeof(string));
                dataTable.Columns.Add("especie", typeof(string));
                dataTable.Columns.Add("raca", typeof(string));
                dataTable.Columns.Add("porte", typeof(string));

                foreach (var pet in pets)
                {
                    dataTable.Rows.Add(pet.id, pet.nome, pet.idade, pet.sexo, pet.tutor, pet.dataNascimento, pet.especie, pet.raca, pet.porte);
                }

                dgvPets.DataSource = dataTable;
            }



        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int petId = Convert.ToInt32(dgvPets.CurrentRow.Cells["id"].Value);

            FrmCadastroDePets frncadastrodepets = new FrmCadastroDePets(petId);

            frncadastrodepets.Show();
        }
    }
}
