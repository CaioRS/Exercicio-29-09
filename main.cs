using System;

class MainClass {
  public static void Main (string[] args) {

    double valor;
    string pend;
    veiculo v1 = new veiculo();
    veiculo v2 = new veiculo(2020 , "Branco", 20000);
    veiculo v3 = new veiculo(4, "preto", 2021 , "SLK", 50000, "sim" , "nao");

    Console.WriteLine("Carro 1 : {0} {1} {2} {3} {4} {5} {6} ", v1.GetRodas(), v1.GetCor(), v1.GetAno(), v1.GetModelo(), v1.GetSeguro(), v1.GetPendencia(), v1.GetValor() );

    Console.WriteLine("Carro 2 : {0} {1} {2} {3} {4} {5} {6} ", v2.GetRodas(), v2.GetCor(), v2.GetAno(), v2.GetModelo(), v2.GetSeguro(), v2.GetPendencia(), v2.GetValor() );

    Console.WriteLine("Carro 3 : {0} {1} {2} {3} {4} {5} {6} ", v3.GetRodas(), v3.GetCor(), v3.GetAno(), v3.GetModelo(), v3.GetSeguro(), v3.GetPendencia(), v3.GetValor() );


    Console.WriteLine("digite o valor do carro 1 : ");
    valor = double.Parse(Console.ReadLine());
    v1.SetValor(valor);

    Console.WriteLine("digite a pendencia do carro 1 : ");
    pend = Console.ReadLine();
    v1.SetPendencia(pend);

    Console.WriteLine("Carro 1 : {0} {1} {2} {3} {4} {5} {6} ", v1.GetRodas(), v1.GetCor(), v1.GetAno(), v1.GetModelo(), v1.GetSeguro(), v1.GetPendencia(), v1.GetValor() );
  }
}