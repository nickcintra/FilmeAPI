# FilmeAPI

API Criada com ASP.NET 6 <br>
Banco de dados MYSQL Worckbench <br>
Teste de API POSTMAN <br>
IDE Visual Studio Code. <br>

Após clonar o repositório, faça os seguinte passos para executar:<br>
  1 - verifique a conexão em (appsettings.json) com o banco de dados, veja se esta de acordo com o seu banco de dados<br>
  2 - Abra o Package Manager Console no VISUAL STUDIO CODE e realize o Update-Database, isso vai excutar a migration <br>
  criando toda estrutura de banco de dados correta<br>
  3 - Execute a API <br>
  4 - faça os teste no POSTMAN<br>
  5 - (Opcional) Caso prefira testar no swagger você precisa entrar no arquivo launchSettings.json e editar a linha<br>
  "launchBrowser": false, <--- para TRUE<br>

É possível fazer o post de Usuario, Publicacao e Interacao.<br><br>

Para teste DA API foi utilizado o POSTMAN<br><br>

METODO #POST<br><br>

https://localhost:7075/usuario<br>
Corpo do POST Usuario<br>
{<br>
    "Email" : "teste1@hotmail.com",<br>
    "Senha" : "123"<br>
}<br><br>

https://localhost:7075/publicacao<br>
Corpo do POST Publicacao<br>
{<br>
    "Email" : "teste1@hotmail.com",<br>
    "Senha" : "123"<br>
}<br><br>

https://localhost:7075/interacao<br>
Corpo do POST Interacao<br>
{<br>
    "UsuarioId": 1,<br>
    "Titulo": "Testando o Filme",<br>
    "Descricao": "Filme de Teste", <br>
    "Genero": "Romance",<br>
    "Duracao": 120,<br>
    "Tipo": "Filme"<br>
}<br><br>

É possível fazer busca de Usario por ID e listar todos usuarios.<br><br>

METODO #GET<br><br>

Listando todos usuários - https://localhost:7075/usuario <br>
Listando usuário por id - https://localhost:7075/usuario/1<br><br>

Também é possível buscar todas publicações.<br><br>

https://localhost:7075/publicacao<br>

