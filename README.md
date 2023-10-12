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

- `POST api/taskmanagment/task/creattask/{username}`: Create a  user new task.
- `GET api/taskmanagment/task/getusertasks/{username}`: Get  user tasks.
![Repository Pattern](Images/repository_pattern_image.png)
## Swagger (OpenAPI) Documentation

The Swagger (OpenAPI) documentation for the API endpoints can be found below.
``` json {
  "openapi": "3.0.1",
  "info": {
    "title": "CleanArchitecture",
    "version": "1.0"
  },
  "paths": {
    "/api/taskmanagment/Task/creattask/{username}": {
      "post": {
        "tags": [
          "Task"
        ],
        "parameters": [
          {
            "name": "username",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/TaskDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/TaskDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/TaskDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/taskmanagment/Task/getusertasks/{username}": {
      "get": {
        "tags": [
          "Task"
        ],
        "parameters": [
          {
            "name": "username",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/taskmanagment/User/creatuser": {
      "post": {
        "tags": [
          "User"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/UserDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/UserDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/UserDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/taskmanagment/User/updateuser/{username}": {
      "put": {
        "tags": [
          "User"
        ],
        "parameters": [
          {
            "name": "username",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/UserDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/UserDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/UserDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/taskmanagment/User/deleteuser/{username}": {
      "delete": {
        "tags": [
          "User"
        ],
        "parameters": [
          {
            "name": "username",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "TaskDto": {
        "required": [
          "description",
          "dueDate",
          "name",
          "status"
        ],
        "type": "object",
        "properties": {
          "name": {
            "maxLength": 100,
            "minLength": 1,
            "type": "string"
          },
          "description": {
            "maxLength": 1000,
            "minLength": 1,
            "type": "string"
          },
          "dueDate": {
            "type": "string",
            "format": "date"
          },
          "status": {
            "$ref": "#/components/schemas/TaskStatus"
          }
        },
        "additionalProperties": false
      },
      "TaskStatus": {
        "enum": [
          0,
          1,
          2
        ],
        "type": "integer",
        "format": "int32"
      },
      "UserDto": {
        "required": [
          "email",
          "lName",
          "name",
          "pNumber",
          "userName"
        ],
        "type": "object",
        "properties": {
          "userName": {
            "maxLength": 30,
            "minLength": 1,
            "type": "string"
          },
          "name": {
            "maxLength": 30,
            "minLength": 1,
            "type": "string"
          },
          "lName": {
            "maxLength": 30,
            "minLength": 1,
            "type": "string"
          },
          "email": {
            "maxLength": 100,
            "minLength": 1,
            "type": "string",
            "format": "email"
          },
          "pNumber": {
            "minLength": 1,
            "pattern": "\\+374\\d{9}",
            "type": "string"
          }
        },
        "additionalProperties": false
      }
    }
  }
}
```