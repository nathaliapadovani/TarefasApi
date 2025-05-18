using System;
using System.ComponentModel.DataAnnotations;

namespace TarefasApi.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataConclusao { get; set; }
        public StatusTarefa StatusTarefa { get; set; } = StatusTarefa.Pendente;
    }

    public enum StatusTarefa
    {
        Pendente = 0,
        Concluida = 1
    }
}