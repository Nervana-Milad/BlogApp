# 🚀 SyncSyntax Blog Application

A full-featured Blog Web Application built with ASP.NET Core MVC (.NET 8), demonstrating real-world backend development, authentication, role management, file uploads, and responsive UI.

---

## ✨ Features

### 📝 Posts

* Create, Edit, Delete, and View blog posts
* Post details page with comments
* Category filtering

### 📂 Categories

* Each post belongs to a category
* Dropdown selection when creating/editing posts

### 💬 Comments

* Users can add comments to posts
* AJAX-based submission (no page reload)
* Timestamped comments

### 🖼️ Image Upload

* Upload feature image per post
* Server-side validation for file types
* Unique file naming using GUID
* Automatic cleanup of old images

### 🔐 Authentication & Authorization

* ASP.NET Core Identity
* User registration & login
* Role-based access (Admin-only features)
* Admin role seeded at startup
* Cookie-based authentication

### 🎨 Responsive UI

* Bootstrap + Bootswatch theme
* Shared layout with partial views
* Mobile-friendly design

---

## 🛠️ Tech Stack

**Backend**

* ASP.NET Core MVC (.NET 8)
* Entity Framework Core (Code First)
* SQL Server
* ASP.NET Core Identity

**Frontend**

* Razor Views
* Bootstrap (Bootswatch theme)
* jQuery
* AJAX

---

## 🧠 Architecture & Concepts Used

* MVC Pattern
* Dependency Injection
* ViewModels
* LINQ Queries
* Eager Loading (Include)
* AsNoTracking for performance
* Environment-based middleware pipeline
* File handling with IWebHostEnvironment

---

## ⚙️ Getting Started

### Prerequisites

* .NET 8 SDK
* SQL Server
* Visual Studio 2022 or VS Code

---

### Installation

1. Clone the repository

```bash
git clone https://github.com/your-username/SyncSyntax.git
```

2. Navigate to the project folder

```bash
cd SyncSyntax
```

3. Update the connection string in:

```
appsettings.json
```

4. Apply migrations & create database

```bash
Update-Database
```

5. Run the application

```bash
dotnet run
```

---

## 👑 Default Admin Account

```
Email: admin@gmail.com
Password: admin
```

(Seeded automatically at startup)

---

## 🌐 Live Demo

👉 Coming Soon

---

## 📸 Screenshots

<img width="1919" height="1021" alt="image" src="https://github.com/user-attachments/assets/40ac3aaa-e387-4d27-8e25-5c9e0543a834" />
<img width="1920" height="1009" alt="image" src="https://github.com/user-attachments/assets/c827a3fb-ab8d-445f-ab68-c16bb8082549" />


---

## 📌 Future Improvements

* Tags & search functionality
* Pagination
* API version
* Deployment & CI/CD

---

## 👩‍💻 Author

**Nervana**
Backend Developer (.NET)

---

⭐ If you like this project, consider giving it a star!
