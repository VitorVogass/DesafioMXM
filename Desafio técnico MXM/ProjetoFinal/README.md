# Conversor de XML para Entidade

Este � um programa simples em C# que converte arquivos XML de mapeamento NHibernate (`.hbm.xml`) em classes de entidade C# que podem ser usadas com o Entity Framework (EF).

## Funcionalidades

- **Convers�o de Arquivos XML**: O programa l� arquivos XML de mapeamento NHibernate do diret�rio de entrada especificado e os converte em classes de entidade C#.
  
- **Gera��o de Classes de Entidade**: Com base nos elementos do arquivo XML (tabelas, colunas, chaves estrangeiras etc.), o programa gera classes de entidade C# correspondentes.

- **Persist�ncia em Arquivos**: As classes de entidade geradas s�o salvas como arquivos `.cs` no diret�rio de sa�da especificado.

## Pr�-requisitos

Certifique-se de ter os seguintes itens instalados em seu ambiente de desenvolvimento:

- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Uso

1. **Configura��o dos Diret�rios**: Antes de executar o programa, defina os diret�rios de entrada e sa�da no c�digo-fonte (`diretorioEntrada` e `diretorioSaida`, respectivamente) para corresponder aos locais onde seus arquivos XML est�o localizados e onde voc� deseja salvar as classes de entidade C# geradas.

2. **Execu��o do Programa**: Compile e execute o programa. Certifique-se de ter permiss�o de leitura nos arquivos XML de entrada e permiss�o de escrita no diret�rio de sa�da.

3. **Visualiza��o dos Resultados**: Ap�s a conclus�o da convers�o, as classes de entidade C# ser�o geradas no diret�rio de sa�da especificado. Voc� pode revisar e usar essas classes em seu projeto com o Entity Framework.

## Estrutura do C�digo

O c�digo-fonte consiste em v�rias partes principais:

- **Classe Principal**: `ConversorXMLParaEntidade` � a classe principal que cont�m o m�todo `Principal()` para iniciar o processo de convers�o.

- **M�todos de Convers�o**: Os m�todos `ParseXmlParaEntidade()` e `GerarClasseEntidade()` s�o respons�veis por analisar os arquivos XML de mapeamento NHibernate e gerar as classes de entidade C# correspondentes.

- **Estruturas de Dados**: As classes `Entidade`, `Propriedade`, `Relacionamento` e `Cole��o` s�o usadas para representar os elementos do arquivo XML e as propriedades das classes de entidade C#.

## Notas Adicionais

- Este programa foi projetado para facilitar a integra��o entre sistemas que usam NHibernate e o Entity Framework. Certifique-se de revisar e ajustar as classes de entidade geradas conforme necess�rio para atender aos requisitos espec�ficos do seu projeto.

- Se voc� encontrar problemas durante a execu��o do programa ou tiver d�vidas sobre como configurar ou usar o conversor, consulte a se��o de "Problemas Conhecidos" ou entre em contato com o desenvolvedor para obter assist�ncia adicional.

Espero que isso te ajude a entender e usar o conversor de XML para entidade! Se precisar de mais alguma coisa, estou aqui para ajudar.
