namespace Teste
{
    public class Autores
    {
        public string nome_autor { get; set; }

        public bool Cadastrar_Autor(string nome_autor)
        {
            try
            {
                bool cadastro = false;
                this.nome_autor = nome_autor;
                cadastro = true;
                return cadastro;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar o autor, detalhes: " + ex.Message);
                return false;
            }
        }
    }

    public class Autores_Colecao : List<Autores>{

    }
}
