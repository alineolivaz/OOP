
using System;
using System.Collections.Generic;

namespace DTO
{
    public class DTO_Recado
    {
        private DTO_Aluno aluno = new DTO_Aluno();
        private List<DTO_Disciplina> disciplinas = new List<DTO_Disciplina>();
        public int Id { get; set; }
        public string Recado { get; set; }
        public DateTime Data { get; set; }
        public DTO_Aluno Aluno { get => aluno; set => aluno = value; }
        public List<DTO_Disciplina> Disciplinas { get => disciplinas; set => disciplinas = value; }
    }
}
