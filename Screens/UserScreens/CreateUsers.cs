using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.Userscreens
{
    class CreateUser
    {
        public static void Create(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine("Criação de um novo usuário \n  ");
            Console.WriteLine("Itens a serem adicionados obrigatoriamente:");
            Console.WriteLine("Nome, Email, PasswordHash, Bio, Image, Slug");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nome do usuario:");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Email do usuario:");
            var email = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("PassworldHash do usuario:");
            var passwordHash = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("digite a Bio do usuario:");
            var bio = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"digite o endereço da image do usuarioÇ");
            var image = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"digite o slug do usuario:");
            var slug = Console.ReadLine();

            var user = new User()
            {
                Name = name,
                Email = email,
                PasswordHash = passwordHash,
                Bio = bio,
                Image = image,
                Slug = slug
            };

            var repository = new Repository<User>(connection);
            repository.Create(user);

            Console.WriteLine("Usuario criado com sucesso");

            Blog.Screens.Userscreens.UserMenu.Menu(connection);




        }
    }
}