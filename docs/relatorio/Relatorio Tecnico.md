# Informações do Projeto
`TÍTULO DO PROJETO`  

`CURSO`
Análise e Desenvolvimento de Sistemas 

## Participantes
>
> O membro do grupo é: 
> - Lucas Soares Magalhães

# Estrutura do Documento

- [Informações do Projeto](#informações-do-projeto)
  - [Participantes](#participantes)
- [Estrutura do Documento](#estrutura-do-documento)
- [Introdução](#introdução)
  - [Problema](#problema)
  - [Objetivos](#objetivos)
  - [Justificativa](#justificativa)
  - [Público-Alvo](#público-alvo)
  - [Persona](#persona)
  - [Histórias de Usuários](#histórias-de-usuários)
  - [Requisitos](#requisitos)
    - [Requisitos Funcionais](#requisitos-funcionais)
    - [Requisitos não Funcionais](#requisitos-não-funcionais)
  - [Restrições](#restrições)
- [Projeto de Interface](#projeto-de-interface)
  - [User Flow](#user-flow)
  - [Wireframes](#wireframes)
- [Metodologia](#metodologia)
  - [Divisão de Papéis](#divisão-de-papéis)
  - [Ferramentas](#ferramentas)
  - [Controle de Versão](#controle-de-versão)
- [Projeto da Solução](#projeto-da-solução)
  - [Tecnologias Utilizadas](#tecnologias-utilizadas)
  - [Arquitetura da solução](#arquitetura-da-solução)
- [Avaliação da Aplicação](#avaliação-da-aplicação)
  - [Plano de Testes](#plano-de-testes)
  - [Ferramentas de Testes (Opcional)](#ferramentas-de-testes-opcional)
  - [Registros de Testes](#registros-de-testes)


# Introdução

## Problema

O estacionamento "ParkSafe" enfrenta desafios relacionados à eficiência operacional e à experiência do cliente devido à falta de informações precisas sobre o tempo que os veículos passam estacionados. Isso dificulta a otimização das operações do estacionamento, o ajuste das tarifas de estacionamento e a melhoria da sinalização para aumentar a rotatividade de veículos.

## Objetivos

O objetivo principal deste projeto é criar um sistema de monitoramento de estacionamento "ParkSafe" que permita aos administradores coletar e analisar informações precisas sobre o tempo de permanência dos veículos. Os objetivos específicos incluem:

    Desenvolver um sistema que permita o registro de entrada e saída de veículos no estacionamento.
    Armazenar dados sobre o tempo de permanência dos veículos em um banco de dados SQL.
    Implementar recursos de relatório para que os administradores possam acessar informações sobre o tempo médio de permanência dos veículos.

## Justificativa

A criação do sistema de monitoramento de estacionamento é essencial para melhorar a eficiência operacional do "ParkSafe". A obtenção de informações precisas sobre o tempo de permanência dos veículos permitirá ao estacionamento tomar decisões informadas, otimizar suas operações e aprimorar a experiência do cliente.

## Público-Alvo

......  COLOQUE AQUI O SEU TEXTO ......

O público-alvo deste projeto inclui administradores de estacionamentos, como Ana, que desejam coletar informações sobre o tempo que os veículos passam estacionados em seus estabelecimentos.
 
## Persona

    Persona : Ana Silva
        Empreendedora e administradora do estacionamento "ParkSafe".
        Conhecimentos em gestão de negócios.
        Relação direta com o estacionamento.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Administrador (Ana)  | Registrar entrada e saída de veículos           | Ter um registro preciso do tempo de permanência para análise e tomada de decisões               |
|Administrador (Ana)  | Gerar relatórios de tempo de permanência           | Avaliar o desempenho do estacionamento e otimizar operações               |
|Usuário do sistema  | Visualizar o tempo de permanência do veículo           | Conferir o tempo gasto no estacionamento               |

## Requisitos


### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Sistema de registro de entrada e saída de veículos. | ALTA | 
|RF-002| Armazenamento de dados em um banco de dados SQL.   | BAIXA |
|RF-003| Geração de relatórios de tempo de permanência.   | ALTA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Segurança: Os dados do sistema devem ser protegidos. | ALTA | 
|RNF-002| Eficiência: O sistema deve processar registros de entrada e saída de veículos de forma eficiente. |  BAIXA | 
|RNF-002| Usabilidade: A interface do usuário deve ser intuitiva e amigável. |  MÉDIA | 
|RNF-002| Disponibilidade: O sistema deve estar disponível 24/7. |  ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| Orçamento limitado para o projeto. |
|02| Equipe de um único indivíduo        |

# Projeto de Interface

## User Flow

    O usuário entra no estacionamento.
    O sistema registra a entrada do veículo.
    O usuário estaciona o veículo.
    O usuário sai do estacionamento.
    O sistema registra a saída do veículo e calcula o tempo de permanência.
    O sistema gera relatórios com os dados do tempo de permanência.

# Metodologia

Será utilizado o método ágil SCRUM

## Divisão de Papéis

Lucas Soares Magalhães - Desenvolvedor full stack


## Ferramentas

......  COLOQUE AQUI O SEU TEXTO - SIGA O EXEMPLO DA TABELA ABAIXO  ......

| Ambiente  | Plataforma              |Link de Acesso |
|-----------|-------------------------|---------------|
|Repositório de código | GitHub | https://github.com/PSG-TADS/psg-tads-2023-2-back-bd-LucasSoaresMagalhaes | 
|Desenvolvimento C# | Visual Studio |  https://visualstudio.microsoft.com/pt-br/ | 
|Desenvolvimento SQL | SQL Server Manager Studio | https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 | 
|Desenvolvimento MongoDB | Visual Studio | https://visualstudio.microsoft.com/pt-br/ | 

## Controle de Versão

O controle de versão será gerenciado usando o Git, com um repositório no GitHub.

# Projeto da Solução

## Tecnologias Utilizadas

......  COLOQUE AQUI O SEU TEXTO ......

    Visual Studio para desenvolvimento em C#.
    SQL Server como banco de dados SQL.
    MongoDB como banco de dados NoSQL para armazenamento de registros.

## Arquitetura da solução

O sistema seguirá uma arquitetura cliente-servidor, com o cliente representando os terminais de registro de entrada e saída e o servidor gerenciando o banco de dados SQL e MongoDB.

# Avaliação da Aplicação

## Plano de Testes

Serão realizados testes funcionais e de desempenho para garantir que o sistema atenda aos requisitos estabelecidos. O plano de testes incluirá casos de teste para:

    Registro de entrada e saída de veículos.
    Cálculo do tempo de permanência.
    Geração de relatórios.

## Ferramentas de Testes (Opcional)

Poderão ser utilizadas ferramentas como Visual Studio Test Explorer e MongoDB Compass para auxiliar nos testes.

## Registros de Testes

Os resultados dos testes serão registrados e documentados para garantir a qualidade do sistema.
