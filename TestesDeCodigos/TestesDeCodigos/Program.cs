namespace TestesDeCodigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro myCar = new Carro();
            Console.WriteLine("Vamos acelerar o carro");
            myCar.Acelera();
            Veiculo meuVeiculo = myCar;
            Console.WriteLine("Vamos acelerar o veiculos");
            meuVeiculo.Acelera();

            Console.WriteLine("Vamos acelerar o carro que virou caminhonete!");
            Caminhonete caminhonete = meuVeiculo as Caminhonete;
            caminhonete.Acelera();



        }
    }


    public class Veiculo
    {
        public virtual void Acelera()
        {
            Console.WriteLine("Acelerando");
        }
    }

    public class Carro : Veiculo
    {
        public override void Acelera()
        {
            Console.WriteLine("Acelera Muito rapido");
        }
    }

    public class Caminhonete : Veiculo
    {
        public override void Acelera()
        {
            Console.WriteLine("Acelera devagar!");
        }
    }


}