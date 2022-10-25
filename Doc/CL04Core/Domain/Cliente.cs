using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL04Core.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        public string Documento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime? UltimaAtualizacao { get; set; }

        public Endereco Endereco { get; set; }
    }
}