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

















}