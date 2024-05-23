using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0._8_.NET.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }

          public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
            
        }
        private string _nome;
        private int _idade;

        // A propriedade Nome agora armazena e retorna o valor exatamente como fornecido
        public string Nome 
        { 
            get => _nome; // Retorna o nome como está armazenado
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value.Trim(); // Adiciona um Trim() para remover espaços em branco desnecessários
            }
        }

         public string Sobrenome {get; set;}

         public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, e minha idade é {Idade} anos."); // Use a variável de campo diretamente
        }
    }
}