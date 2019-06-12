using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDePessoas
{
    class Pessoa
    {
        public String Nome { set; get; }
        public Int32 Idade { set; get; }
        public DateTime Nascimento { set; get; }
        public String Profissao { set; get; }
        public String Sexo { set; get; }
        public Int64 Telefone { set; get; }


        /*
        public void ConfiguraNome(String valor)
        {
            this.nome = valor.ToUpper();
        }

        public String PegaNome()
        {
            return this.nome;
        }
        */
    }
}
