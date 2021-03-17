using System;

namespace AlunoIsmai
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Vítor Hugo Fernandes", 039490, 1, "DJD");
            Aluno b = new Aluno("Miguel Ferreira", 035789, 1, "DJD");

            a.PrimeiroUltimoNome();

            Console.WriteLine(a.ToString());
            Console.WriteLine(a.InscritoAntes(b));
        }
    }
}
