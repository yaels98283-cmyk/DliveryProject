---

## 🏁 Getting Started

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022
- SQL Server

### 1. Database Setup
Open **Package Manager Console** in Visual Studio and run:
```bash
Update-Database
```

### 2. Configure JWT & Connection String
Update `appsettings.json` in the `DeliveryProject` folder:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=DeliveryDb;Trusted_Connection=True;"
},
"JWT": {
  "Issuer": "your-issuer",
  "Audience": "your-audience",
  "Key": "your-secure-32-character-secret-key"
}
```

### 3. Run the API
Press **F5** in Visual Studio, or run:
```bash
dotnet run --project DeliveryProject
```

---

## 🛡️ License
Distributed under the **MIT License**. See `LICENSE` for more information.
