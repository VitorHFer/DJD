using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoIsmai
{
    class Aluno
    {
      
        public string nome;
        public int numero;
        public int ano;
        public string curso;
        

        public Aluno(string nome, int numero, int ano, string curso)
        {
            
            this.nome = nome;
            this.numero = numero;
            this.ano = ano;
            this.curso = curso;

        }

        public override string ToString()
        {
            return nome + "Nº A" + numero.ToString() + "Ano: " + ano.ToString() + "Curso: " + curso;
        }

        public bool InscritoAntes(Aluno aluno)
        {
            if (numero > aluno.numero)
            {
                return true;
            }
            else
            {
                return  false;
            }
        }

        public void PrimeiroUltimoNome()
        {
            string [] names = nome.Split(' ');
            Console.WriteLine(names[0] + " " + names[names.Length-1]);
        }
    }
}
