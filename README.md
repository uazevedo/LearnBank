# LearnBank

> A hands-on open-source project to learn modern .NET backend development using a banking domain as a real-world example.

**LearnBank** is not intended to become another digital banking application.

Its purpose is to help developers understand **how enterprise backend systems are designed**, from basic CRUD operations to scalable architectures used in real-world financial applications.

The focus is not only **how to write code**, but also **why architectural decisions are made**.

---

# Goals

This project aims to teach:

- Modern C#
- ASP.NET Core Web API
- Clean Architecture
- Vertical Slice Architecture
- CQRS
- Domain-Driven Design (DDD)
- SOLID Principles
- Design Patterns
- Entity Framework Core
- Financial domain modeling
- BIAN concepts
- Distributed Systems
- RabbitMQ
- Redis
- Docker
- Observability
- Automated Testing
- Enterprise software development practices

---

# Who is this project for?

LearnBank was created for developers who want to:

- Learn backend development with .NET.
- Build a strong software engineering foundation.
- Understand enterprise architecture.
- Prepare for technical interviews.
- Learn how financial systems are modeled.
- Move beyond CRUD applications.

---

# Project Philosophy

This repository intentionally avoids "magic" solutions.

Every architectural decision is explained.

The goal is to understand:

- Why does this architecture exist?
- Which problem does it solve?
- When should it be used?
- When should it NOT be used?

Learning **how to think** is more valuable than memorizing frameworks or design patterns.

---

# Roadmap

## Phase 1

- [x] Solution Structure
- [x] Clean Architecture
- [x] Vertical Slice Architecture
- [ ] User Aggregate
- [ ] Create User
- [ ] Get User By Id
- [ ] List Users

---

## Phase 2

- [ ] Wallet Aggregate
- [ ] Financial Position
- [ ] Ledger
- [ ] Deposit Money
- [ ] Withdraw Money
- [ ] Transfer Money

---

## Phase 3

- [ ] Domain Events
- [ ] Event Storming
- [ ] Entity Framework Core
- [ ] PostgreSQL

---

## Phase 4

- [ ] RabbitMQ
- [ ] Outbox Pattern
- [ ] Saga Pattern
- [ ] Redis
- [ ] OpenTelemetry

---

## Phase 5

- [ ] Docker
- [ ] Unit Tests
- [ ] Integration Tests
- [ ] Production Hardening

---

# Solution Structure

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

# Technologies

- .NET
- ASP.NET Core
- C#
- Entity Framework Core
- PostgreSQL
- RabbitMQ
- Redis
- Docker

---

# Architecture

The project follows modern architectural principles, including:

- Clean Architecture
- Vertical Slice Architecture
- CQRS
- Rich Domain Model
- Domain-Driven Design (DDD)

The project intentionally starts simple and evolves incrementally, demonstrating how enterprise applications naturally grow over time.

---

# Documentation

Throughout the development journey, documentation will be added covering:

- Architectural decisions
- Business rules
- Domain modeling
- Event Storming
- Aggregate Roots
- BIAN concepts
- Architecture Decision Records (ADRs)

The goal is for developers to understand both **the implementation** and **the reasoning behind it**.

---

# YouTube Series

This repository accompanies a YouTube series where every feature is implemented from scratch.

Topics include:

- Why each file exists
- Layer responsibilities
- Enterprise architecture
- Common mistakes made by junior developers
- Best practices used in production systems

Rather than simply copying code, viewers are encouraged to understand the design decisions behind every implementation.

---

# Disclaimer

LearnBank is an educational project.

It does **not** aim to fully replicate the complexity of a production banking platform.

Instead, it uses the financial domain to demonstrate software engineering concepts that can be applied to many enterprise systems.

---

# Contributing

Contributions, suggestions, discussions, and constructive feedback are always welcome.

If you find the project useful, consider starring the repository and sharing it with other developers.

---

# License

This project is licensed under the MIT License.
