# DrinksRestAPI
Drinks API with notes (Swagger , Cors etc) /On Azure, and tested in Postman


**Postman scripts for tests (Tested with Azure page)**

**Create: POST**
pm.test("Status code is 201", function () {
    pm.response.to.have.status(201);
});

**Delete: DELETE**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});
Link: api/drinks/idnumber

**Update: PUT**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});
Body:
eg. {
    "Name": "Test Drink",
    "Type": "Soda",
    "YearOfProduction": 2022
}


**Get all: GET**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});



**GetbyID (issues): GET**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

and added id in link



________________________________________________________________________________________________

eg. of data in the API

id	3
name	"Sprite"
type	"Soda"
yearOfProduction	2019
1	
id	4
name	"Pepsi"
type	"Soda"
yearOfProduction	2019
2	
id	5
name	"7up"
type	"Soda"
yearOfProduction	2019
3	
id	6
name	"Mountain Dew"
type	"Soda"
yearOfProduction	2019
4	
id	7
name	"Dr Pepper"
type	"Soda"
yearOfProduction	2019
