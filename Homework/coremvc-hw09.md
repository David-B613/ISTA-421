# David Babers
## Core MVC Chapter 9
## March April 5th, 2020
1. In the Configure() method of the Startup.cs file, note the four map routes defined in the book.
   What is the difference in the definitions of the four routes defined? How are the routes ordered? Why does it matter that the routes are ordered this way?
*  / lists the first page
* /Page2 lists the specified page
* /Soccer shows the first page of items from a specific category
* /Soccer/Page2 shows the specified page of items from the specified category
*  The routes are applied in the order in which they are defined.
* You will get odd effects if you change the order

2. When you define tag helpers, you can specify a prefix for the attribute name. What happens when you define several attributes with the same prefix?
 What is the benefit of doing this?

* All of them are received all together within a single collection.    
* You don't have to re-state the tag helpers in a different collection.

3. How does using the attribute page-url-category benefit the application? Be specific with your answer and give an example.
* The value of any attribute whose name begins with the prefix will be added to the dictionary that is assigned.

4. What is a view component and what purpose do view components have in building a web application?
* A view component is a c# class that provides a small amount of reusable application logic with the ability to select and display RAzor partial views.

5. The book notes that you can build a list of categories programmatically or use the "\more expressive Razor syntax" to render the HTML. What do you think that this means?
* You can build a list using C# language and object oriented programming.

6. What does @await Component.InvokeAsync("InformationSidebar") do?
* View components are initialized through @await Component.InvokeAsync("InformationSidebar")
1. Describe the functionality of the RouteData property of the ViewComponent class, and give a concrete example of that functionality.
* Provides info about how the request URl was handled by the routing system.  The RouteData property is used to access the request data in order to get the value for the currently selected category in a list.

7. What is the purpose of session state, and how does the Sports Store application use session state?
* The data stored at the server and associated with a series of requests made by a user.
* To store the details of the user's cart

8. Describe model binding and give a specific example. Explain how model binding relates form elements, HTTP query requests, variables, and properties.
* Instead of writing code to retrieve values from forms and route data manually, Model binding automates the process.
* Model binding retrieves data from various sources such as route data, provides the data to controllers and razor pages in method parameters and public properties, converts string data to .NET types, and updates properties of complex types.

9. What does the RedirectToAction() method do?
* This method is used to redirect to specified action instead of rendering the HTML.

10. What does the RedirectToAction() method do?

* This has the effect of sending an HTTP redirect instruction to the client browser, asking the browser to request a new URL.
