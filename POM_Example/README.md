## Things To Notice
Testing is done on the practice site https://www.saucedemo.com/

### Page Class
The Page class is used to hold the IWebDriver plus any other shared page attributes and actions. For this particular application under test there is a different URL for each page. I made that a field to be inherited by each page and automatically check that the url is correct in the base constructor. 

### LoginPage Class
I pass in the driver and url into the base constructor. I keep my page object actions simple. Fill in a field, click a button, ect. I try to keep things as simple as possible. Keep my page objects centered around the page itself as opposed to any testing actions. I decided to make my page objects fluid so that methods can be chained together. 

### ProductsPage class
This page is worth noting because of the IventoryItem component. I decided that since these components are repeated and there is the possibility that they can be reused on another page, I would make them their own components. The Item method will return a new InventoryItem class based on the header title. 

### InventoryItem class
This is a page component. It works sort of like a page object that can be stored within page objects. 

### Exentnsions class
To keep thigns simplistic I added some custom waits as an extention to the IWebDriver. 

### Actions
Here is where I create the test case step actions. These actions can then be used in tests. 

### The Tests
There isn't much here to point out. Most of this is going to be very language and test runner specific. The biggest thing is jsut to observe how the actions can be used like test steps that chain together. 

## Takeaways
Do not just copy these. This was just a super simple implementation to give an example of how one would utilize page objects. Ther eis no wrong or right way as long as it makes sense for the team and the use case. One thing people may notice that didn't occur to me until after, the cart is a aprt of a top navigation bar which should either be a component or apart of the Page class. 