using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabDupla.Classes
{
    class Registro
    {
        public DateOnly DataValidacao { get; private set; }

        public Registro(int year, int month, int day)
        {
            DataValidacao = new DateOnly(year, month, day);
        }
        
        public void RegistrarAtividade(Minicurso minicurso, Aluno aluno)
        {
            if(minicurso.DataRealizacao < DataValidacao) 
            {
                Console.WriteLine("O aluno " + aluno.Nome + " fez o curso " + minicurso.Nome + " .");
            }

        }

        public void RegistrarAtividade(Minicurso minicurso, Aluno aluno)
        {
            if(minicurso.DataRealizacao < DataValidacao) 
            {
                Console.WriteLine("O aluno " + aluno.Nome + " fez o curso " + minicurso.Nome + " .");
            }

        }
    }
}
