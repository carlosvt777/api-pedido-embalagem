# 📦 API de Embalagem de Pedidos

Microserviço em .NET que recebe pedidos com produtos e calcula automaticamente a melhor forma de empacotá-los, otimizando o uso de caixas disponíveis.

---

## ✅ Requisitos Atendidos

- ✅ Microserviço em **.NET Core 8.0**
- ✅ Banco de dados **SQL Server** rodando via Docker
- ✅ Migrations automáticas com **Entity Framework Core**
- ✅ API documentada e testável via **Swagger**
- ✅ **Docker Compose** orquestrando aplicação e banco
- ✅ Código fonte hospedado no **GitHub**
- ✅ Readme com instruções completas

---

## 🧰 Tecnologias

- ASP.NET Core 8.0
- Entity Framework Core
- SQL Server 2022
- Docker e Docker Compose
- Swagger (OpenAPI)

---

## 🚀 Executando o projeto

### ✅ Pré-requisitos

- [Docker](https://www.docker.com) instalado
- [Docker Compose](https://docs.docker.com/compose/) instalado
- Git instalado

---

### ▶️ Passos para rodar

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/carlosvt777/api-pedido-embalagem.git
   cd api-pedido-embalagem
   ```

2. **Execute a aplicação com Docker Compose:**

   ```bash
   docker-compose up -d
   ```

   Isso irá baixar as imagens necessárias, criar os containers do banco de dados e da aplicação, e executar as migrations automaticamente.

   > **Atenção:** Na primeira execução, pode levar alguns minutos para que o banco de dados esteja pronto. A aplicação tentará se conectar automaticamente até que o banco esteja disponível.

3. **Verifique se os containers estão rodando:**

   ```bash
   docker-compose ps
   ```

---

### 🌐 Acessando a API

Após levantar os containers, acesse a documentação interativa do Swagger para testar e explorar a API:

[http://localhost:5000/swagger](http://localhost:5000/swagger)

> O endereço/porta pode variar conforme o mapeamento no `docker-compose.yml`. Se necessário, verifique as portas expostas.

---

### ⏹️ Parando os containers

Para parar e remover todos os containers criados pelo Docker Compose:

```bash
docker-compose down
```

---
