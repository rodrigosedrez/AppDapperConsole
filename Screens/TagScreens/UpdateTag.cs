using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    class UpdateTag
    {

        public static void Update(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine($"Qual o id da Tag que vc deseja fazer as modificações:");

            int usuario = int.Parse(Console.ReadLine());
            var repository = new Repository<Tag>(connection);
            var elementos = repository.Get(usuario); // pega os elementos do banco a partir do usuario digitado
            Console.WriteLine("Selecione os itens do menu separados apenas por espaço");
            Console.WriteLine("Nome   Slug   Tudo");
            string quest = Console.ReadLine().ToLower();
            string[] newquest = new string[] { "" };
            newquest = quest.Split(' ');

            var tag = new Tag()
            {
                id = usuario,
                Name = elementos.Name,
                Slug = elementos.Slug,
            };

            if (Array.Exists(newquest, x => x == "nome"))
            {
                Console.Clear();
                Console.WriteLine($"digite o novo nome:");
                var name = Console.ReadLine();
                tag.Name = name;
            }

            if (Array.Exists(newquest, x => x == "slug"))
            {
                Console.Clear();
                Console.WriteLine($"digite o novo slug:");
                var slug = Console.ReadLine();
                tag.Slug = slug;
            }
            if (Array.Exists(newquest, x => x == "tudo"))
                newquest = new string[] { "nome", "slug" };

            if (Array.Exists(newquest, x => x == "all"))
                newquest = new string[] { "nome", "slug" };

            var novouser = tag;
            repository.Update(novouser);


            Console.Clear();
            Console.WriteLine($"atualizado com sucesso");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"1 - Para nova entrada \n");
            Console.WriteLine($"2 - Para retornar ao menu anterior \n");
            var last = Console.ReadLine();
            switch (last)
            {
                case "1": Blog.Screens.UpdateTag.Update(connection); break;
                case "2": Blog.Screens.TagMenu.Menu(connection); break;
            }
        }
    }
}
