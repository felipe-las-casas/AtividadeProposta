using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabDupla.Classes
{
    class Aluno
    {
        public string Nome { get; private set; }
        public string email;
        public Aluno(string mome)
        {
            Nome = mome;
        }
    }

}
