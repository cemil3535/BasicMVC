# BasicMVC

Basic MVC
MVC Project
Task: Display Customer and Order Information
We are developing an application to display customer and order information using ASP.NET MVC by following the steps below.

Step 1: Creating the Model
Customer Model:

Create a Customer class.

Id (Unique ID of the customer, int type)

FirstName (Customer's name, string type)

LastName (Customer's last name, string type)

Email (Customer's email address, string type)

Order Model:

Create an Order class.

Id (Unique ID of the order, int)

ProductName (Name of the product, string)

Price (Price of the product, decimal)

Quantity (Quantity of the product ordered, int)

Step 2: Create the ViewModel
CustomerOrderViewModel Class:

Create a CustomerOrderViewModel class.

Customer (A Customer object)

Orders (A list of Order objects)

The ViewModel will hold the model data and any additional information needed to display in the view.

Step 3: Create the Controller
CustomerOrdersController:

Create a CustomerOrdersController class.

In this controller, create an action method called Index.

In the Index method:

Create a sample Customer object and several Order objects.

Create a CustomerOrderViewModel object using these objects.

Pass the CustomerOrderViewModel object to the view.

Step 4: Create View
Index View:

Create a view named Index.cshtml under the Views/CustomerOrders folder.

This view will display customer information and orders using the CustomerOrderViewModel.

In the View:

Display customer information (ID, first name, last name, email).

Create a table of orders and list order ID, product name, price, and quantity.

# Technology Used
ASP. Net
<br>
MVC Structure 
