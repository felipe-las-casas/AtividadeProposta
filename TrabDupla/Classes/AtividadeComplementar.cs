using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabDupla.Classes
{
    public abstract class AtividadeComplementar
    {
        protected string nome;
        public abstract string Nome { get; set; }
        
        //protected DateOnly datarealizacao;
        abstract DateOnly DataRealizacao { get; set; }

        protected int cargahoraria;
        public abstract int CargaHoraria { get; set; }
        
    }
}
