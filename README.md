# Task Manager API (.NET 6)

## Como rodar o projeto
```bash
git clone <seu_repositorio>
cd TaskManager
dotnet run

A API estará disponível em https://localhost:5001.

Obs: Em alguns casos o seu ambiente pode ser inicializado em uma porta diferente da porta 5001.
Nesse caso a porta correta será exibida no momento em que o comando dotnet run for executado. Exemplo:

  dotnet run
  Compilando...
  info: Microsoft.Hosting.Lifetime[14]
        Now listening on: https://localhost:7246
  info: Microsoft.Hosting.Lifetime[14]
        Now listening on: http://localhost:5288
  info: Microsoft.Hosting.Lifetime[0]
        Application started. Press Ctrl+C to shut down.
  info: Microsoft.Hosting.Lifetime[0]
        Hosting environment: Development
  info: Microsoft.Hosting.Lifetime[0]
        Content root path: /home/andre/Projects/TaskManager/TaskManager/

No exemplo acima a API estará disponível nas duas opções:
https://localhost:7246 -> Para https
http://localhost:5288 -> Para http

## Como testar o projeto
A API poderá ser testada diretamente pelo browser utilizando o Swagger. Basta adicionar '/swagger' à url da API. Exemplo: https://localhost:5001/swagger

A API pode ser testada também enviando comandos diretos aos seus enpoints via curl ou ferramentas como Postman.
Os Enpoints são:

POST /api/tasks -> Cria nova tarefa
GET /api/tasks/{userId} -> Lista todas as tarefas criadas pelo usuário. (Em caso de teste o ID do usuário será 0)
PUT /api/tasks/{id}/complete -> Marca a tarefa com o ID especificado como completa.
DELETE /api/tasks/{id} -> Apaga a tarefa com o ID especificado.
