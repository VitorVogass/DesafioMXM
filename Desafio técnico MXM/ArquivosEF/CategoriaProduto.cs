public class CategoriaProduto
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public virtual Departamento Departamento { get; set; }
}
