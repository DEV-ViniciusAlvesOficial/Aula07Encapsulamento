using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
           Cartao cartao = new Cartao();
           cartao.AprovarCompra();

           Mastercard mastercard = new Mastercard();
           mastercard.parcelas = 12;
           mastercard.ComprarComDescontoMastercard(30f); 

        }


    }
}
