public class Empresa
{
    public string Codigo { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string UnidadeFederativa { get; set; }
    public string CEP { get; set; }
    public string TEL { get; set; }
    public int InscricaoEstadual { get; set; }
    public int NumeroLancamentoContabil { get; set; }
    public string Contador { get; set; }
    public decimal PercentualISS { get; set; }
    public int IPI { get; set; }
    public int Industrial { get; set; }
    public decimal MoedaCorrente { get; set; }
    public string TOTPagImp { get; set; }
    public string TipoNegocio { get; set; }
    public string NumeroRegistro { get; set; }
    public string NomeResponsavel { get; set; }
    public string CargoResposavel { get; set; }
    public int CPFResponsavel { get; set; }
    public dynamic IncricaoMunicipal { get; set; }
    public dynamic CDCidade { get; set; }
    public virtual PlanoCentroCustos CodigoCentroCustos { get; set; }
    public virtual PlanoFluxoCaixa CODFluxoCaixa { get; set; }
    public virtual PlanoDeContasOrcamentario CodigoPlanoOrcamento { get; set; }
    public virtual Moeda SegundaMoedaEmpresa { get; set; }
    public virtual ICollection<GestorOrcamentario> GestorOrcamentarioList { get; set; } = new List<GestorOrcamentario>();
}
