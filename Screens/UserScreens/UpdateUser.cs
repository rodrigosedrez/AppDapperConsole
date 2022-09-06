using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.Userscreens
{
    class UpdateUser
    {

        public static void Update(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine($"Qual o Id do usuario que vc deseja fazer as modificações: \n");

            int usuario = int.Parse(Console.ReadLine());
            var repository = new Repository<User>(connection);
            var elementos = repository.Get(usuario); // pega os elementos do banco a partir do usuario digitado

            Console.WriteLine("Selecione os itens do menu separados apenas por espaço");
            Console.WriteLine("Nome    Email   Pass    Bio   Image   Slug");
            string quest = Console.ReadLine().ToLower();
            string[] newquest = new string[] { "" };
            newquest = quest.Split(' ', ',');

            var user = new User()
            {
                id = usuario,
                Name = elementos.Name,
                Email = elementos.Email,
                PasswordHash = elementos.PasswordHash,
                Bio = elementos.Bio,
                Image = elementos.Image,
                Slug = elementos.Slug,
            };

            if (Array.Exists(newquest, x => x == "nome"))
            {
                Console.Clear();
                Console.WriteLine("Digite o novo Nome:");
                var name = Console.ReadLine();
                user.Name = name;
            }

            if (Array.Exists(newquest, x => x == "email"))
            {
                Console.Clear();
                Console.WriteLine("Digite o novo Email :");
                var email = Console.ReadLine();
                user.Email = email;
            }
            if (Array.Exists(newquest, x => x == "pass"))
            {
                Console.Clear();
                Console.WriteLine("Digite a nova Passawordhash:");
                var pass = Console.ReadLine();
                user.PasswordHash = pass;
            }
            if (Array.Exists(newquest, x => x == "bio"))
            {
                Console.Clear();
                Console.WriteLine("Digite a nova Bio:");
                var bio = Console.ReadLine();
                user.Bio = bio;
            }
            if (Array.Exists(newquest, x => x == "image"))
            {
                Console.Clear();
                Console.WriteLine("Digite o endreço da nova Imagem: ");
                var image = Console.ReadLine();
                user.Image = image;
            }

            if (Array.Exists(newquest, x => x == "slug"))
            {
                Console.Clear();
                Console.WriteLine("Digite o novo Slug:");
                var slug = Console.ReadLine();
                user.Slug = slug;
            }
            if (Array.Exists(newquest, x => x == "tudo"))
                newquest = new string[] { "nome", "email", "pass", "bio", "image", "slug" };

            if (Array.Exists(newquest, x => x == "all"))
                newquest = new string[] { "nome", "email", "pass", "bio", "image", "slug" };

            var novouser = user;
            repository.Update(novouser);


            Console.Clear();
            Console.WriteLine("Atualizado com sucesso");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("1 - Para nova entrada \n");
            Console.WriteLine("2 - Para retornar ao menu anterior \n");
            var last = Console.ReadLine();
            switch (last)
            {
                case "1": Blog.Screens.Userscreens.UpdateUser.Update(connection); break;
                case "2": Blog.Screens.Userscreens.UserMenu.Menu(connection); break;
            }
        }
    }










}
