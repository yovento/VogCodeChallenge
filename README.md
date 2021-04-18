## VOG-Challenge

Hello there! I’m **John**, hope this project can help you to learn something or maybe as an start for future projects.

Feel free to grab this code and work on it, if it helps you please don't forget to leave a star.

Let me present this repo.


## The Repo


This is a DotNet Core application that I developed to solve a challenge that I found in the internet which from my opinion evaluates many different aspects of .Net Backend Development and some others about Docker Files and Docker Compose, these are the tasks included in the challenge:

1. Start an empty solution. Create an ASP.Net Core Web Application. Choose ASP .NET Core 3.1 and API for the template of the project. Configure the HTTPS on the API project.
Follow the given patterns to name the solution: <<yourname>>_vog_backend_codechallenge
Follow the given patterns to name the project: VogCodeChallenge.API

2.	Prepare a supporting architecture (classes/entities) for the following situation. With having the concept of reusability in mind.
We have an application that requires to show the list of departments in the company to the company manager. Each department will have a name and a unique address.
Departments are consisting of employees. Like a regular employee they will have, first name, last name, job title and address of residence (mailing address) 

3.	Define a service Implementation for the following functionality.
For Employees we need to have these functionalities. The method signatures should be exactly the same as follows:
IEnumerable<Employee> GetAll()
IList<Employee> ListAll()
Since we are not using a database, provide 2-3 test data.

4.	Provide a RESTful API controller for employees and provide these two endpoints.
GET	api/employees
GET	api/employees/department/{departmentId}

5.	Add the docker and docker compose support to the solution and API project.

6.	Imagine we are connected to the Database now. We’d like to switch from in Memory implementation of Employee service to the database implementation. Suggest and apply a way to switch from your previous implementation to the new one and consider the methods you implemented before.
IEnumerable<Employee> GetAll()
IList<Employee> ListAll()
** Database and Entity Framework implementation is not required. 

7.	Add a console project to the solution. Add this class to the console project.
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };
    }
Iterate through the NamesList items without using ForEach/For loops.

8.	Create a method called TESTModule, this method simply is a method that we pass values to it and it returns the result.
With one Switch Statement, cover the provided requirements.
A. For integer values of 1,2,3,4 multiply the provided value by 2 and return the result.
B. For any integer value bigger than 4, multiply the provided value by 3 and return the result.
C. for integer values below 1, throw proper exception.
D. For float values of 1.0f and 2.0f return 3.0f
E. For any string values convert them to UpperCase.
F. for anything else, return the input value itself.

## The implementation
This solution has implemented the following patterns/technologies:

* ASP.Net Core WebApi
* ASP.Net Core Console Application
* Entity Framework (InMemory and Persistent providers)
* Domain Repository Pattern
* Docker File
* Docker Compose

## Each step is a tag
You will find the solution and how the code was growing through the different steps of this challenge with a tag in the source code, each tag corresponds to a step in the challenge.

