# BFM1
First C# Project for WGU. This was a very basic WInForms inventory management application for a bikeshop. The key take-aways from this class were OOP concepts. 

## I. GUI

A. A main form, showing the following controls: 
- Buttons for “Add,” “Modify,” “Delete,” “Search” for parts and products, and “Exit” 
- Lists for parts and products 
- Text boxes for searching for parts and products 
- Title labels for parts, products, and the application title

B. An add part form, showing the following controls: 
- Radio buttons for “In-House” and “Outsourced” parts 
- Buttons for “Save” and “Cancel” 
- Text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID 
- Labels for ID, name, inventory level, price/cost, max and min values, the application title, and company name or machine ID

C. A modify part form, with fields that populate with pre-saved data, showing the following controls: 
- Radio buttons for “In-House” and “Outsourced” parts 
- Buttons for “Save” and “Cancel” 
- Text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID 
- Labels for ID, name, inventory level, price, max and min values, the application title, and company name or machine ID

D. An add product form, showing the following controls: 
- Buttons for “Save,” “Cancel,” “Add” part, and “Delete” part 
- Text boxes for ID, name, inventory level, price, and max and min values 
- Labels for ID, name, inventory level, price, max and min values, and the application 
- A grid view for associated parts and their products 
- A “Search” button and a text field with an associated list for displaying the results of the search

E. A modify product form, with fields that populate with pre-saved data, showing the following controls: 
- Buttons for “Save,” “Cancel,” “Add” part, and “Delete” part 
- Text boxes for ID, name, inventory level, price, and max and min values 
- Labels for ID, name, inventory level, price, max and min values, and the application 
- A grid view for associated parts and their products 
- A “Search” button and a text box with associated list for displaying the results of the search

## II. Application

Now that you’ve created the GUI, write code to create the class structure provided in the attached “UML (unified modeling language) Class Diagram.” Enable each of the following capabilities in the application:

F. Using the attached “UML Class Diagram,” create appropriate classes and instance variables with the following criteria: 
- Five classes with the 16 associated instance variables 
- Variables are only accessible through get properties 
- Variables are only modifiable through set properties

G. Add the following functionalities to the main form, using the methods provided in the attached “UML Class Diagram”: 
- Redirect the user to the “Add Part,” “Modify Part,” “Add Product,” or “Modify Product” forms 
- Delete a selected part or product from the grid view 
- Search for a part or product and display matching results 
- Exit the main form

H. Add the following functionalities to the part forms, using the methods provided in the attached “UML Class Diagram”:
- Add Part Form 
  - Select “In-House” or “Outsourced” 
  - Enter name, inventory level, price, max and min values, and company name or machine ID 
  - Save the data and then redirect to the main form 
  - Cancel or exit out of this form and go back to the main form

- Modify Part Form 
  - Select “In-House” or “Outsourced” 
  - Modify or change data values 
  - Save modifications to the data and then redirect to the main form 
  - Cancel or exit out of this form and go back to the main form

I. Add the following functionalities to the product forms, using the methods provided in the attached “UML Class Diagram”:

- Add Product Form 
  - Enter name, inventory level, price, and max and min values 
  - Save the data and then redirect to the main form 
  - Associate one or more parts with a product 
  - Remove or disassociate a part from a product 
  - Cancel or exit out of this form and go back to the main form

- Modify Product Form 
  - Modify or change data values 
  - Save modifications to the data and then redirect to the main form 
  - Associate one or more parts with a product 
  - Remove or disassociate a part from a product 
  - Cancel or exit out of this form and go back to the main form

J. Write code to implement exception controls with custom error messages for one requirement out of each of the following sets (pick one from each):

- Set 1 
  - Preventing the minimum string from having a value other than integers 
  - Preventing the maximum string from having a value other than integers 
  - Preventing the minimum field from having a value above the maximum field 
  - Preventing the maximum field from having a value below the minimum field

- Set 2 
  - Preventing the user from deleting a product that has a part assigned to it 
  - Including a confirm dialogue for all “Delete” and “Cancel” buttons 
  - Ensuring that the price of a product cannot be less than the cost of the parts 
  - Preventing the inventory from having a value other than the integers
