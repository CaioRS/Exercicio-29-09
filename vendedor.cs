class vendedor{

double salario;
double comissao;

  public vendedor(double s , double c){
    salario = s;
    comissao = c;
  }

  public double receber(double valor){
    return salario + (comissao*valor);
  }
}