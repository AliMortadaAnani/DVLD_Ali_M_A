# DVLD - Drivers and Vehicles License Department

## 🛠 Technology Stack
- .NET 8 (C#)
- WinForms
- Microsoft SQL Server (MSSQL)
- ADO.NET
- Git / GitHub

## 📦 Features
- User login with "Remember Me" functionality
- Full person and driver management
- Local and international license application processing
- License renewal and replacement
- Scheduling and tracking for written, vision, and driving tests
- Configurable image and settings storage via `config.ini`
- Input validation, user-friendly UI, and context menus

## 🧱 Architecture
- **3-tier architecture:**
  - DVLD_Presentation (UI layer - WinForms)
  - DVLD_Business (Business logic)
  - DVLD_Data (Data access via ADO.NET)
- **DVLD_General:** Shared layer for enums, data types, and managing `config.ini` (paths and DB connection string)

## ⚙️ Setup Instructions

1. **Restore Database:**
   - Use SQL Server Management Studio (SSMS)
   - Restore the provided `.bak` file to create the `DVLD` database (name can be changed if you update connection string)

2. **Update Configuration:**
   - Edit the `config.ini` file to set paths for:
     - Image storage folder
     - Remember Me file location
     - Database connection string (adjust for your system)

3. **Run the Application:**
   - Open the `.sln` file in Visual Studio 2022 or later
   - Build in `Release` mode
   - Run the app or use the executable located in:
     ```
     bin\Release\net8.0-windows\publish\
     ```

## 📁 Folder Structure

- `/DVLD_Presentation` — WinForms UI forms
- `/DVLD_Business` — Business logic layer
- `/DVLD_Data` — ADO.NET data access layer
- `/DVLD_General` — Shared data types, enums, and config management
- `config.ini` — Editable file for paths and database connection string

## 🧪 Developer Notes

- Executable `.exe` is inside the `publish` folder after build
- User images are saved with GUID filenames to ensure anonymity
- This application is intended for educational and demo purposes
- All icons and images used are royalty-free, sourced from:
  - [Pixabay](https://pixabay.com/)
  - [Unsplash](https://unsplash.com/)

---

