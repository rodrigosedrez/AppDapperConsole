using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    class ReadRole
    {
        public static void Read(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine("Digite a baixo o ID  do Perfil a ser Pesquisado: /n");

            var user = Console.ReadLine();

            int iduser = int.Parse(user);

            var repository = new Repository<User>(connection);
            var elementos = repository.Get(iduser);
            Console.WriteLine($@"
                 Id:{elementos.id},
                 Name:{elementos.Name},
                 Slug:{elementos.Slug} ");



            Console.ReadLine();
            Blog.Screens.RolesMenu.Menu(connection);
        }
    }
}