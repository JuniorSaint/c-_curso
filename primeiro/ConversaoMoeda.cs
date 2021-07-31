using System;
namespace primeiro
{
    public class ConversaoMoeda
    {
        public double CotacaoMoeda, CompraDolar, ValorReal;

        public double ConversaoMoedaP() {

            return (CotacaoMoeda * CompraDolar) * 0.06 + (CotacaoMoeda * CompraDolar);
        }

        public override string ToString()
        {
            return $"valor da cotação {CotacaoMoeda:f2}, valor requerido em dólar {CompraDolar:f2}, valor a ser pago {ConversaoMoedaP():f2}";        }
    }
}
