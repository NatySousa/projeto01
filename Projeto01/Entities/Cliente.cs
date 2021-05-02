using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01.Entities // localização da classe dentro do projeto
{
    public class Cliente // definição da classe
    {
        public Guid Id { get; set; } //prop tab tab
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}
