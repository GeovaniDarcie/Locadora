# Como executar a API
- Instale .NET Core 3.1 (v3.1.301).
- Execute o comando `dotnet --version` no terminal, para verificar sua versão.
- Instale o EF Core Tools com o comando `dotnet tool install --global dotnet-ef` no terminal.
- Para criação do banco de dados, execute o comando ` dotnet ef database update`
- Execute o projeto com `dotnet run`.

# Documentação da API

### Endpoints de Directors
| Verb | URL  | Descrição |
| -------- | -------- | -------- |
|GET  | api/directors | Lista todos os diretores e seus filmes|
|GET  | api/directors/{id} | Lista o diretor pelo id|
|POST | api/directors | Cria um diretor|
|PUT  | api/directors/{id} | Atualiza um diretor pelo id|
|DELETE | api/directors/{id} | Deleta um diretor pelo id|

### Endpoints de Movies
| Verb | URL  | Descrição |
| -------- | -------- | -------- |
|GET  | api/movies | Lista todos os filmes e seus diretores|
|GET  | api/movies/{id} | Lista o filme pelo id|
|POST | api/movies | Cria um filme|
|PUT  | api/movies/{id} | Atualiza um filme pelo id|
|DELETE | api/movies/{id} | Deleta um filme pelo id|

