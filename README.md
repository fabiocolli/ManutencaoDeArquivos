# Servico Mantem Arquivos

## Descrição
Este projeto é uma aplicação de manutenção de arquivos, organizada em várias camadas para separar responsabilidades e facilitar a manutenção e evolução do código.

## Estrutura do Projeto

### Camadas

1. **Dominio.ManutencaoArquivos**
   - Contém as entidades e serviços de domínio.
   - Define as regras de negócio e lógica de domínio.

2. **Aplicacao.ManutencaoDeArquivo**
   - Contém os serviços de aplicação.
   - Orquestra a lógica de negócio e interage com as camadas de infraestrutura.

3. **Infraestrutura.ManutencaoArquivos**
   - Contém a implementação dos serviços de infraestrutura.
   - Interage com sistemas externos, como bancos de dados e sistemas de arquivos.

4. **Servico.ManutencaoArquivos**
   - Contém a configuração e inicialização do serviço.
   - Define a configuração do host e registra os serviços no contêiner de injeção de dependência.

5. **ServicoMantemArquivos.Teste**
   - Contém os testes unitários do projeto.
   - Utiliza pacotes como xUnit e FluentAssertions para garantir a qualidade do código.

## Pacotes Utilizados

- **coverlet.collector**: Utilizado para coleta de cobertura de código durante os testes.
- **FluentAssertions**: Utilizado para facilitar a escrita de assertivas nos testes.
- **Microsoft.NET.Test.Sdk**: Utilizado para suporte a testes no .NET.
- **xunit**: Framework de testes unitários.
- **xunit.runner.visualstudio**: Utilizado para integração dos testes xUnit com o Visual Studio.
- **Microsoft.Extensions.Configuration**: Utilizado para gerenciamento de configurações.
- **Microsoft.Extensions.Configuration.Json**: Suporte para arquivos de configuração JSON.
- **Moq**: Utilizado para criação de mocks nos testes.

## Como Executar

1. Clone o repositório.
2. Navegue até a pasta do projeto.
3. Restaure os pacotes NuGet: `dotnet restore`.
4. Execute o projeto: `dotnet run --project Servico.ManutencaoArquivos`.
5. Execute os testes: `dotnet test`.

## Contribuição

Sinta-se à vontade para contribuir com o projeto. Abra uma issue ou envie um pull request.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
