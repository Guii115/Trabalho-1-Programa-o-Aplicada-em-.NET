namespace Trabalho_1___Programação_Aplicada_em_.NET
{
    internal class Program
    {
        public static string VerificarEmprestimo(Object obj)
        {
            return obj switch
            {
                null => "Usuário inválido",

                Professor { QuantidadeEmprestimosAtivos: < 5 } => "Empréstimo autorizado para professor",

                Professor { QuantidadeEmprestimosAtivos: >= 5 } => "Limite de empréstimos atingido para professor",

                Aluno { QuantidadeEmprestimosAtivos: < 3 } => "Empréstimo autorizado para aluno",

                Aluno { QuantidadeEmprestimosAtivos: >= 3 } => "Limite de empréstimos atingido para aluno",

                Visitante => "Visitantes não podem realizar empréstimos",

                _ => "Usuário não classificado"
            };
        }
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno { Nome = "João", QuantidadeEmprestimosAtivos = 2, Matricula = "12345" };
            Aluno aluno2 = new Aluno { Nome = "Valdecir", QuantidadeEmprestimosAtivos = 3, Matricula = "12345" };
            Professor professor = new Professor { Nome = "Dr. Silva", QuantidadeEmprestimosAtivos = 4, Departamento = "Ciência da Computação" };
            Professor professor2 = new Professor { Nome = "Dr. Souza", QuantidadeEmprestimosAtivos = 5, Departamento = "Matemática" };
            Visitante visitante = new Visitante { Nome = "Maria", QuantidadeEmprestimosAtivos = 0 };
            Console.WriteLine($"{aluno.Nome}: {VerificarEmprestimo(aluno)}");
            Console.WriteLine($"{aluno2.Nome}: {VerificarEmprestimo(aluno2)}");
            Console.WriteLine($"{professor.Nome}: {VerificarEmprestimo(professor)}");
            Console.WriteLine($"{professor2.Nome}: {VerificarEmprestimo(professor2)}");
            Console.WriteLine($"{visitante.Nome} : {VerificarEmprestimo(visitante)}");

            Console.WriteLine(VerificarEmprestimo(null));
        }
    }
}
