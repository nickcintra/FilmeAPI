# FilmeAPI

API Criada com ASP.NET 6 <br>
Banco de dados MYSQL Worckbench <br>
Teste de API POSTMAN <br>
IDE Visual Studio Code. <br>

<b>Após clonar o repositório, faça os seguinte passos para executar:</b><br><br>

  1 - verifique a conexão em (<b>appsettings.json</b>) com o banco de dados, veja se esta de acordo com o seu banco de dados<br>
  2 - Abra o <b><i>Package Manager Console</i></b> no <b>VISUAL STUDIO CODE</b> e realize o <b>Update-Database</b>, isso vai executar a Migration <br>
  criando toda estrutura de banco de dados correta<br>
  3 - Execute a API <br>
  4 - faça os teste no POSTMAN<br>
  5 - (Opcional) Caso prefira testar no swagger, você precisa entrar no arquivo <b>launchSettings.json</b> e editar a linha<br>
  <b>"launchBrowser": false, <--- para TRUE</b><br><br>

É possível fazer o post de Usuario, Publicacao e Interacao.<br>

METODO #POST<br>

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

É possível fazer busca de Usuário por ID e listar todos usuários também.<br><br>

METODO #GET<br>

Listando todos usuários - https://localhost:7075/usuario <br>
Listando usuário por id - https://localhost:7075/usuario/1 <br>

Também é possível buscar todas publicações - https://localhost:7075/publicacao <br>


