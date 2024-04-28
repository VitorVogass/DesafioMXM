public class Fornecedor
{
    public string Codigo { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string TipoPessoa { get; set; }
    public string Bairro { get; set; }
    public int Telefone { get; set; }
    public int IncricaoEstadual { get; set; }
    public int Contato { get; set; }
    public string EnderecoAdcional { get; set; }
    public int CodigoContaContabil { get; set; }
    public int CodigoGrupoCotacao { get; set; }
    public bool DataMovimentacao { get; set; }
    public DateTime DataManutencaoCadastro { get; set; }
    public DateTime DataNascimento { get; set; }
    public int CodigoBairro { get; set; }
    public string NomeFantasia { get; set; }
    public bool Ativo { get; set; }
    public string ResponsavelCadastro { get; set; }
    public bool StatusHomologacao { get; set; }
    public string ResponsavelHomologacao { get; set; }
    public DateTime DataHomologacao { get; set; }
    public int QuantidadeDependentes { get; set; }
    public string DescricaoPais { get; set; }
    public int IncricaoINSS { get; set; }
    public int ClasseINSS { get; set; }
    public int TetoMaximo { get; set; }
    public string Email { get; set; }
    public int IndicadorIE { get; set; }
    public bool UtilizaInterface { get; set; }
    public int IncricaoMunicipal { get; set; }
    public string TipoCobranca { get; set; }
    public decimal SalarioContribuicao { get; set; }
    public int PISPASEP { get; set; }
    public string MotivoInatividade { get; set; }
    public DateTime DataInatividade { get; set; }
    public bool UsuarioAlteracao { get; set; }
    public string Cooperativa { get; set; }
    public string EstadoCivil { get; set; }
    public int NumeroEndereco { get; set; }
    public int ComplementoEndereco { get; set; }
    public int Cidade { get; set; }
    public int RazaoSocialCompleta { get; set; }
    public DateTime DataAbertura { get; set; }
    public string TipoIsencaoImunidade { get; set; }
    public virtual CodigoBrasileiroOcupacao SequenciaCodigoBrasileiroOcupacao { get; set; }
    public virtual GrupoEmpresarial GrupoEmpresarial { get; set; }
    public virtual CEP CEP { get; set; }
    public virtual UFICMS UF { get; set; }
    public virtual Pais Pais { get; set; }
    public virtual CategoriaTrabalhador CategoriaTrabalhador { get; set; }
    public virtual Nacionalidade NAC { get; set; }
    public virtual CNAE CNAEPrincipal { get; set; }
    public virtual NaturezaJuridica NaturezaJuridica { get; set; }
}
