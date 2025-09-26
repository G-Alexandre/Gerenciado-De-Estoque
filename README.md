# 📦 Controle de Estoque – C# + ASP.NET Core + PostgreSQL

Sistema simples de **controle de estoque** desenvolvido em **C#** para Programação Orientada a Objetos II.  
Permite cadastrar produtos, incrementar e decrementar a quantidade em estoque.

## 🚀 Tecnologias
- .NET 7
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL

## 🗃️ Banco de Dados
Crie o banco e a tabela:
```sql
CREATE DATABASE estoque_db;
CREATE TABLE produto (
  id_produto SERIAL PRIMARY KEY,
  nome VARCHAR(45) NOT NULL,
  preco NUMERIC(10,2) NOT NULL,
  quantidade INT DEFAULT 0
);
```

## ⚙️ Configuração
No arquivo `appsettings.json` configure a string de conexão:
```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=estoque_db;Username=postgres;Password=SUA_SENHA"
}
```

## ▶️ Executando
```bash
dotnet restore
dotnet run
```
A API estará disponível em:
```
https://localhost:5001/swagger
```

## 🔗 Endpoints
- `GET /api/produtos` – lista todos os produtos
- `GET /api/produtos/{id}` – busca produto por id
- `POST /api/produtos` – cadastra novo produto
- `PATCH /api/produtos/{id}/incremento` – incrementa quantidade
- `PATCH /api/produtos/{id}/decremento` – decrementa quantidade
