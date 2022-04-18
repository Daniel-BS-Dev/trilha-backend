using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GravarUsandoAdoNet();
            // GravarUsandoEntity();
            Recuperar();
            Excluir();
            Recuperar();
            Atualizar();

            Console.ReadLine();
        }
        // atualizando
        private static void Atualizar()
        {
            
        }

        // excluindo produtos
        private static void Excluir()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
        }

        // mostrando a lista de produto
        private static void Recuperar()
        {
            using(var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach(var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        // com o entity
        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var context = new LojaContext())
            {
                context.Produtos.Add(p);
                context.SaveChanges();
            }
        }

        // sem o entity
        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
