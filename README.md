# CI/CD Integration in .NET 8 & React with TypeScript Project

## Introduction
This project demonstrates the implementation of Continuous Integration (CI) and Continuous Delivery (CD) practices in a modern software development environment. Focusing on a project that utilizes a React frontend with TypeScript and a .NET 8 ASP.NET Core Web API backend, this report outlines the architecture, CI/CD processes, and the benefits of implementing such methodologies. Designed to streamline development processes, ensure code quality, and facilitate quicker releases, this project serves as a practical example of leveraging CI/CD for efficient software delivery.

## Project Architecture
The project is structured into four main components for ease of integration and delivery:
- **WebApp.API**: Acts as the entry point for user requests, delegating data processing to the business logic layer.
- **WebApp.Core**: Contains business logic definitions and data models used by the API.
- **WebApp.Infrastructure**: Implements the data access logic defined in Core, facilitating interactions with external services or databases.
- **WebApp.Tests**: Includes tests for API components and services, ensuring code quality and correctness.

## CI/CD Implementation
### CI for .NET Backend
Utilizing GitHub Actions, automatic builds and tests are triggered for the backend with every push or pull request to the main branch. The workflow includes:
- Restoring dependencies with `dotnet restore`.
- Building the project with `dotnet build`.
- Running unit tests with `dotnet test`.

### CI for React Frontend
A similar CI process is set up for the frontend:
- Installing dependencies with `npm install`.
- Running tests with `npm test`.
- Building the project with `npm run build`.

These steps ensure that changes are properly integrated and ready for deployment.
