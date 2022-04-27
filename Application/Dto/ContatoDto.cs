using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class ContatoDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string DataNascimento { get; set; }

        public string Sexo { get; set; }

        public int Idade { get; set; }

        public int Ativo { get; set; }
    }
}
