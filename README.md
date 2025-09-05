#  Homework – CRUD with SQL Server

##  Project Overview
This project demonstrates how to implement CRUD operations (Create, Read, Update, Delete) in C# using a SQL Server database.  
The same database table is accessed with three different approaches:

- ADO.NET (traditional way using raw SQL queries)  
- Dapper (lightweight ORM)  
- Entity Framework Core (EF Core) (full ORM)  

This helps to understand the differences between low-level database access, micro-ORM, and full ORM.

---

## Database
We use a simple SQL Server database with a table (e.g., `Books`).  
This table contains fields like  Title, Author, price, and stock.  

##  Technologies Used
- **Programming Language:** C#
- **Database:** Microsoft SQL Server
- **ORM/Tools:**
  - ADO.NET
  - Dapper
  - Entity Framework Core

---

##  Features
This project demonstrates **CRUD operations** in three different ways:

- **Create** → Insert new records into the database  
- **Read** → Retrieve and display records from the database  
- **Update** → Modify existing records  
- **Delete** → Remove records from the database  

---

##  Learning Outcomes
- Understand how to connect a **C# application** with **SQL Server**  
- Learn differences between **ADO.NET**, **Dapper**, and **Entity Framework Core**  
- Gain experience in writing **clean and maintainable database access code**  
- Know when to use **raw SQL**, **micro-ORM**, or **full ORM** depending on project needs  

---

##  Summary
This project is designed as a **homework practice** to compare three approaches to database access in C#.  
It shows how to perform CRUD operations step by step and helps students understand **best practices** in real-world software development.
