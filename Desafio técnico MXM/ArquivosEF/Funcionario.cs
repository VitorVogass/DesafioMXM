public class Funcionario
{
    public string Matricula { get; set; }
    public string Nome { get; set; }
    public decimal Salario { get; set; }
    public dynamic DataAdmissao { get; set; }
    public string Cargo { get; set; }
    public virtual Departamento Departamento { get; set; }
}
