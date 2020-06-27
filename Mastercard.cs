namespace Aula07Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }
	    public void ComprarComDescontoMastercard(float desconto){ //Void não precisa de retorno /Float = Números decimais
            System.Console.WriteLine($"Compra realizada com {parcelas} parcelas e {desconto} de desconto");
        }
    }
}