# 📋 Tarefas API

Bem-vindo ao repositório da minha **API de Gerenciamento de Tarefas**!  
Este projeto é uma aplicação back-end desenvolvida como parte dos meus estudos em **C# e .NET**, marcando minha transição do **front-end** para o **desenvolvimento full-stack**.

Aqui, criei uma **API RESTful** para gerenciar tarefas de forma eficiente, explorando conceitos de back-end que complementam minhas habilidades anteriores em front-end.

---

## 📌 Sobre o Projeto

Esta API permite **criar 🆕**, **listar 📄**, **atualizar 🔄** e **deletar 🗑️** tarefas.  
Ela conta com:
- Registro de **data de criação** e **conclusão**  
- Gerenciamento de **status** (_pendente_ ou _concluída_)

> Objetivo: Oferecer uma solução prática para organizar tarefas pessoais ou profissionais.

---

### 💡 Problemas Resolvidos

✅ **Organização Pessoal**: controle de estudos, compromissos, etc.  
✅ **Produtividade em Equipes**: acompanhamento de tarefas compartilhadas.  
✅ **Base para Aplicações**: back-end pronto para integrar com front-end em React, Angular etc.

---

## ✅ Tarefas Implementadas

- [x] Criar Tarefa (`POST /tarefas`)
- [x] Listar Tarefas (`GET /tarefas`)
- [x] Atualizar Tarefa (`PUT /tarefas/{id}`)
- [x] Deletar Tarefa (`DELETE /tarefas/{id}`)
- [x] Documentação com Swagger
- [x] Registro de data de criação
- [x] Registro de data de conclusão
- [x] Controle de status da tarefa (pendente/concluída)

---

## 🛠️ Tecnologias Utilizadas

- 🧠 **C#** – Lógica principal da API  
- 🔧 **.NET 8.0** – Framework web  
- 🗃️ **Entity Framework Core** – ORM para banco de dados  
- 🗂️ **SQLite** – Banco local e leve  
- 🌐 **ASP.NET Core** – API RESTful  
- 🧪 **Swagger / OpenAPI** – Documentação e testes interativos

---

## 🧱 Estrutura do Projeto

```plaintext
📁 Controllers/
   └── TarefasController.cs       # Operações CRUD da API

📁 Models/
   └── Tarefa.cs                  # Modelo com Nome, Status, Datas

📁 Data/
   └── AppDbContext.cs           # Contexto EF + Configuração do banco

📄 Program.cs                     # Configura serviços, banco e Swagger  
📄 TarefasApi.csproj             # Arquivo do projeto .NET
```

---

## 🧪 Como Rodar o Projeto

### 🔧 Pré-requisitos

- ✅ [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado  
- ✅ Editor como Visual Studio ou Visual Studio Code

### 📥 Clonar o Repositório

```bash
git clone https://github.com/seu-usuario/tarefas-api.git
cd tarefas-api
```

### ▶️ Executar a API

```bash
dotnet run
```

### 🌐 Acessar no Navegador

Abra o navegador e vá para:

```
http://localhost:5144/swagger
```

A interface Swagger estará disponível para testar os endpoints da API.

---

## 🚀 Exemplos de Uso da API

### 🔹 Criar Tarefa (POST)

**Endpoint:** `POST /tarefas`  
**Exemplo JSON:**
```json
{
  "nome": "Estudar C#",
  "dataCriacao": "2024-05-01T00:00:00",
  "dataConclusao": null,
  "statusTarefa": "Pendente"
}
```

---

### 🔹 Listar Tarefas (GET)

**Endpoint:** `GET /tarefas`  
**Retorno:**
```json
[
  {
    "id": 1,
    "nome": "Estudar C#",
    "dataCriacao": "2024-05-01T00:00:00",
    "dataConclusao": null,
    "statusTarefa": "Pendente"
  }
]
```

---

### 🔹 Atualizar Tarefa (PUT)

**Endpoint:** `PUT /tarefas/{id}`  
**Exemplo JSON:**
```json
{
  "id": 1,
  "nome": "Estudar C# - Atualizado",
  "dataCriacao": "2024-05-01T00:00:00",
  "dataConclusao": "2024-05-05T00:00:00",
  "statusTarefa": "Concluída"
}
```

---

### 🔹 Deletar Tarefa (DELETE)

**Endpoint:** `DELETE /tarefas/{id}`  
**Resposta esperada:** `204 No Content`

---
