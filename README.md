# Conversor de XML para Entidade

Este é um programa simples que converte arquivos de mapeamento XML do NHibernate para classes de entidade em C#. Ele é útil quando você está migrando de um projeto que utiliza NHibernate para Entity Framework e precisa converter seus arquivos de mapeamento.


## Funcionalidades

- **Conversão de Arquivos XML**: O programa lê arquivos XML de mapeamento NHibernate do diretório de entrada especificado pelo usuário e os converte em classes de entidade C#.
  
- **Geração de Classes de Entidade**: Com base nos elementos do arquivo XML (tabelas, colunas, chaves estrangeiras etc.), o programa gera classes de entidade C# correspondentes.

- **Persistência em Arquivos**: As classes de entidade geradas são salvas como arquivos `.cs` no diretório de saída especificado pelo usuário.

## Pré-requisitos

Certifique-se de ter os seguintes itens instalados em seu ambiente de desenvolvimento:

- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Uso

1. **Preparação dos Arquivos XML**: Antes de executar o programa, substitua os arquivos XML de mapeamento NHibernate no diretório de entrada pelos arquivos que você deseja converter. Certifique-se de ter permissão de leitura nos arquivos XML de entrada.

2. **Limpeza do Diretório de Saída**: Certifique-se de que o diretório de saída escolhido esteja vazio antes de iniciar a conversão. As classes de entidade C# geradas serão salvas neste diretório, e quaisquer arquivos existentes serão substituídos durante o processo de conversão.

3. **Configuração dos Diretórios**: Antes de executar o programa,  os programa irá perguntar qual o diretório de entrada e saída respectivamente para corresponder aos locais onde seus arquivos XML estão localizados e onde você deseja salvar as classes de entidade C# geradas.

4. **Execução do Programa**: Compile e execute o programa. Certifique-se de ter permissão de leitura nos arquivos XML de entrada e permissão de escrita no diretório de saída.

5. **Visualização dos Resultados**: Após a conclusão da conversão, as classes de entidade C# serão geradas no diretório de saída especificado. Você pode revisar e usar essas classes em seu projeto com o Entity Framework.

## Estrutura do Código

O código-fonte consiste em várias partes principais:

- **Classe Principal**: `ConversorXMLParaEntidade` é a classe principal que contém o método `Principal()` para iniciar o processo de conversão.

- **Métodos de Conversão**: Os métodos `ParseXmlParaEntidade()` e `GerarClasseEntidade()` são responsáveis por analisar os arquivos XML de mapeamento NHibernate e gerar as classes de entidade C# correspondentes.

- **Estruturas de Dados**: As classes `Entidade`, `Propriedade`, `Relacionamento` e `Coleção` são usadas para representar os elementos do arquivo XML e as propriedades das classes de entidade C#.

## Notas Adicionais
Avisos
- Este programa não realiza validações avançadas nos arquivos XML. Certifique-se de que seus arquivos de mapeamento estejam corretamente formatados.
Os tipos de dados de mapeamento do NHibernate são mapeados para tipos de dados do C# conforme especificado no código. Verifique se os tipos de dados resultantes atendem às suas necessidades.

- Este programa foi projetado para facilitar a integração entre sistemas que usam NHibernate e o Entity Framework. Certifique-se de revisar e ajustar as classes de entidade geradas caso necessário para atender aos requisitos específicos do seu projeto.

- A criação desse programa teve inciativa em um desafio técnico proposto ao desenvolvedor se você encontrar problemas durante a execução do programa ou tiver dúvidas sobre como configurar ou usar o conversor, entre em contato comigo.

- No arquivo do projeto há duas pastas já destinadas a serem o diretório de entrada e o diretório de saída como exemplo.
