
//// 1ª - Escrever um algoritmo que mostre no console os números de 1 a 10.
//// 2ª - Escrever um algoritmo que mostre no console os números pares entre 1 - 20.
//// 3ª - Escrever um algoritmo que mostre no console a soma dos números pares entre 2 - 20.
//// 4ª - Escrever um algoritmo que mostre no console a média das 3 notas informadas pelo usuário.
//// 5ª - Escrever um algoritmo que realize uma validação em cada nota informada no exercício anterior.

//// Escopo de variáveis.
//// i++ -> i = i + 1;
////Console.WriteLine("");
////string ex = Console.ReadLine();

using System.Runtime.CompilerServices;
using Teste;

//Autores autores = new Autores();

//bool autor_cadastrado = autores.Cadastrar_Autor("Yuri");

//if (autor_cadastrado == true)
//{
//    Console.WriteLine("O nome do autor cadastro foi: " + autores.nome_autor);
//}
//else
//{
//    Console.WriteLine("Não foi possível cadastrar esse autor");
//}

// Menu


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
    Console.WriteLine("1 - Cadastrar autor");
    Console.WriteLine("2 - Mostrar autores cadastrados");
    Console.WriteLine("3 - Cadastrar livro");
    Console.WriteLine("4 - Consultar livro");
    Console.WriteLine("5 - Excluir livro");
    Console.WriteLine("6 - Sair do sistema");

    escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:

            Console.WriteLine("Informe o nome do autor: ");
            string nome_autor = Console.ReadLine();

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

            break;
        case 2:
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Lista dos Autores cadastrados no sistema: ");
            Console.WriteLine("");

            for (int i = 0; i < autores.Count; i++)
            {
                Console.WriteLine($"{i+1} - {autores[i].nome_autor}");
            }

            Console.WriteLine("Aperte \"ENTER\" para voltar");

            Console.ReadLine();

            break;
        case 3:

            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Escolha o autor do livro que será cadastrado: ");
            Console.WriteLine("");

            for (int i = 0; i < autores.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {autores[i].nome_autor}");
            }

            escolha = Convert.ToInt32(Console.ReadLine());

            do
            {

            }while(escolha <= autores.Count);

            //Console.WriteLine("Informe o nome do autor: ");
            //string nome_livro = Console.ReadLine();

            //Livros livro = new Livros();

            //if (livro.Cadastrar_Livro(nome_livro) == true)
            //{
            //    Console.Clear();

            //    Console.WriteLine($"O {nome_livro} foi cadastrado com sucesso.");
            //    livros.Add(livro);

            //    Console.WriteLine("");

            //    Console.WriteLine("Aperte \"ENTER\" para voltar");

            //    Console.ReadLine();
            //}
            Console.ReadLine();

            break;
        case 5:
            Console.WriteLine("Saindo da livraria do Yuri...");

            Console.ReadLine();
            break;
        default:
            break;
    }       
} while (escolha != 6);




//switch (teste)
//{
//    case 1:
//        Console.WriteLine("1");
//        break;
//    case 2: Console.WriteLine("2"); break;
//    case 3: Console.WriteLine("3"); break;
//    case 4: Console.WriteLine("4"); break;
//    case 5: Console.WriteLine("5"); break;
//    default:
//        Console.WriteLine("Baidu");
//        break;
//}

//// 1ª Exercício.

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("-------------------------");

//// 2ª Exercício.

//for (int i = 1; i <= 20; i++)
//{
//    if (i%2 == 0)
//    {
//        Console.WriteLine(i);        
//    }
//}

//Console.WriteLine("-------------------------");

//// 3ª Exercício.

//int soma = 0;

//for (int i = 2; i <= 20; i+=2)
//{
//    soma += i;
//}

//Console.WriteLine(soma);

//Console.WriteLine("-------------------------");

//// 4ª Exercício.

////Console.WriteLine("Digite um a nota1:");
////double n1 = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("Digite um a nota2:");
////double n2 = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("Digite um a nota3:");
////double n3 = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("A sua média é:" + (n1 + n2 + n3)/3);

////Console.WriteLine("-------------------------");

////// 5ª Exercício.

////if (n1 < 0 || n1 > 10)
////{
////    Console.WriteLine("Nota 1 invalida...Informe uma nota entre 0 e 10");
////    return;
////}
////if (n2 < 0 || n2 > 10)
////{
////    Console.WriteLine("Nota 2 invalida...Informe uma nota entre 0 e 10");
////    return;
////}
////if (n3 < 0 || n3 > 10)
////{
////    Console.WriteLine("Nota 3 invalida...Informe uma nota entre 0 e 10");
////    return;
////}

//Console.WriteLine("-------------------------");

//// 6ª Exercício.

////Console.WriteLine("Digite um a nota1:");
////double n1 = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("Digite um a nota2:");
////double n2 = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("Digite um a nota3:");
////double n3 = Convert.ToDouble(Console.ReadLine());



////if (n1 < 0 || n1 > 10)
////{
////    Console.WriteLine("Nota 1 invalida...Informe uma nota entre 0 e 10");
////}
////else if (n2 < 0 || n2 > 10)
////{
////    Console.WriteLine("Nota 2 invalida...Informe uma nota entre 0 e 10");
////}
////else if (n3 < 0 || n3 > 10)
////{
////    Console.WriteLine("Nota 3 invalida...Informe uma nota entre 0 e 10");
////}
////else
////{
////    Console.WriteLine("A sua média é:" + (n1 + n2 + n3) / 3);
////}

//Console.WriteLine("-------------------------");

// 7ª Exercício.

//Console.WriteLine("Digite um número: ");
//int imp = Convert.ToInt32(Console.ReadLine());
//int count = 1;

//int lista_numeros = imp;


//for (int i = 2; i <= 20; i ++)
//{    
//    if ((i%2) == 1) {
//        Console.WriteLine(i);
//    }    
//}
//while (count <= 6)
//{
//    if ((lista_numeros % 2) == 1)
//    {
//        Console.WriteLine(lista_numeros);
//        count++;
//    }        

//    lista_numeros++;
//}

//Console.WriteLine("Digite o primeiro número: ");
//int numb1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite o segundo número: ");
//int numb2 = Convert.ToInt32(Console.ReadLine());
//int soma = 0;

//if (numb1 > numb2)
//{
//    int temp = numb1;
//    numb1 = numb2;
//    numb2 = temp;
//}


//for (int i = numb1 + 1; i < numb2; i++)
//{
//    if (Math.Abs(i) % 2 == 1)
//    {
//        soma+=i;
//    }
//}

//Console.WriteLine(soma);

//int[] vetor_exemplo = new int[10];
//Console.WriteLine("Digite um número:");
//int numero = Convert.ToInt32(Console.ReadLine());

//vetor_exemplo[0] = numero;

//for (int i = 1; i < 10; i++)
//{
//    vetor_exemplo[i] = vetor_exemplo[i - 1] * 2;   
//}

//for (int i = 0;i < 10; i++)
//{
//    Console.WriteLine($"N[{i}] = {vetor_exemplo[i]}");
//}

//const int indice = 1000;

//int[] vetor_exemplo = new int[indice];
//Console.WriteLine("Digite um número:");
//int numero = Convert.ToInt32(Console.ReadLine());

//int contador = 0;

//while (contador < indice)
//{
//    for (int j = 0; j < numero; j++)
//    {
//        vetor_exemplo[contador] = j;        

//        if (++contador >= indice)
//        {
//            break;
//        }
//    }
//}

////for (int i = 0; i < indice; i++)
////{

////}

//for (int i = 0;i < indice; i++)
//{
//    Console.WriteLine($"N[{i}] = {vetor_exemplo[i]}");
//}

