
namespace DTO
{
    public class DTO_Aluno
    {
        private DTO_Turma turma = new DTO_Turma();
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DTO_Turma Turma { get => turma; set => turma = value; }        
    }
}
