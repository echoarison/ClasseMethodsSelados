

namespace ClasseMethodSelados.Entities
{
    /**
     * 
     * classe para testar o termo "sealed"
     * o motivo de usar classes seladas ou methods selados
     * para o sistema não necessitar analisar todas as subClasses
     * pois vai ententer que a classe selada ela não vai ser 
     * herdada ou method não vai ser sobreescrever
     * 
     **/
    internal class SavingsAccountPlus : SavingsAccount
    {
        /*public override void Withdraw(double amount) 
        {

            Balance -= amount + 1.0;

        }*/
    }
}
