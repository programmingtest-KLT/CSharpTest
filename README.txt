In this exam, you will create a website that will accomplish the following requirements.  All server-side code must be written in C# and use the .NET framework.  Your code will be examined for accurate completion, as well as overall style and structure.  

1) Hosts a page at <<your site>>/Weather/FindMyWeather.ascx that will accept a user input of zip code and features a submit button.  Do not worry about page styling, but ensure that this input is numeric and either 5 or 9 digits long when the submit button is clicked.
	- if the input is invalid display "Not a valid zip code" above the input field
	- if the input is valid, proceed to step 2
	- It is important that the 'enter' key not be allowed to submit the form on this page.  The customer is adamant that this behavior be forbidden on this page.
	
2) Using the input from step 1, call the webservice operation GetCityWeatherByZIP at http://wsf.cdyne.com/WeatherWS/Weather.asmx via a POST http request.  Find the current temperature and humidity for the zip code given and display this information to the page at FindMyWeather.ascx on your site.  
	- This webservice will only take 5 digit zip codes.  Ignore all characters from the user input in step 1 after the first 5 digits.
	- Temperature must be displayed to the page in degrees Celsius.  
	
3) Using the project DevelopmentDataAccess and the provided Database (TemperatureDB), perform the following operations.
	- Whenever a webservice call is successfully completed, save the city, pressure, and the approximate time the call was completed in the PressureHistory table
	- When displaying information on the FindMyWeather.ascx page after submit, also display the average humidity and temperature for Chicago.  Data can be found in the TemperatureHistory and HumidityHistory tables.  Retreival should occur in a single query.