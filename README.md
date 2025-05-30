# DVLD - Drivers and Vehicles License Department

## 🛠 Technology Stack

* .NET 8 (C#)
* WinForms
* Microsoft SQL Server (MSSQL)
* ADO.NET
* Git / GitHub

## 📦 Features

* User login, "Remember Me" functionality
* Full person and driver management
* Local and international license processing
* License renewal and replacement
* Written, vision, and driving test scheduling and tracking
* Configurable image and settings storage via `config.ini`
* Input validation, user-friendly UI, context menus

## 🧱 Architecture

This is a **3-tier architecture** project with an additional shared/general layer:

* `DVLD_Presentation` – UI layer using WinForms
* `DVLD_Business` – Business logic and operations
* `DVLD_Data` – Data access layer (ADO.NET)
* `DVLD_DataTypes` *(internally used as `DVLD_General`)* – Shared layer for:

  * Enums
  * `config.ini` settings
  * Shared types
  * Asset storage (`RememberMe.txt`, user images)

## 📁 Folder Structure

* `/DVLD_Presentation` – Forms and UI
* `/DVLD_Business` – Business operations and classes
* `/DVLD_Data` – SQL operations using ADO.NET
* `/DVLD_DataTypes` (aka `DVLD_General`)

  * `Assets/RememberMe.txt` – Stores "Remember Me" data
  * `Assets/AppImages/` – Stores person images by GUID
  * `config.ini` – Central configuration file

## ⚙️ Setup Instructions

1. **Restore Database**

   * Open SQL Server Management Studio (SSMS)
   * Restore the provided `.bak` file to create the `DVLD` database
   * You can restore it with any name, just make sure to update it in `config.ini`

2. **Update Configuration**

   * Go to `DVLD_DataTypes/config.ini`
   * Configure these entries:

     ```
     [Paths]
     RememberMePath=Assets\RememberMe.txt
     ImageFolderPath=Assets\AppImages

     [Database]
     ConnectionString=Server=.;Database=DVLD;Trusted_Connection=True;TrustServerCertificate=True;
     ```
   * The paths are project-relative, so they will work out of the box
   * The connection string uses Windows Authentication (`Trusted_Connection=True`), which works for most systems with local SQL Server installed

3. **Run the Application**

   * Open the solution file `.sln` in Visual Studio 2022+
   * Build and run the project
   * All required files (`RememberMe.txt`, image folder, config) are included in the project

## 📝 Notes for Developers

* Executable is located in:
  `bin\Release\net8.0-windows\publish\`
* Person images are saved using GUID names for uniqueness
* No need to manually create folders or paths — everything is within the project
* All icons and images used are royalty-free from [Pixabay](https://pixabay.com) and [Unsplash](https://unsplash.com)

## 🧠 Important
* The database schema , sql scripts for creating tables, project requirements were all given by the instructor. 
* **Restoring the database is required** before using the app
* If the database name is not `DVLD`, **update the name in** `config.ini`'s connection string
* If you're using SQL authentication or a remote server, update the connection string accordingly

---

Let me know if you want this as a `.md` file to include in the repo directly.
