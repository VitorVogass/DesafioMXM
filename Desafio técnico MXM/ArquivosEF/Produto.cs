public class Produto
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public int Unidade { get; set; }
    public decimal ValorVenda { get; set; }
    public int Estoque { get; set; }
    public bool Ativo { get; set; }
    public virtual CategoriaProduto Categoria { get; set; }
    public virtual Fornecedor Fornecedor { get; set; }
}
