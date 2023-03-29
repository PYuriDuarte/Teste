
using System.Runtime.CompilerServices;
using Teste;

// Menu

Funcoes f1 = new Funcoes();
Autores_Colecao autores  = new Autores_Colecao();
Livros_Colecao livros  = new Livros_Colecao();

int escolha;

do
{
    Console.Clear();

    Console.WriteLine("LIVRARIA YURI");
    Console.WriteLine("----------------------");
    Console.WriteLine("");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("");
    Console.WriteLine("1 - Cadastrar autor"); //ok
    Console.WriteLine("2 - Mostrar autores cadastrados"); //ok 
    Console.WriteLine("3 - Editar autores"); //ok 
    Console.WriteLine("4 - Cadastrar livro"); //ok
    Console.WriteLine("5 - Consultar livro"); //ok
    Console.WriteLine("6 - Editar livros"); //ok 
    Console.WriteLine("7 - Excluir livro"); //ok
    Console.WriteLine("8 - Sair do sistema"); //ok

    string opcao = Console.ReadLine();               
    escolha = f1.Verifica_Digito(opcao) == false ? 0 : Convert.ToInt32(opcao);     //validação para tentar converter um vazio ou um caracter diferente, para o tipo escolhido ("int" no caso).

    switch (escolha)
    {
        case 1:            
            Console.WriteLine("Informe o nome do autor: ");
            string nome_autor = Console.ReadLine();

            bool autor_ja_cadastrado = false; //variavel bool para validação de cadastro de mais de um autor de mesmo nome.

            if (f1.Verifica_Nomes(nome_autor) == false)
            {               
                foreach (Autores a1 in autores)
                {
                    if (a1.nome_autor.ToUpper().Equals(nome_autor.ToUpper()))
                    {
                        Console.Clear();
                        Console.WriteLine("Já foi cadastrado um autor com esse nome.");
                        Console.WriteLine("Aperte \"ENTER\" para voltar");
                        Console.ReadLine(); // ReadLine vazio para esperar um enter e não avançar sem o usuario permitir.
                        autor_ja_cadastrado = true;
                        break;
                    }
                }

                if (autor_ja_cadastrado == false)
                {
                    Autores autor = new Autores();

                    if (autor.Cadastrar_Autor(nome_autor) == true)
                    {
                        Console.Clear();

                        Console.WriteLine($"O {nome_autor} foi cadastrado com sucesso.");
                        autores.Add(autor);

                        Console.WriteLine("");

                        Console.WriteLine("Aperte \"ENTER\" para voltar");

                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Não foi possível cadastrar o autor: {nome_autor}");
                        Console.WriteLine("");
                        Console.WriteLine("Aperte \"ENTER\" para voltar");

                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção invalida.");
                Console.ReadLine();
            }
            break;
        case 2:
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Lista dos Autores cadastrados no sistema: ");
            Console.WriteLine("");

            if (autores.Count > 0)
            {
                for (int i = 0; i < autores.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {autores[i].nome_autor}");
                }
            }
            else
            {
                Console.WriteLine("vazio");
            }
            

            Console.WriteLine("");
            Console.WriteLine("Aperte \"ENTER\" para voltar");

            Console.ReadLine();

            break;
        case 4:
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Escolha o autor do livro que será cadastrado: ");
            Console.WriteLine("");

            for (int i = 0; i < autores.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {autores[i].nome_autor}");
            }

            escolha = Convert.ToInt32(Console.ReadLine());

            while (escolha > autores.Count || escolha <= 0)
            {
                Console.Write("Autor inválido, informe novamente o código do autor: ");

                escolha = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Informe o nome do livro: ");

            string nome_livro = Console.ReadLine();

            bool livro_ja_cadastrado = false;

            foreach (Livros l1 in livros)
            {
                if (l1.nome_livro.ToUpper().Equals(nome_livro.ToUpper()) && l1.autor.nome_autor.Equals(autores[escolha - 1].nome_autor))
                {
                    Console.Clear();
                    Console.WriteLine("Já foi cadastrado um livro com esse nome e autor.");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte \"ENTER\" para voltar");
                    Console.ReadLine();
                    livro_ja_cadastrado = true;
                    break;
                }
            }

            if (livro_ja_cadastrado == false)
            {
                Livros livro = new Livros();

                if (livro.Cadastrar_Livro(nome_livro, autores[escolha - 1]) == true)
                {
                    Console.Clear();

                    Console.WriteLine($"O {nome_livro} foi cadastrado com sucesso.");
                    livros.Add(livro);

                    Console.WriteLine("");

                    Console.WriteLine("Aperte \"ENTER\" para voltar");

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Não foi possível cadastrar o livro: {nome_livro}");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte \"ENTER\" para voltar");

                    Console.ReadLine();
                }
            }
            break;
        case 5:
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Lista dos Livros cadastrados no sistema: ");
            Console.WriteLine("");            

            if( livros.Count > 0)
            {
                for (int i = 0; i < livros.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. (livro: {livros[i].nome_livro}) - (autor: {livros[i].autor.nome_autor})");
                }
            }
            else
            {
                Console.WriteLine("Vazio");
            }

            Console.WriteLine("");
            Console.WriteLine("Aperte \"ENTER\" para voltar");
            Console.ReadLine();
            break;
        case 7:
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Lista dos Livros cadastrados no sistema: ");
            Console.WriteLine("");

            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. (livro: {livros[i].nome_livro}) - (autor: {autores[i].nome_autor})");
            }

            Console.WriteLine("");
            Console.Write("Selecione o número do livro que deseja excluir: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            while (escolha > autores.Count || escolha <= 0)
            {
                Console.Write("O número do livro selecionado não existe no nosso banco de dados, escolha um número válido: ");
                escolha = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");

            Console.WriteLine($"Tem certeza que deseja excluir o livro {livros[escolha - 1].nome_livro}? [S/N]");
            string letra = Console.ReadLine().ToLower();

            if (letra == "s")
            {
                livros.RemoveAt(escolha - 1);
                Console.WriteLine("O Livro foi removido com sucesso!");
                Console.WriteLine("");
                Console.WriteLine("Aperte \"ENTER\" para finalizar");
                Console.ReadLine();

            } 
            else if(letra == "n")
            {
                Console.WriteLine("Aperte \"ENTER\" para voltar ao ínicio.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Para excluir o livro {livros[escolha - 1].nome_livro}, aperte \"S\" ou  \"N\"");
                Console.ReadLine();
            }
            break;
        case 8:
            Console.WriteLine("Saindo da livraria do Yuri...");

            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Opção inválida...");
            Console.WriteLine("");
            Console.WriteLine("Aperte \"ENTER\" para finalizar");
            Console.ReadLine();
            break;
    }       
} while (escolha != 8);

