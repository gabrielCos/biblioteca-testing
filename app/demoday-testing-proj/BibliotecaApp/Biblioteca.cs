using System.Collections.Generic;

namespace BibliotecaApp
{
    public class Biblioteca
    {
        private readonly List<Livro> _livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            _livros.Add(livro);
        }

        public IEnumerable<Livro> ListarLivros()
        {
            return _livros;
        }
    }
}
