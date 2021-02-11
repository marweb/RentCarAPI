
## Net Core 3.1 API - Entitity Framework y MySql

Show Available Cars
----
  Returns json data with all available cars.

* **URL**

  /api/Car/Available

* **Method:**

  `GET`
  
*  **URL Params**

    None

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---

Show All Cars
----
  Returns json data with all cars.

* **URL**

  /api/Car

* **Method:**

  `GET`
  
*  **URL Params**

    None

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---

Get Car By ID
----
  Returns json data for single car.

* **URL**

  /api/Car/:id

* **Method:**

  `GET`
  
*  **URL Params**

    **Required:**
 
   `id=[integer]`

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---

Create New Car
----
  Create new car.

* **URL**

  /api/Car

* **Method:**

  `POST`
  
*  **URL Params**

    None

* **Data Params**

  **Required:**
 
   `Name=[string]` <br />
   `Brand=[string]` <br />
   `Color=[string]` <br />
   `Stock=[integer]` <br />
   `Status=[integer]` <br />
   `FechaCreacion=[DateTime]`

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Created Object }`

  ---

Update Car
----
  Update car.

* **URL**

  /api/Car/:id

* **Method:**

  `PUT`
  
*  **URL Params**

   **Required:**
 
   `id=[integer]`

* **Data Params**

  **Required:**
 
   `Name=[string]` <br />
   `Brand=[string]` <br />
   `Color=[string]` <br />
   `Stock=[integer]` <br />
   `Status=[integer]`

* **Success Response:**

  * **Code:** 204 <br />
    **Content:** `{}`
 
   ---

Delete Car By ID
----
  Delete Car.

* **URL**

  /api/Car/:id

* **Method:**

  `DELETE`
  
*  **URL Params**

    **Required:**
 
   `id=[integer]`

* **Data Params**

    None

* **Success Response:**

  * **Code:** 204 <br />
    **Content:** `{}`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

   ---

Show All Users
----
  Returns json data with all users.

* **URL**

  /api/User

* **Method:**

  `GET`
  
*  **URL Params**

    None

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---

Get User By ID
----
  Returns json data for single user.

* **URL**

  /api/User/:id

* **Method:**

  `GET`
  
*  **URL Params**

    **Required:**
 
   `id=[integer]`

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---

Create New User
----
  Create new User.

* **URL**

  /api/User

* **Method:**

  `POST`
  
*  **URL Params**

    None

* **Data Params**

  **Required:**
 
   `Name=[string]` <br />
   `Email=[string]` <br />
   `Phone=[string]` <br />
   `Direccion=[string]` <br />
   `Status=[integer]` <br />
   `FechaCreacion=[DateTime]`

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Created Object }`

  ---

Update User
----
  Update User.

* **URL**

  /api/User/:id

* **Method:**

  `PUT`
  
*  **URL Params**

   **Required:**
 
   `id=[integer]`

* **Data Params**

  **Required:**
 
   `Name=[string]` <br />
   `Email=[string]` <br />
   `Phone=[string]` <br />
   `Direccion=[string]` <br />
   `Status=[integer]` <br />

* **Success Response:**

  * **Code:** 204 <br />
    **Content:** `{}`
 
   ---

Delete User By ID
----
  Delete User.

* **URL**

  /api/User/:id

* **Method:**

  `DELETE`
  
*  **URL Params**

    **Required:**
 
   `id=[integer]`

* **Data Params**

    None

* **Success Response:**

  * **Code:** 204 <br />
    **Content:** `{}`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

 ---

Show All Orders
----
  Returns json data with all orders.

* **URL**

  /api/Order

* **Method:**

  `GET`
  
*  **URL Params**

    None

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---

  Get Orders By User
----
  Returns json data with orders for specific user id.

* **URL**

  /api/Order/ByUser/:id

* **Method:**

  `GET`
  
*  **URL Params**

    **Required:**
 
   `id=[integer]`

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---

Get Order By ID
----
  Returns json data for single order.

* **URL**

  /api/Order/:id

* **Method:**

  `GET`
  
*  **URL Params**

    **Required:**
 
   `id=[integer]`

* **Data Params**

    None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Data }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`

  ---



Create New Order
----
  Create new Order.

* **URL**

  /api/Order

* **Method:**

  `POST`
  
*  **URL Params**

    None

* **Data Params**

  **Required:**
 
   `Agencia=[string]` <br />
   `FechaInicioAlquiler=[DateTime]` <br />
   `FechaFinAlquiler=[DateTime]` <br />
   `Status=[integer]` <br />
   `CreadoPor=[string]` <br />
   `FechaCreacion=[DateTime]`<br />
   `CarId=[integer]` <br />
   `UserId=[integer]`

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ JSON Created Object }`

  ---

Update Order
----
  Update Order.

* **URL**

  /api/Order/:id

* **Method:**

  `PUT`
  
*  **URL Params**

   **Required:**
 
   `id=[integer]`

* **Data Params**

  **Required:**
 
   `Agencia=[string]` <br />
   `FechaInicioAlquiler=[DateTime]` <br />
   `FechaFinAlquiler=[DateTime]` <br />
   `Status=[integer]` <br />
   `CreadoPor=[string]` <br />
   `CarId=[integer]` <br />
   `UserId=[integer]`

* **Success Response:**

  * **Code:** 204 <br />
    **Content:** `{}`
 
   ---

Delete Order By ID
----
  Delete Order.

* **URL**

  /api/Order/:id

* **Method:**

  `DELETE`
  
*  **URL Params**

    **Required:**
 
   `id=[integer]`

* **Data Params**

    None

* **Success Response:**

  * **Code:** 204 <br />
    **Content:** `{}`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{}`