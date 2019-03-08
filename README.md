# Back-end developer challenge

Create a .NET Core (version 2.2 or higher) RESTful API with the following exposed actions:
* Create and persist a new company with the following mandatory fields:
    * Id (Guid)
    * Name (string)
    * URL (string)
    * Email (string)
* Update an existing company;
* Delete an existing company;
* Get an existing company by its identifier;
* Get a paged list of companies (query parameters are page and page size) where the response contains the following information:
    * the total count of persisted companies;
    * the companies on the requested page.

Some additional requirements on the created service:
* The solution has to build without errors with the command "dotnet build";
* The solution should be executing without errors with the command "dotnet run";
* The service needs to be production ready.

Some additional notes:
* You can use any persistence layer and database, just provide some details on how to run the solution in this file;
* You can use whatever code editor you want;
* We expect you to spend a maximum of about 2 hours on this challenge. If you can't do everything in this time then please provide pseudocode showing how you would implement the missing features; 
* Feel free to provide pseudocode for additional improvements!
