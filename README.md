# LearnBank

> Um projeto open source para ensinar desenvolvimento Backend .NET moderno utilizando um domínio bancário como exemplo prático.

O objetivo deste repositório **não é criar mais um banco digital**, mas servir como um guia de estudos para desenvolvedores que desejam aprender arquitetura enterprise, Domain-Driven Design (DDD), Clean Architecture e boas práticas utilizadas em sistemas reais.

Todo o projeto está sendo desenvolvido do zero, explicando **o porquê** de cada decisão arquitetural, e não apenas **como** escrever código.

---

# Objetivos

Este projeto busca ensinar:

- C# moderno
- ASP.NET Core
- Clean Architecture
- Vertical Slice Architecture
- CQRS
- Domain-Driven Design (DDD)
- SOLID
- Design Patterns
- Entity Framework Core
- Arquitetura de sistemas bancários
- Modelagem baseada em BIAN
- Sistemas distribuídos
- RabbitMQ
- Redis
- Docker
- Observabilidade
- Testes
- Boas práticas para projetos enterprise

---

# Público alvo

Este projeto foi criado principalmente para:

- Desenvolvedores iniciantes.
- Desenvolvedores que desejam migrar para Backend .NET.
- Desenvolvedores que desejam aprender arquitetura.
- Pessoas se preparando para entrevistas técnicas.
- Desenvolvedores que desejam entender como sistemas financeiros são modelados.

---

# Filosofia do projeto

Durante o desenvolvimento serão evitadas soluções "mágicas".

O foco é entender:

- por que determinada arquitetura existe;
- qual problema ela resolve;
- quando utilizá-la;
- quando NÃO utilizá-la.

Mais importante do que decorar Design Patterns é aprender a modelar corretamente o domínio.

---

# Roadmap

## Fase 1

- [x] Estrutura da Solution
- [x] Clean Architecture
- [x] Vertical Slice
- [ ] User Aggregate
- [ ] CreateUser
- [ ] GetUserById
- [ ] ListUsers

---

## Fase 2

- [ ] Wallet Aggregate
- [ ] Financial Position
- [ ] Ledger
- [ ] Deposit Money
- [ ] Withdraw Money
- [ ] Transfer Money

---

## Fase 3

- [ ] Domain Events
- [ ] Event Storming
- [ ] Entity Framework Core
- [ ] PostgreSQL

---

## Fase 4

- [ ] RabbitMQ
- [ ] Outbox Pattern
- [ ] Saga Pattern
- [ ] Redis
- [ ] OpenTelemetry

---

## Fase 5

- [ ] Docker
- [ ] Testes unitários
- [ ] Testes de integração
- [ ] Hardening
- [ ] Deploy

---

# Estrutura da Solution

```text
LearnBank.sln

src/
│
├── LearnBank.Api
├── LearnBank.Application
├── LearnBank.Domain
└── LearnBank.Infrastructure

tests/
│
├── LearnBank.UnitTests
└── LearnBank.IntegrationTests

docs/
│
├── architecture
├── domain
├── event-storming
└── decisions
```

---

# Tecnologias

- .NET
- ASP.NET Core
- C#
- Entity Framework Core
- PostgreSQL
- RabbitMQ
- Redis
- Docker

---

# Arquitetura

O projeto utiliza:

- Clean Architecture
- Vertical Slice Architecture
- CQRS
- Rich Domain Model
- Domain-Driven Design

---

# Documentação

Ao longo do desenvolvimento serão adicionados documentos explicando:

- decisões arquiteturais;
- regras de negócio;
- modelagem do domínio;
- Event Storming;
- Aggregate Roots;
- BIAN;
- ADRs (Architecture Decision Records).

O objetivo é que qualquer pessoa consiga entender não apenas o código, mas também o raciocínio utilizado durante a implementação.

---

# Série no YouTube

Este projeto fará parte de uma série.

Durante os vídeos será explicado:

- por que cada arquivo existe;
- qual responsabilidade de cada camada;
- como arquitetar aplicações reais;
- erros comuns de iniciantes;
- boas práticas utilizadas no mercado.

---

# Aviso

Este projeto é educacional.

Ele não pretende reproduzir integralmente um sistema bancário real, mas sim utilizar esse domínio para demonstrar conceitos de engenharia de software de maneira prática.

---

# Licença

MIT
