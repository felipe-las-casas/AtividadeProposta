using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrabDupla.Classes
{
    class Palestra : AtividadeComplementar
    {
        public override string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public override DateOnly DataRealizacao;

        public Minicurso(int year, int month, int day)
        {
            DataRealizacao = new DateOnly(year, month, day);
        }

        public override int CargaHoraria
        {
            get
            {
                return cargahoraria;
            }
            set
            {
                cargahoraria = value;
            }
        }

        public string Palestrante { get; private set; }

        public Palestra(string nome, int cargahoraria, string palestrante) 
        {
            Nome = nome;
            DataRealizacao = datarealizacao;
            CargaHoraria = cargahoraria;
            Palestrante = palestrante;
        }
    }

}
