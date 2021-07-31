using System;
namespace primeiro
{
    public class NovoMetodo
    {

        private string _nome;
        private double _preco; 
        private int _quantidade;

        public NovoMetodo(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get {
                return _nome;
                    }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
            
        }
        public double Preco { get => _preco; set => _preco = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
    }
}
