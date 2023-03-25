# FilmeAPI

API Criada com ASP.NET 6
Banco de dados MYSQL Worckbench
Teste de API POSTMAN
IDE Visual Studio Code.

Após clonar o repositório, faça os seguinte passos para executar:d
  1 - verifique a conexão em (appsettings.json) com o banco de dados, veja se esta de acordo com o seu banco de dados
  2 - Abra o Package Manager Console no VISUAL STUDIO CODE e realize o Update-Database, isso vai excutar a migration 
  criando toda estrutura de banco de dados correta
  3 - Execute a API 
  4 - faça os teste no POSTMAN
  5 - (Opcional) Caso prefira testar no swagger você precisa entrar no arquivo launchSettings.json e editar a linha
  "launchBrowser": false, <--- para TRUE

É possível fazer o post de Usuario, Publicacao e Interacao.

Para teste DA API foi utilizado o POSTMAN

METODO #POST

https://localhost:7075/usuario
Corpo do POST Usuario
{
    "Email" : "teste1@hotmail.com",
    "Senha" : "123"
}

https://localhost:7075/publicacao
Corpo do POST Publicacao
{
    "Email" : "teste1@hotmail.com",
    "Senha" : "123"
}

https://localhost:7075/interacao
Corpo do POST Interacao
{
    "UsuarioId": 1,
    "Titulo": "Testando o Filme",
    "Descricao": "Filme de Teste", 
    "Genero": "Romance",
    "Duracao": 120,
    "Tipo": "Filme"
}

É possível fazer busca de Usario por ID e listar todos usuarios.

METODO #GET

Listando todos usuários - https://localhost:7075/usuario 
Listando usuário por id - https://localhost:7075/usuario/1

Também é possível buscar todas publicações.

https://localhost:7075/publicacao

