using System;

class veiculo{

private int rodas;
private string cor;
private int ano;
private string modelo;
private double valor;
private string seguro;
private string pendencia;

public veiculo(){
  rodas = 0;
  cor = "Sem Cor";
  ano = 0;
  modelo = "Nenhum";
  valor = 0;
  seguro = "Não informado";
  pendencia = "Nao informado"; 
}

public veiculo(int a, string c , double v){
  rodas = 0;
  cor = c;
  ano = a;
  modelo = "Nenhum";
  valor = v;
  seguro = "Não informado";
  pendencia = "Nao informado"; 
}

public veiculo(int r, string c , int a, string m, double v , string s, string p){
  rodas = r ;
  cor = c;
  ano = a;
  modelo = m;
  valor = v;
  seguro = s;
  pendencia = p; 
}

public void SetValor(double v){
 valor = v;
}
public void SetPendencia(string p){
  pendencia = p;
}

public int GetRodas(){
  return rodas;
}
public string GetCor(){
  return cor;
}
public int GetAno(){
  return ano;
}
public string GetModelo(){
  return modelo;
}
public string GetSeguro(){
  return seguro;
}
public string GetPendencia(){
  return pendencia;
}
public double GetValor(){
  return valor;
}


// método Relatório

public double Atualiza(int novoano){
  valor = valor - (novoano - ano)*2.05;  
  return valor;
}

public void relatorio2(){

  Console.WriteLine("Carro 3 : Rodas:{0} \n Cor :{1} \n Ano: {2} \n Modelo: {3} \n seguro: {4} \n Pendencia: {5} \n Valor: R$ {6} ", rodas, cor,ano,modelo, seguro, pendencia, valor);
}

}