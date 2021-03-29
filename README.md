# **Testing Api Endpoints:**

1. Creating New Account
   **POST**  :  http://localhost:5000/api/auth/register
   Ex: JSON Body
       {
            "UserName" : "Abhijit",
            "Email" : "shindeabhijit456@gmail.com",
            "Password" : "Qwer1234Vb@",
            "ConfirmPassword" : "Qwer1234Vb@"
       }
       
2. Login to the Account
   **POST**  :  http://localhost:5000/api/auth/login
   Ex: JSON Body
        {
            "UserName" : "Abhijit",
            "Password" : "Qwer1234Vb"
        }
        
3. Adding a Category
   **POST**  :  http://localhost:5000/api/admin/AddCategory
   Ex: JSON Body
       {
            "ProductCategory" : "Vegetables"
       }
       
4. Returning a Category
   **GET**  :  http://localhost:5000/api/admin/AllCategory
   
5. Adding a Product
   **POST**  :  http://localhost:5000/api/admin/AddProduct
   Ex: JSON Body
       {
            "Img" : "",
            "CategoryId" : "b984a58c-436b-4ffe-2b13-08d8f2b185e5",
            "Description" : "",
            "InStock" : "",
            "Price" : ""
       }

6. Returning All Products
   **GET**  :  http://localhost:5000/api/General/AllProducts
   
7. Returning Single Product
   **GET**  :  http://localhost:5000/api/General/{id}
   
8. Shipment Details
   **POST**  :  http://localhost:5000/api/General/StoreShipment
   Ex: JSON Body
       {
            "Name": "add_name",
            "Phone": "1234567876",
            "Address": "add",
            "TotalCost": "122",
            "OrderProduct": [
              {
               "ProductID": "8cd8d49d-12b8-4da3-b23b-08d59cbbcf32",
               "Quantity" : "3"
              }
            ]
       }
       
9. Returning All Shipments Info.
   **GET**  :  http://localhost:5000/api/admin/AllShipments
   
**Other API Endpoints are available in Controllers Folder.**
