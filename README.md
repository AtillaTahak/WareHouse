# WarehouseProject
A simple application written to track warehouse and stock

* Using the System.Data.SqlClient class, we defined our classes that we will need later on
SqlConnection
SqlDataAdapter
DataSet
SqlCommand

*Since we want the grid to be filled directly when our program is opened, we created a method called GridFill in the Forum Load Section, since it will not return any value, we defined this method as void, here we defined our sqlConnection class and wrote our connectString. We have sent the desired ProductList table to the sources of our .
In the gridfill method, we also filled the total cost and total sales labels in our project, as these two will change every time we change the grid and table, I thought it more logical to use the same method.

*I didn't want to have the same name product in our table, I created a method where I can control the same product so that there is no confusion in the product output.

*In order not to specify the connecstring again in every query, I created a void type method called a connectionAc.

*I wanted only product entry on the homepage of my form, so I designed my form with labels and textboxes. The textboxes I created for ProductAdet, Product Cost, ProductSatis were only required to be entered in numbers, so I checked these events in the KeyPress event of the textbox and ensured that these textBoxes did not receive any letters.


*I put an admin login button at the bottom of my Form Design. When this button is clicked, I showed the form I created as loginAdmin with showdialog. Here, the reason for choosing showdialog is that when we show it with show, the form below can be accessed.

*I ran a query with dataAdapter for the loginAdmin form. I wanted it to show the adminPanel form again with showDialog when the value comes.

*For the design of the adminPanel form, I wanted product output, product deletion, product editing and grid areas to be here, for this, I assigned the values ​​of the product data we searched to the textboxes I created for product editing by searching with the product id in the product arrangement, with the update method, the data in the textbox was updated. I transferred it to our table with a sql query, and here I checked whether the textboxes are empty so that no empty values ​​are sent.

*I used the gridFill method in the adminPanel and the codes required to fill the label in this method

*I used a comboBox for Product output in the adminPanel, it is more pleasing to the eye and useful by using different elements. Since I want this method to update every time I change it, I created it as a method and I have the ComboBoxes filled in both Product Output and Product Deletion.

*I wrote a method for the control with the same name in the adminPanel, then I changed the Enable property of the textBox, where I got the product name in the textBox, instead, and made it false, so I made it work like a label.
*As I used in Form1, I provided controls in this event so that textual expressions are not entered in the KeyPress Events of the textboxes where I receive numeric data.
