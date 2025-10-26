namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime? DataLimite { get; set; }
        public int UsuarioId { get; set; }
        public bool Concluido { get; set; } = false;
    }
}
