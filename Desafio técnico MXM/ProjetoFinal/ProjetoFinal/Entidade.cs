public class Entidade
{
    public string NomeDaClasse { get; set; }
    public string NomeDaTabela { get; set; }
    public Propriedade Id { get; set; }
    public List<Propriedade> Propriedades { get; set; } = new List<Propriedade>();
    public List<Relacionamento> Relacionamentos { get; set; } = new List<Relacionamento>();
    public List<Coleção> Colecoes { get; set; } = new List<Coleção>();
}
