# Crazy Musicians API

## Overview
This project demonstrates how to build an **ASP.NET Core Web API** with basic CRUD functionality for a dataset containing funny and entertaining musician records.

---

## Features
- **CRUD Operations:**
  - Retrieve a list of all musicians.
  - Retrieve a specific musician by ID.
  - Add a new musician record.
  - Update an existing musician record (using `PUT` or `PATCH`).
  - Delete a musician record.
- **Search Endpoint:**
  - A `GET` endpoint that uses `[FromQuery]` to filter musicians based on their attributes (e.g., name or instrument).
- **Routing:**
  - Routes are designed based on best practices and resemble the structure used in the **Galactic Tour** application.

---

## Endpoints
| HTTP Method | Endpoint                              | Description                                       |
|-------------|---------------------------------------|---------------------------------------------------|
| GET         | `/api/musicians`                     | Retrieve all musicians.                          |
| GET         | `/api/musicians/{id}`                | Retrieve a musician by their ID.                 |
| GET         | `/api/musicians/search?name={name}`  | Search musicians by name (uses `[FromQuery]`).   |
| POST        | `/api/musicians`                     | Add a new musician record.                       |
| PUT         | `/api/musicians/{id}`                | Update an existing musician's details completely.|
| PATCH       | `/api/musicians/{id}`                | Partially update a musician's details.           |
| DELETE      | `/api/musicians/{id}`                | Delete a musician by their ID.                   |

---

## Validation
Proper validation rules are implemented to ensure data integrity:
- Required fields for musician properties.
- Validation for unique IDs.
- Ensuring input values adhere to the expected formats.

---

## Data
The API uses a sample dataset of **"Crazy Musicians"** with the following attributes:
- `Id` (integer): Unique identifier.
- `Name` (string): Name of the musician.
- `Instrument` (string): The musician's specialty or role.
- `YearsActive` (integer): The number of years the musician has been active.
- `Description` (string): A fun and quirky description of the musician.

---

## Setup Instructions
1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd CrazyMusiciansAPI
   ```
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
3. Build the project:
   ```bash
   dotnet build
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
5. Access the API through Swagger at `https://localhost:<port>/swagger`.

---

## Technologies Used
- **ASP.NET Core 8.0**
- **C#**
- **Swagger/OpenAPI** for API documentation.

---

## Future Enhancements
- Add support for pagination in the GET endpoints.
- Implement sorting and advanced filtering options.
- Add integration tests for the API.


___

## Referances

- https://www.postman.com/downloads/
- https://developer.mozilla.org/en-US/docs/Web/HTTP/Status
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio#overview
- https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-8.0 Cors

- https://cdnjs.com/libraries/bootstrap (bootsrap cdn)
Bu dosya Bootstrap CSS kütüphanesini kullanmak için aşağıdaki kodu içerir:

```html
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.3/css/bootstrap.min.css" integrity="sha512-jnSuA4Ss2PkkikSOLtYs8BlYIeeIK1h99ty4YfvRPAlzr377vr3CXDb7sb7eEEBYjDtcYj+AjBH3FLv5uSJuXg==" crossorigin="anonymous" referrerpolicy="no-referrer" />





