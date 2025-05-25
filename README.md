# Mottu - API de Mapeamento Inteligente do Pátio e Gestão das Motos
 
Este projeto foi desenvolvido para o desafio da Mottu, com o objetivo de otimizar o mapeamento e a gestão das motos nos pátios das filiais da empresa. A aplicação utiliza ASP.NET Core para criação de uma API RESTful e está integrada a um banco de dados Oracle via Entity Framework Core.
 
## Funcionalidades
 
- CRUD completo de motos (GET, POST, PUT, DELETE)
- Integração com banco Oracle via EF Core e migrations
- Retornos HTTP apropriados (200, 201, 400, 404, 204)
- Documentação com Swagger (OpenAPI)
 
## Rotas Principais
 
- `GET /api/motos` – Lista todas as motos
- `GET /api/motos/{id}` – Retorna uma moto por ID
- `GET /api/motos/search?filial=...` – Busca por filtros
- `POST /api/motos` – Cria uma nova moto
- `PUT /api/motos/{id}` – Atualiza uma moto
- `DELETE /api/motos/{id}` – Remove uma moto
 
## Como Executar
 
1. Clone o repositório
2. Configure o `appsettings.json` com a string de conexão Oracle
3. Rode as migrations com `dotnet ef database update`
4. Inicie o projeto com `dotnet run`
5. Acesse a documentação via Swagger em `https://localhost:{porta}/swagger`
 
## Integrantes
 
- João Victor Rocha Cândido – RM 554727 – 2TDSPK  
- Thomas Rodrigues Ribeiro Silva – RM 558042 – 2TDSPK  
- João Vitor Broggine Lopes – RM 557129 – 2TDSPF
