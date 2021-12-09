using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Gravadora
    {
        private int id, id_categoria, id_formacao;
        private string nome, credencial;
        private DateTime data_nascimento;

        public int ID_FORMACAO { get { return id_formacao; } set { id_formacao = value; } }
        public int ID_CATEGORIA { get { return id_categoria; } set { id_categoria = value; } }
        public string CREDENCIAL { get { return credencial; } set { credencial = value; } }
        public int ID { get { return id; } set { id = value; } }
        public string NOME { get { return nome; } set { nome = value; } }
        public DateTime DATA_NASCIMENTO { get { return data_nascimento; } set { data_nascimento = value; } }

    }
}
