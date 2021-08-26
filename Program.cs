using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp =  100;
            while(resp != 0){
                resp = Menu();
                if(resp ==  1)
                {
                    pokedex.ListarPokemons();
                }
                Console.Clear();
            }
        }
        static int Menu()
        {
            Console.WriteLine("Agenda Pokemon ---------");
            Console.WriteLine("0 - Sair da Pokedex");
            Console.WriteLine("1 - Listar  todos os pokemons");
            Console.Write("O que deseja fazer:");
            int resp =  Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
