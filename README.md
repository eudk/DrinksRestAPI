# DrinksRestAPI
Drinks API with notes (Swagger , Cors etc) /On Azure, and tested in Postman


**Postman scripts for tests (Tested with Azure page)**

**Create:**
pm.test("Status code is 201", function () {
    pm.response.to.have.status(201);
});

**Delete:**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});
Link: api/drinks/idnumber

**Update:**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});
Body:
eg. {
    "Name": "Test Drink",
    "Type": "Soda",
    "YearOfProduction": 2022
}


**Get all:**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});



**GetbyID (issues):**
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

and added id in link
