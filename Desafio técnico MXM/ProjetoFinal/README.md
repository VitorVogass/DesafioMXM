# Conversor de XML para Entidade

Este é um programa simples em C# que converte arquivos XML de mapeamento NHibernate (`.hbm.xml`) em classes de entidade C# que podem ser usadas com o Entity Framework (EF).

## Funcionalidades

- **Conversão de Arquivos XML**: O programa lê arquivos XML de mapeamento NHibernate do diretório de entrada especificado e os converte em classes de entidade C#.
  
- **Geração de Classes de Entidade**: Com base nos elementos do arquivo XML (tabelas, colunas, chaves estrangeiras etc.), o programa gera classes de entidade C# correspondentes.

- **Persistência em Arquivos**: As classes de entidade geradas são salvas como arquivos `.cs` no diretório de saída especificado.

## Pré-requisitos

Certifique-se de ter os seguintes itens instalados em seu ambiente de desenvolvimento:

- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Uso

1. **Configuração dos Diretórios**: Antes de executar o programa, defina os diretórios de entrada e saída no código-fonte (`diretorioEntrada` e `diretorioSaida`, respectivamente) para corresponder aos locais onde seus arquivos XML estão localizados e onde você deseja salvar as classes de entidade C# geradas.

2. **Execução do Programa**: Compile e execute o programa. Certifique-se de ter permissão de leitura nos arquivos XML de entrada e permissão de escrita no diretório de saída.

3. **Visualização dos Resultados**: Após a conclusão da conversão, as classes de entidade C# serão geradas no diretório de saída especificado. Você pode revisar e usar essas classes em seu projeto com o Entity Framework.

## Estrutura do Código

O código-fonte consiste em várias partes principais:

- **Classe Principal**: `ConversorXMLParaEntidade` é a classe principal que contém o método `Principal()` para iniciar o processo de conversão.

- **Métodos de Conversão**: Os métodos `ParseXmlParaEntidade()` e `GerarClasseEntidade()` são responsáveis por analisar os arquivos XML de mapeamento NHibernate e gerar as classes de entidade C# correspondentes.

- **Estruturas de Dados**: As classes `Entidade`, `Propriedade`, `Relacionamento` e `Coleção` são usadas para representar os elementos do arquivo XML e as propriedades das classes de entidade C#.

## Notas Adicionais

- Este programa foi projetado para facilitar a integração entre sistemas que usam NHibernate e o Entity Framework. Certifique-se de revisar e ajustar as classes de entidade geradas conforme necessário para atender aos requisitos específicos do seu projeto.

- Se você encontrar problemas durante a execução do programa ou tiver dúvidas sobre como configurar ou usar o conversor, consulte a seção de "Problemas Conhecidos" ou entre em contato com o desenvolvedor para obter assistência adicional.

Espero que isso te ajude a entender e usar o conversor de XML para entidade! Se precisar de mais alguma coisa, estou aqui para ajudar.
