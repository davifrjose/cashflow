# About the project

This API, developed using **.NET 7**, adopts the principles of **Domain-Driven Design (DDD)** to offer a structured and effective solution for managing personal expenses. The main objective is to allow users to record their expenses, detailing information such as title, date and time, description, amount and payment type, with the data being stored securely in a **MySQL** database.

The **API** architecture is based on **REST**, using standard **HTTP** methods for efficient and simplified communication. Furthermore, it is complemented by **Swagger** documentation, which provides an interactive graphical interface so that developers can easily explore and test endpoints.

Among the NuGet packages used, **AutoMapper** is responsible for mapping between domain objects and request/response, reducing the need for repetitive and manual code. **FluentAssertions** are used in unit tests to make checks more readable, helping you write clear and understandable tests. For validations, **FluentValidation** is used to implement validation rules in a simple and intuitive way in request classes, keeping the code clean and easy to maintain. Finally, the **EntityFramework** acts as an ORM (Object-Relational Mapper) that simplifies interactions with the database, allowing the use of .NET objects to manipulate data directly, without the need to deal with SQL queries.
