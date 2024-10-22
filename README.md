# Vehicle Marketplace - ASP.NET Core Application

## Overview

This project is an ASP.NET Core web application that follows the MVC architecture with Razor Pages. It allows users to **buy and sell cars and motorcycles** through an easy-to-use platform. The application includes features for **authentication** and **authorization** to ensure that only registered users can perform transactions. 

The project is built with a **local database** for development, and it can be scaled to work with a larger SQL server in a production environment.

## Features

- **MVC Architecture**: The project follows the Model-View-Controller (MVC) pattern to separate concerns, making it easier to manage and maintain.
  
- **Razor Pages**: Razor is used to create dynamic web pages with a clean and efficient syntax.
  
- **Authentication and Authorization**: 
  - **Authentication**: Users must sign up and log in to access the platform's features.
  - **Authorization**: Only authorized users can create, edit, or delete listings for vehicles.
  
- **Vehicle Listings**: Users can post listings to sell cars and motorcycles, including adding details and images.

- **Search and Browse**: Visitors can browse available listings and search for specific vehicles based on model, price, and other attributes.

- **Local Database**: The app uses a **local database** (`localdb`) during development, which is managed through Entity Framework Core. The database contains tables for users, vehicle listings, and transactions.

## Setup

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- SQL Server or LocalDB for development

### Getting Started

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/vehicle-marketplace.git
    cd vehicle-marketplace
    ```

2. **Restore the dependencies**:
    ```bash
    dotnet restore
    ```

3. **Apply migrations and update the database**:
    ```bash
    dotnet ef database update
    ```

4. **Run the application**:
    ```bash
    dotnet run
    ```

5. Navigate to `https://localhost:5001` to see the app in action.

### Configuration

The app uses a local database (`localdb`) for development, as specified in the `appsettings.json` file. You can change the connection string if you're planning to use a different database server.

Example connection string for `localdb`:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=VehiclesDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
