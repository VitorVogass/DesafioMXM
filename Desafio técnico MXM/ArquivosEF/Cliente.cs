public class Cliente
{
    public string Codigo { get; set; }
    public int CodigoGrupo { get; set; }
    public string Profissao { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataMov { get; set; }
    public string NomeFantasia { get; set; }
    public int InscricaoMunicipal { get; set; }
    public string Exp { get; set; }
    public string Nome { get; set; }
    public string EstadoCivil { get; set; }
    public bool MicroEmpresa { get; set; }
    public DateTime DataInativo { get; set; }
    public string GrupoEmpresarial { get; set; }
    public string ComplementoEndereco { get; set; }
    public DateTime DataExp { get; set; }
    public string TipoPessoa { get; set; }
    public string Endereco { get; set; }
    public string Email { get; set; }
    public int Numendereco { get; set; }
    public string Pais { get; set; }
    public string Endereco1 { get; set; }
    public string Contato { get; set; }
    public DateTime DataNasc { get; set; }
    public string Cidade { get; set; }
    public string Telefone { get; set; }
    public DateTime DataCad { get; set; }
    public int IndicadorIE { get; set; }
    public int CodigoNacionalidade { get; set; }
    public int CodigoPais { get; set; }
    public int TipoEntrega { get; set; }
    public int Cgc { get; set; }
    public DateTime DataAlt { get; set; }
    public string Uf { get; set; }
    public string Cep { get; set; }
    public string Bairro { get; set; }
    public string RazaoSocialCompleta { get; set; }
    public DateTime DataAbertura { get; set; }
    public virtual CNAE CNAEPrincipal { get; set; }
    public virtual NaturezaJuridica NaturezaJuridica { get; set; }
    public virtual SituacaoCadastral SituacaoCadastral { get; set; }
    public virtual SituacaoEspecial SituacaoEspecial { get; set; }
    public virtual PorteEmpresarial PorteEmpresarial { get; set; }
}
