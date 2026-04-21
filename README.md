# DeliveryProject 📦

A professional Backend Web API for delivery management systems, built with **ASP.NET Core (.NET 8)**.  
Demonstrates modern software architecture patterns focused on scalability, security, and maintainable code.

---

## 🚀 Key Features

- **Clean Architecture** – Divided into logical layers (Core, Data, Service, API) with clear separation of concerns
- **Advanced Middleware** – Custom `ShabbatMiddleware` showcasing deep understanding of the ASP.NET Core request pipeline
- **Security** – JWT Bearer Authentication to secure sensitive API endpoints
- **Data Integrity** – Entity Framework Core with Repository Pattern for efficient data access
- **DTO Mapping** – AutoMapper to decouple domain models from external data structures
- **API Documentation** – Interactive Swagger UI for streamlined testing and integration

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Backend | C# \| ASP.NET Core 8.0 |
| Database | SQL Server |
| ORM | Entity Framework Core |
| Libraries | AutoMapper, JWT Authentication, Swagger |

---

## 🏗️ Project Structure

    DeliveryProject/
    ├── Delivery.Core       # Domain entities, DTOs, interfaces, mapping profiles
    ├── Delivery.Data       # DB context, migrations, repository implementations
    ├── Delivery.Service    # Business logic and service layer
    └── DeliveryProject     # Controllers, middlewares, configurations

---

## 🏁 Getting Started

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022
- SQL Server

### 1. Database Setup
Open Package Manager Console and run:

    Update-Database

### 2. Configure JWT & Connection String
Update `appsettings.json` in the `DeliveryProject` folder:

    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=DeliveryDb;Trusted_Connection=True;"
    },
    "JWT": {
      "Issuer": "your-issuer",
      "Audience": "your-audience",
      "Key": "your-secure-32-character-secret-key"
    }

### 3. Run the API

    dotnet run --project DeliveryProject

---

## 🛡️ License
Distributed under the **MIT License**. See `LICENSE` for more information.
