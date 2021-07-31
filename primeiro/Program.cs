using System;
using System.Globalization;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            //ConversaoMoeda x = new ConversaoMoeda();

            //Retangulo x;
            //x = new Retangulo();
            //Triangulo x, y;
            //Pessoa carlos, ana;
            //carlos = new Pessoa();
            //ana = new Pessoa();
            //Aluno x;

            //x = new Aluno();

            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X ");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do Triângulo Y");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //double areaX = x.CalcTriangle();
            //double areaY = y.CalcTriangle();

            //Console.WriteLine("valor de X =  " + areaX);
            //Console.WriteLine("valor de y = " + areaY);

            //if (areaX > areaY)
            //{
            //    Console.WriteLine($"a área de X:  {areaX:F3} é maior que de y {areaY:F3}");
            //}
            //else
            //{
            //    Console.WriteLine($"a área de y:  {areaY:F3} é maior que de x {areaX:F3}");
            //}

            //Console.Write("Digite o valor Largura");
            //x.width = double.Parse(Console.ReadLine());
            //Console.Write("Digite a altura");
            //x.height = double.Parse(Console.ReadLine());


            //Console.WriteLine(x);

            //Console.Write("digite o nome do aluno");
            //x.NomeAluno = Console.ReadLine();
            //Console.WriteLine("digte nota 1");
            //x.nota1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("digte nota 2");
            //x.nota2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("digte nota 3");
            //x.nota3 = double.Parse(Console.ReadLine());

            //Console.WriteLine(x.Resultado());

            //Console.Write("digite a cotação do dólar: ");
            //x.CotacaoMoeda = double.Parse( Console.ReadLine());
            //Console.Write("Quantos dólares deseja?  ");
            //x.CompraDolar = double.Parse( Console.ReadLine());

            //Console.WriteLine(x);

            //NovoMetodo fd = new NovoMetodo("TV", 500.0, 5 );

            //fd.Nome = "TV Novo";


            //Console.WriteLine(fd.Nome);

            //ContaBancaria cb;
            //double valorMov;

            //Console.Write("Digite o nome do titular ");
            //string titular = Console.ReadLine();
            //Console.Write("Digite o número da conta ");
            //int conta = int.Parse(Console.ReadLine());
            //Console.Write("Digite D para deposito ou S para saque");
            //char D = char.Parse(Console.ReadLine());
            //if (D == 'D' || D == 'd')
            //{
            //    Console.Write("Digite o valor do deposito ");
            //     valorMov = double.Parse(Console.ReadLine());
            //}
            //else {
            //    Console.Write("Digite o valor do Saque ");
            //     valorMov = -1 * (double.Parse(Console.ReadLine()));
            //}
            //Console.Write("Tem saldo inicial ");
            //char x = char.Parse(Console.ReadLine());
            //if (x == 's' || x == 'S')
            //{
            //    Console.Write("Digite o Saldo Inicial ");
            //    double saldo = double.Parse(Console.ReadLine());
            //    cb = new ContaBancaria(conta, titular, saldo, valorMov);
            //}
            //else {

            //     cb = new ContaBancaria(conta, titular, valorMov);
            //}

            DateTime d1 = DateTime.Now;



            string teste = "Olha nós ai   ";

           string tes =  teste.ToUpper();
            string yrd1 = teste.ToLower();
            string test = teste.ToLower().Trim();


           

          DateTime d2 =  d1.AddDays(5);
            DateTime d3 = d2.AddYears(1);  
            Console.WriteLine(d1); Console.WriteLine(d2); Console.WriteLine(d3);

        }
    }
}
