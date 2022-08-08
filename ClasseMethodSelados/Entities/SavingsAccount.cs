
namespace ClasseMethodSelados.Entities
{
    /**
     * 
     *Aqui estou dizendo que a subClasse SavingsAccount
     *não vai ter herença
     *
     **/
    /*sealed*/internal class SavingsAccount : Account
    {
        //atributos
        public double InterestRate { get; set; }

        //construtor
        public SavingsAccount()
        {
        }

        //usando o base() para reaproveitar o construtor da class mãe
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {

            InterestRate = interestRate;

        }

        //method
        public void UpdateBalance()
        {

            Balance += Balance * InterestRate;

        }

        /**
         * 
         * Aqui vou rescrever o method "WithDraw()" para que 
         * a taxa de 5.00 não seja aplicado na SavingsAccount
         * para isso tereri que usar a palavra "override" para 
         * sobrescrever
         * 
         **/
        /*public override void WithDraw(double amount)
        {
            Balance -= amount;
        }*/

        /**
         * 
         * methdos selados só funciona se o method for sobreposto
         * como exemplo aqui em baixo.
         * Estou dizendo que esse method não vai ser sobreposto
         * em nehuma subclasse depois dessa
         * 
         **/
        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);  //aqui estou chamando o method diretamente na superClasse(Classe mãe), um tipo de reaproveitamento
            Balance -= 2.0;

        }

    }
}
