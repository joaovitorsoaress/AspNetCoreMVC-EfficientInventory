# EfficientInventory

This is a simple ASP.NET MVC project for managing product inventory. It allows users to manage stock levels, add suppliers and products, and generate reports on stock levels.

## Features

- **CRUD for Products and Suppliers**
- **Stock Control**: Manage product entries and exits.
- **Stock Reports**: Generate reports showing current stock and low-quantity products.
- **Low Stock Alerts**
- **Data Export**: Export stock reports to Excel or PDF.

## Technologies Used

- **ASP.NET MVC 5**
- **C#**
- **Entity Framework** (ORM)
- **SQL Server**
- **Bootstrap** (responsive UI)
- **jQuery**
- **Rotativa** (PDF export)

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/joaovitorsoaress/EfficientInventory.git

2. Open the project in Visual Studio.

3. Set up the database:
   - Update the connection string in `web.config`.
   - Run migrations to create the database:
     ```bash
     Update-Database
     ```

4. Run the project in Visual Studio.

## Future Improvements

- Add authentication and authorization.
- Dashboard with stock insights and charts.
- API integration for supplier orders.
- More detailed reports.

## License

This project is licensed under the MIT License.
