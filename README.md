
# Simple Auction

**Simple Auction** is an ASP.NET Core project that provides a basic auction system. This project is designed to demonstrate the implementation of an auction platform where users can create, bid on, and manage auctions.

## Project Structure

- **Controllers**: Handles the logic and routing for different auction-related operations.
- **Models**: Contains the data models representing the entities used within the auction system.
- **Views**: Contains Razor views for rendering the UI.
- **Migrations**: Database migration files for setting up and managing the database schema.
- **wwwroot**: Static files including CSS, JavaScript, and images.

## Getting Started

To work with this project locally, follow these steps:

### Prerequisites

Ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any compatible database server

### Installation

1. **Clone the Repository**:
   ```bash
   git clone git@github.com:AvtRikki/Simple-Auction.git
   ```
2. **Navigate to the Project Directory**:
   ```bash
   cd Simple-Auction
   ```
3. **Restore Dependencies**:
   ```bash
   dotnet restore
   ```

### Running the Project

1. **Apply Migrations and Update Database**:
   ```bash
   dotnet ef database update
   ```
2. **Run the Project**:
   ```bash
   dotnet run
   ```

The application will be hosted on `https://localhost:5001/` by default.

## Contributing

Contributions are welcome! Please fork this repository and submit pull requests for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
