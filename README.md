# Car Rental API (RentACar - N-Tier Architecture)

This project was built according to the main capstone for the **"Software Developer Training Camp" (Engin Demiroğ)** in 2024. This car rental backend service designed to demonstrate enterprise application development principles. This projects also demonstrates building scalable and maintainable applications using a clean **N-Tier (Layered Architecture)**, .NET 8, Entity Framework Core, and SOLID principles.

## Main Features

* **N-Tier (Layered) Architecture:** The project is strictly divided into 4 separate layers (Entities, DataAccess, Business, WebAPI), each with a single responsibility.
* **Repository Design Pattern:** Implements the Repository Pattern in the DataAccess layer to abstract and manage all database (CRUD) operations.
* **Code-First Database:** Uses Entity Framework Core with migrations to define, create, and manage the database schema directly from C# models.
* **Dependency Injection:** Employs Dependency Injection (DI) to decouple layers. The WebAPI layer communicates with interfaces (`IBusiness`), not concrete classes, promoting SOLID principles.
* **Business Logic Encapsulation:** All business rules and validations (e.g., "Brand name cannot be shorter than 2 characters") are isolated within the `Business` layer.

## Technology Used

* **Framework:** .NET 8 (ASP.NET Core Web API)
* **Architecture:** N-Tier (Layered Architecture)
* **Principles:** SOLID, Clean Code
* **ORM:** Entity Framework Core 
* **Design Pattern:** Repository Design Pattern
* **Database:** MS SQL Server
* **Tools:** Swagger (OpenAPI), Dependency Injection

## How to Use

1.  Clone or download the repository.
2.  Open the `RentACar.sln` file with Visual Studio 2022.
3.  **Important:** Before running, you must create the database. Open the **Package Manager Console**, select `DataAccess` as the **Default project**, and run the command: `Update-Database`.
4.  Run the `WebAPI` project (Press F5). The browser will automatically open the Swagger UI.
5.  Use the `POST /api/Brands` endpoint to add a new brand (e.g., `{ "name": "BMW" }`).
6.  Use the `GET /api/Brands` endpoint to verify that the new brand was successfully added to the database.
