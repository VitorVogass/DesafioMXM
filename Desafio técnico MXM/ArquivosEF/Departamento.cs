public class Departamento
{
    public string Codigo { get; set; }
    public string Nome { get; set; }
    public virtual Empresa Empresa { get; set; }
}
