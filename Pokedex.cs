using System.Collections.Generic;
using System;
namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<Pokemon> pokemons;
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }
        private void InicializaLista()
        {
            // Intanciar a lista 
            this.pokemons = new List<Pokemon>();
            Pokemon p =  new Pokemon("Bulbasauro", "Sua decricao");
            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Soal decricao");
            this.pokemons.Add(p);
             p = new Pokemon("Bulbasauro", "oal decricao");
            this.pokemons.Add(p);
             p = new Pokemon("Bulbasauro", "laua decricao");
            this.pokemons.Add(p);
             p = new Pokemon("Bulbasauro", "dasdk decricao");
            this.pokemons.Add(p);
             p = new Pokemon("Bulbasauro", "Suadad decricao");
            this.pokemons.Add(p);
             p = new Pokemon("Bulbasauro", "Sua decricao");
            this.pokemons.Add(p);
             p = new Pokemon("Bulbasauro", "Sua decricao");
            this.pokemons.Add(p);
            //inserir 10 pokeons na lista.
        }


        public void ListarPokemons()
        {
            for(int i = 0 ; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[1].ExibirDadosPokemon();
            }
        }
        
    }
}