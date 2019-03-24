# dt-challenge

Created a Project based on the Onion Architecture proposed by [Jeffrey Pallermo], and it includes
- A knowledge based only Repository Design Pattern, but not using any database access as the purpose is to demonstrate knowledge
- Separation of concerns organizing the project into Domain, Infrastructure and Interface following the Onion Architecure
- Core.Domain: contains the contracts, entities and ReasEase Interface to represents a HttpClient for the Ui
- IO.Infra: contains external approaches to IO operations, could be any third party framework easy replaced
- DTChallenge.Api: backend rest api to be consumed by the UI, using asp.net core and DI patterns
- DTChallenge.Ui: Asp.net MVC Core using bootstrap and consuming data from the backend api using RestEase HttpClient

## Published on Azure
Using azure to host both api and ui, able to set CI via VSTS or any other Continuous Integration Software and also Continuous Deployment or Delivery using Azure or other Third Party Tool
 - API: http://renanmiranda-apidtchallenge.azurewebsites.net/ Existing route /VehicleSales
 - UI: http://renanmiranda-dtchallenge.azurewebsites.net/


## Logs
Logs were not added however I would suggest using the SeriLog for .netcore for one of the best logging tools available, or even integrate with an existing log framework



[Jeffrey Pallermo]: <https://jeffreypalermo.com/2008/07/the-onion-architecture-part-1/>
