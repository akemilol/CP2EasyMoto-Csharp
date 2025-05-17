
# 🚀 EasyMoto API

API RESTful desenvolvida como parte do CP2 da disciplina **Advanced Business Development with .NET** na FIAP.

## 📚 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core (SQLite)
- AutoMapper
- Swagger

## 🔗 Rotas Disponíveis

### 🏢 Filiais
- **GET** `/api/Filiais` – Listar todas as filiais
- **GET** `/api/Filiais/{id}` – Buscar filial por ID
- **POST** `/api/Filiais` – Cadastrar nova filial
- **PUT** `/api/Filiais/{id}` – Atualizar filial
- **DELETE** `/api/Filiais/{id}` – Deletar filial

### 🛵 Motos
- **GET** `/api/Motos` – Listar todas as motos
- **GET** `/api/Motos/{id}` – Buscar moto por ID
- **POST** `/api/Motos` – Cadastrar nova moto
- **PUT** `/api/Motos/{id}` – Atualizar moto
- **DELETE** `/api/Motos/{id}` – Deletar moto

## ⚙️ Como Executar

1. Clone o repositório  
2. Execute as migrations e o projeto:
   ```
   dotnet ef database update
   dotnet run
   ```
3. F5 para rodar o swagger

## 👥 Integrantes

- Mirela Pinheiro Silva Rodrigues — RM: 558191
- Valéria Conceição dos Santos — RM: 557177

---
