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
 
### Metodo para adicionar
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

## Fazendo o acesso aos dados com o entity
- Primeiro passo criar uma Interface
### classe produtoDAO
````
 interface IProdutoDAO
    {
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        IList<Produto> Produto(Produto p);

    }
``````
- agora minha classe produtoDao deve implementar de IProductDAO
- criar uma classe para implementar o IProduto com o entity
