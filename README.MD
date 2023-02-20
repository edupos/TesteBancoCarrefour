O que fiz:

- Endpoint para fazer os lançamentos (assumi que apenas inclusões eram necessárias para manter o histórico dos lançamentos, e inclui um campo de observação para justificar um lançamento corrigindo outro).
- Endpoint para gerar o relatório (O agrupamento está pode tipo(débito ou crédito), moeda, e mês).
- Arquitetura DDD
- Desenho no Draw.IO (No raiz) - Arquivo: CashFlowSolution.drawio
- EntityFrameworkCore - usando MIgrations
- Injeção de dependencia
- Minimum API
- Swagger

O que não fiz:

- Embora o documento com o desenho da arquitetura tenha uma arquitetura de microserviços. Eu desenvolvi uma arquitetura monolitica para agiizar o desenvolvimento.
- Não coloquei a aplicação em container, então por favor rodar no IISExpress.
- Não fiz front, não deu tempo e acredito que o mais importante era a API e a arquitetura para vaga de vocês.
- Não desenvolvi testes, normalmente desenvolvo,  mas quis agilizar o desenvolvimento.
- Não utilizei um padrão de notificação e nem criei logs.
- Não fiz autenticação.

Como rodar:

- Atualizar o appsettings.config (com a string de conexão
- Rodar o comando:  dotnet ef database update --project CashFlow.Repository
- Executar o Visual Studio no IISExpress
- Testar a API no SWAGGER


Enums para teste:

    public enum EnumOperationCurrency
    {
        Real = 0,
        Dolar = 1,
        EURO = 2
    }
	
	public enum EnumOperationType
    {
        Credit = 0,
        Debit = 1
    }

Exemplo de chamadas a API via swagger:

/PostingEntry

Request:

{
  "operationType": 0,
  "operationCurrency": 0,
  "operationValue": 10.00,
  "description": "Credito no caixa",
  "observation": "Feito para testar"
}

Response :
	200 OK

/MonthlyConsolidateReport

Request:

Vazio

Response: 

[
  {
    "operationType": 0,
    "operationCurrency": 0,
    "totalMonth": 830,
    "operationMonth": 1
  },
  {
    "operationType": 1,
    "operationCurrency": 1,
    "totalMonth": 353,
    "operationMonth": 1
  }
]


Pessoal, espero que considerem tudo que fiz e agradeço a oportunidade.