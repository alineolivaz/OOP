using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Musica
    {
        private int idmusica, idgravadora, idcd;
        private string nome, nomeautor;

        public int IDMUSICA { get { return idmusica; } set { idmusica = value; } }
        public string NOME { get { return nome; } set { nome = value; } }
        public string NOMEAUTOR { get { return nomeautor; } set { nomeautor = value; } }
        public int IDGRAVADORA { get { return idgravadora; } set { idgravadora = value; } }
        public int IDCD { get { return idcd; } set { idcd = value; } }
        
    }
}
