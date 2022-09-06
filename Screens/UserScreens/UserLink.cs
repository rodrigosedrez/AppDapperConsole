using System;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.Userscreens
{
    class UserLink
    {
        public static void Link(SqlConnection connection)
        {
            Console.Clear();
            var repository = new UserRepository(connection);
            var elementos = repository.GetWithRoles();


            foreach (var usuario in elementos)
                Console.WriteLine($"ID: {usuario.id}, Nome:{usuario.Name}, Role: {usuario.Roles}");



            Console.ReadLine();
            Blog.Screens.Userscreens.UserMenu.Menu(connection);
        }
    }
}