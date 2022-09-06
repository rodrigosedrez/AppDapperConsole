using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.Userscreens
{
    class ReadUser
    {
        public static void Read(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine($"Digite a baixo o ID  de usuario a ser Pesquisado: /n");

            var user = Console.ReadLine();

            int iduser = int.Parse(user);

            var repository = new Repository<User>(connection);
            var elementos = repository.Get(iduser);
            Console.WriteLine($@"
                 Id:{elementos.id},
                 Name:{elementos.Name},
                 Email:{elementos.Email},
                 PasswordHash:{elementos.PasswordHash},
                 Bio:{elementos.Bio},
                 Image:{elementos.Image},
                 Slug:{elementos.Slug} ");



            Console.ReadLine();
            Blog.Screens.Userscreens.UserMenu.Menu(connection);
        }
    }
}