namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
	    public string bandeira { get; set; }
	    private string token = "qawje891q23u";
	    protected int cvc { get; set; }

         public string AprovarCompra(){
             return "Compra aprovada";
         }
	     private bool ValidarToken(){
             if(token != null){
             return true;
             }
             else{
             return false;    
             }

         }
	     protected bool ValidarCompra(){
             return true;
         }

    }
}