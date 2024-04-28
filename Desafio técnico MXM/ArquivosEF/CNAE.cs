public class CNAE
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public int Secao { get; set; }
    public int Divisao { get; set; }
    public string Grupo { get; set; }
    public string Classe { get; set; }
    public string Subclasse { get; set; }
    public virtual Empresa EmpresaPrincipal { get; set; }
    public virtual Empresa EmpresaSecundaria { get; set; }
    public virtual Fornecedor FornecedorPrincipal { get; set; }
    public virtual Fornecedor FornecedorSecundaria { get; set; }
}
