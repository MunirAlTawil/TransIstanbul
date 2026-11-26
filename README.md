# TransIstanbul – Public Transport Card Management System

An **ASP.NET Core MVC** web application that simulates the public transport card system of Istanbul.

Designed and developed by **Muhammed Munir Al Tawil** in 2020 as the final project of my **Pearson BTEC Level 5 HND in Computing** (Advanced Programming). The application was deployed to a public ASP.NET hosting environment with a SQL Server database.

## Features

### Admin area
- Create and list **three card types**, stored in **SQL Server**:
  - **Istanbulkart** – customer name, customer ID, customer type and balance
  - **Blue Card** (Mavi Kart) – customer name, customer ID and points
  - **Electronic Card** – card price and points

### Customer area
- Simulate a trip by **vehicle type** (**Bus** or **Metrobus**)
- Fare calculation by **customer type** (*full fare*, *student*, *teacher*)
- **Transfers:** tiered prices depending on the number of transfers
- **Metrobus:** price depending on the number of stops
- Shows the **deducted amount** and the **remaining balance or points**

## Architecture

- **MVC pattern** with separate controllers and views for the admin and customer areas (`AdminController`, `CustomerController`)
- **Entity Framework Core 5** with a `DbContext` and **code-first migrations** for SQL Server
- **Object-oriented design:** abstract base class `Card` with inheritance for `IstanbulCard`, `BlueCard` and `ElectronicCard`
- **Business logic** separated into dedicated classes (`IstanbulMethods`, `BlueMethods`, `ElectronicMethods`)
- **Enums** for vehicle and customer types
- Responsive UI with **Razor views** and **Bootstrap**

## Tech Stack

- C#
- ASP.NET Core 3.1 MVC
- Entity Framework Core 5 (SQL Server)
- Razor Views, Bootstrap, HTML, CSS, JavaScript

## Getting Started

1. Clone the repository
2. Open `TransIstanbul.sln` in **Visual Studio**
3. Configure the database connection:
   - By default the app uses **SQL Server Express LocalDB**:
     `Server=(localdb)\MSSQLLocalDB;Database=TransIstanbul;Trusted_Connection=True;`
   - Or set the environment variable `TRANSISTANBUL_DB` to your own connection string
4. Create the database in the **Package Manager Console**:
   ```
   Update-Database
   ```
5. Run the project with **F5**

## Credits

The admin UI is based on the free **Purple Admin** Bootstrap template by BootstrapDash.

## Author

**Muhammed Munir Al Tawil**
- GitHub: [MunirAlTawil](https://github.com/MunirAlTawil)
- LinkedIn: [munir-al-tawil](https://www.linkedin.com/in/munir-al-tawil)
