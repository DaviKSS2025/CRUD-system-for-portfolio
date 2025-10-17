using CRUD_genérico.Entidades;
namespace CRUD_genérico.Repositorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repoAlunos = new Repositorio<Aluno>();
            var repoLivro = new Repositorio<Livro>();

            while (true)
            {
                Console.WriteLine("O que deseja gerenciar?");
                Console.WriteLine("1. Gerenciar alunos");
                Console.WriteLine("2. Gerenciar livros");
                Console.WriteLine("3. Sair do programa.");

                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int result))
                {
                    switch (result) 
                    {
                        case 1:
                            Menu(repoAlunos);
                            break;
                        case 2:
                            Menu(repoLivro);
                            break;
                        case 3:
                            Console.WriteLine("Programa encerrado via comando.");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
            }
        }

        static void Menu<T>(Repositorio<T> repositorio) where T : Entidade, new() 
        { 
            while (true) 
            {
                Console.WriteLine("Qual ação deseja realizar na lista?");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Listar");
                Console.WriteLine("4. Voltar");
                string opcao = Console.ReadLine();

                if (int.TryParse (opcao, out int result))
                {
                    switch (result) 
                    {
                        case 1:
                            var entidade = new T();

                            if (entidade is Aluno aluno)
                            {
                                while (true)
                                {
                                    Console.Write("Nome: ");
                                    string inputNome = Console.ReadLine();
                                    aluno.Nome = inputNome;

                                    if (!string.IsNullOrEmpty(aluno.Nome))
                                        break;

                                    Console.WriteLine("Nome inválido! Tente novamente.");
                                }

                                while (true)
                                {
                                    Console.Write("Idade: ");
                                    string inputIdade = Console.ReadLine();
                                    if (int.TryParse(inputIdade, out int valor))
                                    {
                                        aluno.Idade = valor;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Idade inválida! Digite um número válido.");
                                    }
                                }
                                repositorio.Adicionar(entidade);
                            }
                            else if (entidade is Livro livro)
                            {
                                while (true)
                                {
                                    Console.Write("Título: ");
                                    string inputTitulo = Console.ReadLine();
                                    livro.Titulo = inputTitulo;
                                    if (!string.IsNullOrEmpty(livro.Titulo))
                                        break;

                                    Console.WriteLine("Título inválido! Tente novamente.");
                                }

                                while (true)
                                {
                                    Console.Write("Autor: ");
                                    string inputAutor = Console.ReadLine();
                                    livro.Autor = inputAutor;
                                    if (!string.IsNullOrEmpty(livro.Autor))
                                        break;

                                    Console.WriteLine("Autor inválido! Tente novamente.");
                                }
                                repositorio.Adicionar(entidade);
                            }
                            Console.WriteLine("Adicionado com sucesso!");
                            break;

                        case 2:
                            Console.WriteLine("Digite o ID para remover:");
                            string id_to_remove = Console.ReadLine();
                            if (int.TryParse(id_to_remove, out int validar))
                            {
                                if (repositorio.Remover(validar))
                                    Console.WriteLine("Removido com sucesso!");
                                else
                                    Console.WriteLine("ID não encontrado!");
                            }
                            break;

                        case 3:
                            var lista = repositorio.ListarTodos();
                            foreach (var item in lista)
                            {
                                item.MostrarDetalhes();
                            }
                            break;
                        case 4:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
            }
        }
    }
}
