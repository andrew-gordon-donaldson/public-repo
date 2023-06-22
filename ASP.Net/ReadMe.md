# Inventory Management System Tutorial

This is a very simple Blazor Server application that was initially built following a 
[YouTube Tutorial by Frank Liu](https://www.youtube.com/watch?v=EluvVXA_Rto&list=WL&index=17&ab_channel=FrankLiu).

There were some initial liberties taken with regards to naming of blazor components, classes, methods, properties, and variables.
This really only serves to demonstrate how naming of things is one of the truly hard things to do in computer science.  However, the overall project
structure/architecture followed that presented in said tutorial.  As such, I do not necessarily endorse (nor condemn) the structure/architectural decisions of the presenter.


Plus I added the use of the [Bogus](https://github.com/bchavez/Bogus) to seed the in-memory dataset rather than doing the expedient thing and hard-coding initial
items in the repository.

I intend to continue reworking this particular application to explore various facets of working with Blazor/Blazor Server, and I reserve the right to continue modifying the code as I find reasons to experiment.

ToDo List:
1. Look into testing Blazor component code / MVVM pattern appropriate?.
1. Implement data access with EF Core.
1. Implement data access with Dapper.
1. Implement identity/authorization.
1. Explore ASP.Net Core Configuration.
1. Attempt to reproduce the experience of the Blazor Server WebApp with Blazor WASM.
1. Look into revising application codebase along DDD + CQRS as a loosely coupled monolith.
1. Add other microservices (& refactor to Event driven architecture?)
1. Dockerize all the things!
1. Kubernetes Clustering!


Changelog:

*2023-06-21* - Completed tutorial by following along with the aforementioned YouTube tutorial.  
