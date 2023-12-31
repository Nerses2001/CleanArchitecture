# CleanArchitecture
## Clean Architecture User Management

This project demonstrates a simple implementation of a user management system using the Clean Architecture approach. The application includes services, repositories, controllers, and data configurations.

## Project Structure

- Contains models:
  - `TaskDto`
  - `TaskEntity`
  - `TaskStatus`
  - `UserDto`
  - `UserEntity`
- Defines interfaces for repositories and services:
  - `ITaskRepository`
  - `IUserRepository`
  - `IGetUserRepository`
  - `ITaskService`
  - `IUserService`
  - `IGetUserService`

## Application Layer:
- Implements application services:
  - `TaskService`
  - `UserService`

## Infrastructure Layer:
- Manages the data layer and database context:
  - `DbAppContext`
- Implements repositories:
  - `TaskRepository`
  - `UserRepository`
- Contains configuration for entity models:
  - `TaskConfiguration`
  - `UserConfiguration`

## Presentation Layer:
- Includes API controllers:
  - `TaskController`
  - `UserController`
- Implements interfaces for task and user operations:
  - `ICreatTask`
  - `ICreatUser`
  - `IPutUser`
  - `IDeleteUser`

## Database Migrations:
- Manages database migrations:
  - `v1`
  - `v2`
  - `v3`
  - `v4`
  - `v5`
- Defines model snapshots and configurations for the database context.

## Interfaces:
- Contains interfaces for task and user operations:
  - `ICreatTask`
  - `IGetTask`
  - `ICreatUser`
  - `IPutUser`
  - `IDeleteUser`


## Dependencies

- **ASP.NET Core**: Used for building the API.
- **Entity Framework Core**: Utilized for database interactions and migrations.
- **Swagger**: Integrated for API documentation.


## API Endpoints

- `POST api/taskmanagment/user/creatuser`: Create a new user.
- `PUT api/taskmanagment/user/updateuser/{username}`: Update an existing user.
- `DELETE api/taskmanagment/user/deletuser/{username}`: Delete an existing user.

- `POST api/taskmanagment/task/creattask/{username}`: Create a new task for a user.
- `GET api/taskmanagment/task/getusertasks/{username}`: Get tasks for a user.
- `PUT api/taskmanagment/task/putusertask/{username}/{id}`: Update a task for a user.
- `DELETE api/taskmanagment/task/deleteusertask/{username}/{id}` Delete task for a user.

![Repository Pattern](Images/repository_pattern_image.png)

