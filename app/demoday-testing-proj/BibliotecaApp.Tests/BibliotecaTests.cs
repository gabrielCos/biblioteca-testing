using BibliotecaApp;
using Xunit;

namespace BibliotecaApp.Tests
{
    public class BibliotecaTests
    {
        [Fact]
        public void AdicionarLivro_DeveAdicionarLivroCorretamente()
        {
            var biblioteca = new Biblioteca();
            var livro = new Livro(1, "O Alquimista", "Paulo Coelho");

            biblioteca.AdicionarLivro(livro);

            Assert.Contains(biblioteca.ListarLivros(), l => l.Titulo == "O Alquimista");
        }
    }
}