using System;
namespace pooPokemonApp
{
    public class Pokemon
    {
        public Pokemon ()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        public Pokemon (string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        //antes de pegar o nome alterei o valor recebido
        private string nome;
        public string Nome
        {
            get { 
                return this.nome; 
                }
            set { 
                string texto = value.ToUpper();
                nome = texto; 
                }
        }
        private string descricao; // armazena o valor da propriedade da descricao

        // representa a caracteristicad do pokemon
        public string Descricao        
        {
            get { 
                return this.descricao; 
                }
            set { 
                descricao = value.ToUpper(); 
                }
        }
        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon:" + this.Nome);
            Console.WriteLine("Descrição Pokemon:" + this.Descricao);
        }
        public void ExibirDadosPokemon(bool formatado)
        {
            if(formatado == true){
                Console.WriteLine("Pokemon:" + this.Nome +  " " + this.Descricao.ToLower());
            }
            else{
            Console.WriteLine("Nome do Pokemon:" + this.Nome);
            Console.WriteLine("Descrição Pokemon:" + this.Descricao);
            }
            
        }
    }
}