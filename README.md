# Modulo03_Projeto01_DEVinHouse
Projeto desenvolvido para o curso DEVinHouse - Turma NDD 🚀

<h1 align="center">
   <p>DEVinCar - API RESTful de Vendas</p>
</h1>

Projeto avaliativo DEVinHouse, desenvolvido com ASP.NET 6 com EntityFramework Core 6, em C#, conectando em base SQL Server, respeitando padrões Rest(métodos HTTP, cache, middleware, content negotiation), com implementação do SOLID e divisão em camadas.

### 💻 Sobre
O projeto desenvolve uma API para vendas de carros. Separados em 3 módulos:
<ul>
    <li>Módulo de Cadastro: Responsável por manter e gerir o cadastro de usuários e produtos;</li>
    <li>Módulo de Vendas: Responsável por gerir as vendas de carros e as entregas;</li>
    <li>Módulo de Geo-Posicionamento: Responsável por gerir o cadastro de cidades, estados e endereços.</li>
</ul>

### ⚙️ Funcionalidades

Crud Completo:

- User
- Car
- Address
- Sales
- Delivery
- State
- City
- Autenticação JWT
- Autorização

### Pré-requisitos

Para rodar o projeto em sua máquina, você vai precisar ter instalado as seguintes ferramentas:
[Git](https://git-scm.com) e [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
Além disto é importante ter um editor para trabalhar com o código, como [VisualStudio](https://visualstudio.microsoft.com/) e um sistema gerenciador de Banco de dados relacional, como o [SQLServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

#### 🎲 Rodando a Aplicação


<h5>1 - No repositório do GitHub, clone o projeto 👇</h5>

```bash
# Clone este repositório
$ git clone https://github.com/edmilsondmx/Modulo03_Projeto01_DEVinHouse
```

<h5>2 - Abra o projeto no VisualStudio, clicando 2x no arquivo <b>DevInCar.sln</b></h5>

    
<h5>3 - Vá para o arquivo <b>appsettings.json</b> e adicione a ConnectionString, seguindo o modelo abaixo 👇</h5>

```bash
"ConnectionStrings": {
"ServerConnection": "Server=localhost\\SQLEXPRESS;Database=BD_DEVINCAR;Trusted_Connection=True;"
}
```


<h5>4 - Instale as seguintes dependências, via NuGet:</h5>
    <ul>
        <li>Microsoft.EntityFrameworkCore</li>
        <li>Microsoft.EntityFrameworkCore.Tools</li>
        <li>Microsoft.EntityFrameworkCore.Design</li>
        <li>Microsoft.EntityFrameworkCore.SqlServer</li>
        <li>Swashbuckle.AspNetCore</li>
    </ul>



<h5>5 - Com os pacotes instalados, abra o terminal e digite o comando abaixo 👇</h5>

```bash
dotnet ef migrations Add Initial
```

<h5>6 - Após o comando executado, você irá inserir as tabelas no Banco de Dados com o seguinte comando 👇</h5>

```bash
dotnet ef Database Update
```

<h5>7 - Com esses passos executados, você já pode executar a aplicação inserindo o camendo no terminal:</h5>

```bash
dotnet watch run
```


## Autor
Edmilson Gomes 😊
