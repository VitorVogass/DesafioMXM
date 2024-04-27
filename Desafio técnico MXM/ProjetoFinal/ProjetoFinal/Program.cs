using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class ConversorXMLParaEntidade
{
    static string diretorioEntrada = @"C:\Users\vitor\OneDrive\Área de Trabalho\Desafio técnico MXM\ProjetoFinal\ProjetoFinal\ArquivosXml";
    static string diretorioSaida = @"C:\Users\vitor\OneDrive\Área de Trabalho\Desafio técnico MXM\ArquivosEF";

    static void Main(string[] args)
    {
        Principal();
    }

    public static void Principal()
    {
        foreach (var arquivo in Directory.GetFiles(diretorioEntrada, "*.hbm.xml"))
        {
            XElement raiz = XElement.Load(arquivo);
            Entidade entidade = ParseXmlParaEntidade(raiz);
            string codigoEntidade = GerarClasseEntidade(entidade, raiz);
            SalvarEmArquivo(codigoEntidade, entidade.NomeDaClasse);
        }
        Console.WriteLine("######################################################################################");
        Console.WriteLine("                                                                                      ");
        Console.WriteLine("                             CONVERSÃO CONCLUÍDA!                                     ");
        Console.WriteLine("Seus aquivos hbm.xml foram convertidos para C# e estão prontos para serem usados no EF");
        Console.WriteLine("                                                                                      ");
        Console.WriteLine("######################################################################################");
        Thread.Sleep(3000);
        Console.Clear();
    }

    static Entidade ParseXmlParaEntidade(XElement raiz)
    {
        XNamespace ns = "urn:nhibernate-mapping-2.2";
        Entidade entidade = new Entidade
        {
            NomeDaClasse = raiz.Element(ns + "class")?.Attribute("name")?.Value,
            NomeDaTabela = raiz.Element(ns + "class")?.Attribute("table")?.Value,
            Id = ExtrairId(raiz, ns),
            Propriedades = raiz.Descendants(ns + "property").Select(p => new Propriedade
            {
                NomeDaPropriedade = p.Attribute("name").Value,
                NomeDaColuna = p.Attribute("column").Value,
                Tipo = MapearTipo(p.Attribute("type")?.Value)
            }).ToList(),
            Relacionamentos = raiz.Descendants(ns + "many-to-one").Select(r => new Relacionamento
            {
                NomeDaPropriedade = r.Attribute("name").Value,
                NomeDaClasse = r.Attribute("class").Value.Split('.').Last(),
                NomeDaColuna = r.Attribute("column").Value
            }).ToList(),
            Colecoes = raiz.Descendants(ns + "bag").Select(b => new Coleção
            {
                NomeDaPropriedade = b.Attribute("name").Value,
                NomeDaClasse = b.Element(ns + "one-to-many").Attribute("class").Value.Split('.').Last()
            }).ToList()
        };

        return entidade;
    }

    static Propriedade ExtrairId(XElement raiz, XNamespace ns)
    {
        XElement elementoCompositeId = raiz.Element(ns + "class")?.Element(ns + "composite-id");
        if (elementoCompositeId != null)
        {
            var propriedadesChave = elementoCompositeId.Descendants(ns + "key-property").ToList();
            if (propriedadesChave.Count == 2)
            {
                var propriedade1 = new Propriedade
                {
                    NomeDaPropriedade = propriedadesChave[0].Attribute("name")?.Value,
                    NomeDaColuna = propriedadesChave[0].Attribute("column")?.Value,
                    Tipo = MapearTipo(propriedadesChave[0].Attribute("type")?.Value)
                };
                var propriedade2 = new Propriedade
                {
                    NomeDaPropriedade = propriedadesChave[1].Attribute("name")?.Value,
                    NomeDaColuna = propriedadesChave[1].Attribute("column")?.Value,
                    Tipo = MapearTipo(propriedadesChave[1].Attribute("type")?.Value)
                };

                return new Propriedade
                {
                    NomeDaPropriedade = $"{propriedade1.NomeDaPropriedade}_{propriedade2.NomeDaPropriedade}",
                    NomeDaColuna = $"{propriedade1.NomeDaColuna}_{propriedade2.NomeDaColuna}",
                    Tipo = $"{propriedade1.Tipo}_{propriedade2.Tipo}"
                };
            }
        }

        XElement elementoId = raiz.Element(ns + "class")?.Element(ns + "id");
        if (elementoId != null)
        {
            return new Propriedade
            {
                NomeDaPropriedade = elementoId.Attribute("name")?.Value,
                NomeDaColuna = elementoId.Attribute("column")?.Value,
                Tipo = MapearTipo(elementoId.Element(ns + "generator")?.Attribute("class")?.Value ?? "string")
            };
        }

        throw new Exception("Elemento ID não encontrado no XML de mapeamento do NHibernate.");
    }

    static string GerarClasseEntidade(Entidade entidade, XElement raiz)
    {
        string codigo = $"public class {entidade.NomeDaClasse}\n{{\n";

        if (entidade.Id != null)
        {
            codigo += $"    public {entidade.Id.Tipo} {entidade.Id.NomeDaPropriedade} {{ get; set; }}\n";
        }

        foreach (var propriedade in entidade.Propriedades)
        {
            codigo += $"    public {propriedade.Tipo} {propriedade.NomeDaPropriedade} {{ get; set; }}\n";
        }

        foreach (var relacionamento in entidade.Relacionamentos)
        {
            codigo += $"    public virtual {relacionamento.NomeDaClasse} {relacionamento.NomeDaPropriedade} {{ get; set; }}\n";
        }

        foreach (var colecao in entidade.Colecoes)
        {
            codigo += $"    public virtual ICollection<{colecao.NomeDaClasse}> {colecao.NomeDaPropriedade} {{ get; set; }} = new List<{colecao.NomeDaClasse}>();\n";
        }

        codigo += "}\n";
        return codigo;
    }

    static void SalvarEmArquivo(string codigo, string nomeDaClasse)
    {
        File.WriteAllText(Path.Combine(diretorioSaida, $"{nomeDaClasse}.cs"), codigo);
    }

    static string MapearTipo(string tipoHibernate)
    {
        return tipoHibernate switch
        {
            "string" => "string",
            "boolean" => "bool",
            "text" => "string",
            "varchar" => "string",
            "nvarchar" => "string",
            "char" => "string",
            "character" => "string",
            "nchar" => "string",
            "integer" => "int",
            "bigint" => "long",
            "decimal" => "decimal",
            "double" => "double",
            "float" => "float",
            "date" => "DateTime",
            "datetime" => "DateTime",
            "timestamp" => "DateTime",
            "calendar_date" => "DateTime",
            "time" => "TimeSpan",
            "money" => "decimal",
            _ => "dynamic"
        };
    }
}
public class Entidade
        {
            public string NomeDaClasse { get; set; }
            public string NomeDaTabela { get; set; }
            public Propriedade Id { get; set; }
            public List<Propriedade> Propriedades { get; set; } = new List<Propriedade>();
            public List<Relacionamento> Relacionamentos { get; set; } = new List<Relacionamento>();
            public List<Coleção> Colecoes { get; set; } = new List<Coleção>();
        }

        public class Propriedade
        {
            public string NomeDaPropriedade { get; set; }
            public string NomeDaColuna { get; set; }
            public string Tipo { get; set; }
        }

        public class Relacionamento
        {
            public string NomeDaPropriedade { get; set; }
            public string NomeDaClasse { get; set; }
            public string NomeDaColuna { get; set; }
        }

        public class Coleção
        {
            public string NomeDaPropriedade { get; set; }
            public string NomeDaClasse { get; set; }
        }