using System;
namespace primeiro
{
    public class Estoque
    {
        public string ProductName;
        public double Price;
        public int Amount;
        

        public double valueTotalStock() {
            return Price * Amount;
        }

        public void addProduct(int quant) {
            Amount = Amount +  quant;
        }

        public void removeProduct(int quant) {
            Amount = Amount - quant;

        }

        public override string ToString()
        {
            return $"{ProductName} $ {Price:F2} quantidade {Amount} valor total {valueTotalStock():F2} ";
        }
    }
}
