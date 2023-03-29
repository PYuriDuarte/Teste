using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Livros
    {
        public string nome_livro { get; set; }
        public Autores autor { get; set; }
        public bool Cadastrar_Livro(string nome_livro, Autores autor_indice)
        {       
            try
            {
                bool cadastro = false;
                this.nome_livro = nome_livro;
                this.autor = autor_indice;
                cadastro = true;
                return cadastro;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar o livro, detalhes: " + ex.Message);
                return false;
            }
        }
    }
    public class Livros_Colecao : List<Livros>
    {

    }
}
