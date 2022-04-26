# Instalando o Entity

## Criando um banco de dados
- exibir -> pesquisador de objetos do sql server -> sql server -> localdb -> banco de dados -> butão direto -> adicionar novo banco de dados

## Instalando
- Microsoft.EntityFrameworkCore.SqlServer versão 3.1.24

## Usando o Entity
### criar o Context
````
using System;
using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp
{
    internal class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        // sobreescrevendo o metodo. metodo de configuração
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // dizendo a minha maquina que quero usar o banco de dados. se caminho server... vem da minha classe dao
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;"); 
        }
    }
}
``````
### Metodo Para adicionar
````
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
 ``````
 
### Metodo para mostrar a lista de nome
````
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

````
### Update Produtos
````
 private static void Atualizar()
        {
            GravarUsandoEntity();
            Recuperar();

            using(var repo = new LojaContext())
            {
                Produto p = repo.Produtos.First();
                p.Nome = "Cassine Royale - Editar";
                repo.Produtos.Update(p);
                repo.SaveChanges();
            }
            Recuperar();
        }
``````

### Excluindo um produto
``````
  private static void excluir()
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
``````
## Organizando o projeto com o DAO
### Criando a interface IProdutoDAO
````
interface IProdutoDAO
    {
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        IList<Produto> Produtos();

    }
``````
* produtoDAO deve implementar essa interface

### Classe ProdutoDaoEntity herdanando produtoDAO
````
  class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext contexto;

        // criando uma instancia
        public ProdutoDAOEntity()
        {
            this.contexto = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            contexto.Produtos.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            contexto.Produtos.Update(p);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return contexto.Produtos.ToList();
        }

        public void Remover(Produto p)
        {
            contexto.Produtos.Remove(p);
            contexto.SaveChanges();
        }

    }
````

* No programa eu vou substituir lojaContext por ProdutoDAOEntity
### Adicionar
````
    private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Books";
            p.Preco = 19.89;

            using (var context = new ProdutoDAOEntity())
            {
                context.Adicionar(p);
            }
        }
````
### Metodo para mostrar a lista de nome
````
   private static void Recuperar()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }
````
### Update Produtos
````
 private static void Atualizar()
        {
            GravarUsandoEntity();
            Recuperar();

            using (var repo = new ProdutoDAOEntity())
            {
                Produto p = repo.Produtos().First();
                p.Nome = "Cassine Royale - Editar";
                repo.Atualizar(p);
            
            }
            Recuperar();
        }
``````

### Excluindo um produto
``````
     private static void excluir()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                foreach (var item in produtos)
                {
                    repo.Remover(item);
                }
                
            }
        }

``````
### Apagei tudo e fiz um novo metodo
* Atualizando o primeiro nome do banco
````
using(var context = new LojaContext())
{
    var products = context.Produtos.ToList();
    foreach(var p in products)
    {
       Console.WriteLine(p);
    }

     var p1 = products.First();
     p1.Nome = "Daniel";
     
      p1 = products.Last();
      p1.Nome = "The Back";

     context.SaveChanges();
     Console.WriteLine("===============");
     products = context.Produtos.ToList();
     foreach (var p in products)
     {
      Console.WriteLine(p);
     }
}
````

* Adicionar o novo produto
````
 // adiciando um novo produto
 var newProduct = new Produto()
  {
     Nome = "Desinfetante",
     Categoria = "limpeza",
     Preco = 2.99
   };
   context.Produtos.Add(newProduct);
   context.SaveChanges();
``````
* Removendo o produto
````
 var p1 = products.First();
 context.Produtos.Remove(p1);
 context.SaveChanges();
 ``````







