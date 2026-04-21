DeliveryProject 📦
A professional Backend Web API for delivery management systems, built with ASP.NET Core (.NET 8). This project demonstrates the implementation of modern software architecture patterns, focused on scalability, security, and maintainable code.

🚀 Key Features
Clean Architecture: Divided into logical layers (Core, Data, Service, API) to ensure a clear separation of concerns.
Advanced Middleware: Custom ShabbatMiddleware implementation, showcasing deep understanding of the ASP.NET Core request pipeline.
Security: Integrated JWT Bearer Authentication to secure sensitive API endpoints.
Data Integrity: Utilizes Entity Framework Core with the Repository Pattern for efficient data access.
DTO Mapping: Comprehensive use of AutoMapper to decouple domain models from external data structures.
API Documentation: Interactive documentation using Swagger UI for streamlined testing and integration.
🛠️ Tech Stack
Backend: C# | ASP.NET Core 8.0
Database: SQL Server
ORM: Entity Framework Core
Libraries: AutoMapper, JWT Authentication, Swagger
🏗️ Project Structure
Delivery.Core: Domain entities, DTOs, interfaces, and mapping profiles.
Delivery.Data: Database context, migrations, and repository implementations.
Delivery.Service: Business logic and service layer.
DeliveryProject (API): Controllers, custom middlewares, and configurations.
🏁 Getting Started
Prerequisites
.NET 8 SDK
Visual Studio 2022
SQL Server

Database Update: Open the Package Manager Console in Visual Studio and run:
Update-Database
Configure JWT & Connection String: Update the appsettings.json file in the DeliveryProject folder:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=DeliveryDb;Trusted_Connection=True;"
},
"JWT": {
  "Issuer": "your-issuer",
  "Audience": "your-audience",
  "Key": "your-secure-32-character-secret-key"
}
Run the API: Press F5 in Visual Studio or run:
dotnet run --project DeliveryProject
🛡️ License
Distributed under the MIT License. See LICENSE for more information.
