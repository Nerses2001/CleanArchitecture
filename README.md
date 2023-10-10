# CleanArchitecture
## Clean Architecture User Management

This project demonstrates a simple implementation of a user management system using the Clean Architecture approach. The application includes services, repositories, controllers, and data configurations.

## Project Structure

- `CleanArchitecture.Application.Services`: Contains the application services for user management.
- `CleanArchitecture.Domain.Repositories`: Defines the interfaces for user repository operations.
- `CleanArchitecture.Domain.Services`: Contains the interfaces for user services.
- `CleanArchitecture.Infrastructure.Data`: Manages the data layer and database context.
- `CleanArchitecture.Infrastructure.Data.Repositories`: Implements the user repository.
- `CleanArchitecture.Presentation`: Contains API controllers and presentation layer interfaces for user operations.
- `CleanArchitecture.Migrations`: Manages database migrations for user entity.

## Dependencies

- **ASP.NET Core**: Used for building the API.
- **Entity Framework Core**: Utilized for database interactions and migrations.
- **Swagger**: Integrated for API documentation.


## API Endpoints

- `POST /taskmanagment/user/creatuser`: Create a new user.
- `PUT /taskmanagment/user/updateuser/{username}`: Update an existing user.
- `DELETE /taskmanagment/user/deletuser/{username}`: Delete an existing user.

