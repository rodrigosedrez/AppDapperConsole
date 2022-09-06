using System;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    public class CategoryMenu
    {
        public static void Menu(SqlConnection connection)
        {
            //texto do menu do usuario
            Console.Clear();
            Console.WriteLine("Menu de Category o que deseja fazer:");
            Console.WriteLine("1 - Pesquizar todos as categorys do banco \n");
            Console.WriteLine("2 - Pesquizar somente uma category do banco \n");
            Console.WriteLine("3 - Criar nova category \n");
            Console.WriteLine("4 - Atualizar uma category \n");
            Console.WriteLine("5 - Deletar category \n");
            Console.WriteLine("9 - Retornar ao Menu anterior \n");

            Console.WriteLine($"0 - sair \n");
            var opc = Console.ReadLine();

            //elementos de escolha do menu de usuarios

            switch (opc)
            {
                // case "1": Blog.Screens.ReadUsers.ReadAll(connection); break;
                // case "2": Blog.Screens.ReadUser.Read(connection); break;
                // case "3": Blog.Screens.CreateUser.Create(connection); break;
                case "9": Blog.Program.MenuPrincipal(connection); break;
                case "0": Console.Clear(); Environment.Exit(0); break;
                default: Menu(connection); break;
            }

        }

    }
}