using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    class ReadTags
    {
        public static void ReadAll(SqlConnection connection)
        {
            Console.Clear();
            var repository = new Repository<Tag>(connection);
            var elementos = repository.GetAll();
            foreach (var usuario in elementos)
                Console.WriteLine($"ID: {usuario.id}, Nome:{usuario.Name}");

            Console.ReadLine();
            //Blog.Screens.UserMenu.Menu(connection);
        }
    }
}