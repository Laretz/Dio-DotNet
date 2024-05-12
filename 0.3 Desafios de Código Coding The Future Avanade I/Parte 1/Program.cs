using System;

/* Regras do saque:

- Cada cliente digitará o valor do seu saldoTotal de sua conta bancária e o valorSaque.
- Um saque só pode ser realizado se o saldoDisponível na conta for igual ou superior ao valor solicitado.
- Se o saldo for suficiente, o valor solicitado deve ser subtraído do saldo disponível, indicando que o saque foi realizado.
- Se o saldo for insuficiente, o saque não deve ser realizado e uma mensagem adequada deve ser exibida.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Qual saldo da sua conta? ");
        int saldoTotal = int.Parse(Console.ReadLine());
        
         Console.WriteLine($"Qual valor que deseja sacar? ");
        int valorSaque = int.Parse(Console.ReadLine());
        
       if (saldoTotal >= valorSaque){
         saldoTotal = saldoTotal - valorSaque;
         Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoTotal} ");
         
       }else{
         Console.WriteLine($"Saldo insuficiente. Saque nao realizado!");
       }
    }
}