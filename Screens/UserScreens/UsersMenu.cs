using System;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.Userscreens
{
    public class UserMenu
    {
        public static void Menu(SqlConnection connection)
        {
            //texto do menu do usuario
            Console.Clear();
            Console.WriteLine("Menu de usuarios o que deseja fazer:");
            Console.WriteLine("1 - Pesquizar todos os usuarios do banco \n");
            Console.WriteLine("2 - Pesquizar somente um usuario do banco \n");
            Console.WriteLine("3 - Criar novo usuario \n");
            Console.WriteLine("4 - Atualizar usuario \n");
            Console.WriteLine("5 - Deletar usuario \n");
            Console.WriteLine("6 - Vincular um usuario a um Perfil \n");
            Console.WriteLine("9 - Retornar ao Menu anterior \n");

            Console.WriteLine($"0 - sair \n");
            var opc = Console.ReadLine();

            //elementos de escolha do menu de usuarios

            switch (opc)
            {
                case "1": Blog.Screens.Userscreens.ReadUsers.ReadAll(connection); break;
                case "2": Blog.Screens.Userscreens.ReadUser.Read(connection); break;
                case "3": Blog.Screens.Userscreens.CreateUser.Create(connection); break;
                case "4": Blog.Screens.Userscreens.UpdateUser.Update(connection); break;
                case "5": Blog.Screens.Userscreens.DeleteUser.MenuDelete(connection); break;
                case "6": Blog.Screens.Userscreens.UserLink.Link(connection); break;
                case "9": Blog.Program.MenuPrincipal(connection); break;
                case "0": Console.Clear(); Environment.Exit(0); break;
                default: Menu(connection); break;
            }
        }
    }
}