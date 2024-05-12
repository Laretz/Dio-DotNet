/* Em jogos de RPG, é comum haver ações de ataque dos personagens, que causam um certo dano ao inimigo. Este dano pode ser calculado de diferentes formas, dependendo do sistema do jogo.
Neste desafio, você deve criar uma função que calcula o dano de um ataque, levando em consideração o valor do ataque e a defesa do inimigo.

Crie uma função chamada "calcular_dano" que recebe dois parâmetros: "ataque" e "defesa". A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

dano = ataque - defesa

Se o valor do dano for negativo, ele deve ser considerado zero. */

using System;

class Program
{
    static int CalcularDano(int ataque, int defesa)
    {
      
        
        if(ataque - defesa >0 ){
          return ataque-defesa;
        }else {
          return 0;
        }
    }

    static void Main(string[] args)
    {   
        Console.WriteLine("Digite o dano do ataque ");
        int ataque = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a defesa ");
        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}
