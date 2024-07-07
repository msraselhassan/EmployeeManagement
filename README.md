# Employee Management Application

This Employee Management application is a personal passion project, focused on managing department-wise employee information using ASP.NET Core Web API and implementing the Repository pattern for clean and maintainable code architecture.

## Overview of the Project

### Goals:
- **Manage Employees:** Add, update, delete, and view employee information.
- **Organize by Departments:** Categorize employees by departments.
- **Follow Best Practices:** Use the Repository pattern for data access.

## Project Setup

### Prerequisites:
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)

### Getting Started

1. **Clone the repository:**
    ```bash
    git clone https://github.com/your-username/employee-management.git
    cd employee-management
    ```

2. **Set up the backend:**
    - Navigate to the `EmployeeManagement.API` directory.
    - Update the `appsettings.json` file with your SQL Server connection string.
    - Run the following commands to build and run the API:
      ```bash
      dotnet restore
      dotnet build
      dotnet run
      ```

3. **Set up the frontend:**
    - Navigate to the `EmployeeManagement.UI` directory.
    - Install dependencies and start the Angular application:
      ```bash
      npm install
      ng serve
      ```

## Project Structure

### Backend (ASP.NET Core Web API)

- **Models:** Defines the data structures (e.g., Employee, Department).
- **Repositories:** Implements the Repository pattern for data access.
- **Controllers:** API endpoints to handle CRUD operations.

### Frontend (Angular)

- **Components:** UI components for displaying and managing data.
- **Services:** Handles communication with the backend API.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or feedback, please reach out to [your-email@example.com](mailto:your-email@example.com).
