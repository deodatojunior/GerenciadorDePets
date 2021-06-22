using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPet.Models
{
    public class Pet
    {
        private Pet()
        {

        }

        public Pet(string nome, int idade, string sexo, string tutor, DateTime dataNascimento, string especie, string raca, string porte)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
            this.tutor = tutor;
            this.dataNascimento = dataNascimento;
            this.especie = especie;
            this.raca = raca;
            this.porte = porte;

        }

        public int id { get; private set; }
        public string nome { get; private set; }
        public int idade { get; private set; }
        public string sexo { get; private set; }
        public string tutor { get; private set; }
        public DateTime dataNascimento { get; private set; }
        public string especie { get; private set; }
        public string raca { get; private set; }
        public string porte { get; private set; }
    }
}
