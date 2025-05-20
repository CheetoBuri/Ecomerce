# Ecomerce
- Github link: https://github.com/CheetoBuri/Ecomerce
- Initialize database
  Open SQLQuery.sql in SQL Server Manager, connect server "DESKTOP-U42VAIR\SQLEXPRESS" and run
  Open Powershell or Command prompt and run these line for ASPNETCoreWebAppMVc:
   - dotnet ef migrations add InitialCreate
   - dotnet ef database update
- Running the program
  Click on Project -> Configure Startup Project -> Choose the program you want to run
