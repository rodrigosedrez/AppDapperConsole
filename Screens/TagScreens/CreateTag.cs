using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    class CreateTag
    {
        public static void Create(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine("Criação de uma nova Tag \n  ");
            Console.WriteLine("Itens a serem adicionados obrigatoriamente: \n");
            Console.WriteLine("Nome, Slug /n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nome da Tag:");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"digite o slug da Tag: /n");
            var slug = Console.ReadLine();

            var tag = new Tag()
            {
                Name = name,
                Slug = slug
            };

            var repository = new Repository<Tag>(connection);
            repository.Create(tag);

            Console.WriteLine("Tag criada com sucesso");

            Blog.Screens.TagMenu.Menu(connection);

        }
    }
}