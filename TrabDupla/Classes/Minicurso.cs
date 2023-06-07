using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabDupla.Classes
{
    class Minicurso: AtividadeComplementar
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

        public string UrlCertificado { get; private set; }

        public Minicurso(string nome, int cargaHoraria, string urlCertificado)
        {
            Nome = nome;
            DataRealizacao = dataRealizacao;
            CargaHoraria = cargaHoraria;
            UrlCertificado = urlCertificado;
        }
    }
}
