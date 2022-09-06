using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    class CreateRole
    {
        public static void Create(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine("Criação de um novo perfil \n  ");
            Console.WriteLine("Itens a serem adicionados obrigatoriamente: \n");
            Console.WriteLine("Nome, Email, PasswordHash, Bio, Image, Slug /n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nome do Perfil:");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"digite o slug do usuario: /n");
            var slug = Console.ReadLine();

            var user = new User()
            {
                Name = name,
                Slug = slug
            };

            var repository = new Repository<User>(connection);
            repository.Create(user);

            Console.WriteLine("Perfil criado com sucesso");

            Blog.Screens.RolesMenu.Menu(connection);

        }
    }
}