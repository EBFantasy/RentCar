# RentCar

Group SE2-12

The goal of this project is to simulate the working of a Car Rental informatic system for our Software Systems Architectures project.



## StartUP

Install all required dependencies at once (usually only the following libraries need to be installed)
1. Net (version 6.0 and above)
2. Install the Npgsql dependencies

**use command : dotnet run --project "project root path"**



## Operation

For access the website: write https://localhost:7257/swagger/index.html in the address bar

Call and view the API interface: Upon entering the Swagger homepage, you will see featured modules such as "USERS" and "CARS." Upon selecting a module, its contents will be displayed, including options for functions like "GET," "POST," and "DELETE." Select one, click "Try it out," and then "Execute." You can then view the corresponding formatted data from the API interface.



## Viewing

In the display, you will see:

- Request link: API address 
- Status code: indicating the result of the returned status of the request (e.g. 200 for a successful request, 404 for not finding the corresponding webpage or data). 
- Request body: where you can input data you want to add (this function is effective in **POST** or **PUT**, and must be written in the given format). 
- Details: where you can view the detailed return results.
