using System;
namespace primeiro
{
    public class Aluno
    {
        public string NomeAluno;
        public double nota1, nota2, nota3;

        public string Resultado() {
            double x = nota1 + nota2 + nota3;
            if (x >= 60)
            {
                return $" Nota final {x} do aluno {NomeAluno}, aluno APROVADO";
            }
            else {
                return $" Nota final {x} do aluno {NomeAluno}, aluno REPROVADO, faltaram  {60-x} pontos";
            }

        }
    }
}
