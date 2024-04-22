## Rotas 

Este trecho de código implementa rotas para manipulação de recursos em um aplicativo ASP.NET Core usando o padrão de roteamento do ASP.NET Core.

### Adicionando

- Método: `POST`
- Rota: `/estudantes`
- Descrição: Adiciona um novo estudante ao sistema com base nos dados fornecidos na solicitação.
- Parâmetros da Solicitação: Um objeto `AddEstudante` contendo o nome do estudante.
- Exemplo de Uso:
  ```http
  POST /estudantes
  Content-Type: application/json

  {
    "nome": "João da Silva"
  }
