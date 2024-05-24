# About the project

This API, developed using **.NET 7**, adopts the principles of **Domain-Driven Design (DDD)** to offer a structured and effective solution for managing personal expenses. The main objective is to allow users to record their expenses, detailing information such as title, date and time, description, amount and payment type, with the data being stored securely in a **MySQL** database.

The **API** architecture is based on **REST**, using standard **HTTP** methods for efficient and simplified communication. Furthermore, it is complemented by **Swagger** documentation, which provides an interactive graphical interface so that developers can easily explore and test endpoints.

Among the NuGet packages used, **AutoMapper** is responsible for mapping between domain objects and request/response, reducing the need for repetitive and manual code. **FluentAssertions** are used in unit tests to make checks more readable, helping you write clear and understandable tests. For validations, **FluentValidation** is used to implement validation rules in a simple and intuitive way in request classes, keeping the code clean and easy to maintain. Finally, the **EntityFramework** acts as an ORM (Object-Relational Mapper) that simplifies interactions with the database, allowing the use of .NET objects to manipulate data directly, without the need to deal with SQL queries.

### Features

- **Domain-Driven Design (DDD)**: Modular structure that facilitates understanding and maintenance of the application domain.
- **Unit Testing**: Comprehensive testing with FluentAssertions to ensure functionality and quality.
- **Report Generation**: Ability to export detailed reports to **PDF** and **Excel**, offering a visual and effective analysis of expenses.
- **RESTful API with Swagger Documentation**: Documented interface that makes integration and testing easier for developers.

## Getting Started

To get a working local copy, follow these simple steps.

### Requirements

* Visual Studio versão 2022+ ou Visual Studio Code
* Windows 10+ ou Linux/MacOS with [.NET SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks) installed
* MySql Server

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/davifrjose/cashflow.git
   ```
2. Fill in the information in the `appsettings.Development.json` file.
3. Run the API and enjoy your testing :)

