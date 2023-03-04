# Injector

Part of [MoQa](https://moqa.moshaheen.com/) Project  

Version:  
	- [Injector](https://www.nuget.org/packages/MoShaheen.Injector/)  
	- [Injector.Contracts](https://www.nuget.org/packages/MoShaheen.Injector.Contracts/)  
Author: [Mahmoud Shaheen](https://www.moshaheen.com/)
## Links:
[Download](https://www.nuget.org/packages/MoShaheen.Injector/)  
[Website](https://github.com/mahmoudShaheen/Injector)  
[Github](https://github.com/mahmoudShaheen/Injector)  

## Why?
### .Net DI Made Easy  
Injector Takes .Net DI to the next level.  
It allows to simply inject services from other projects easily which made separation of concerns easy!  
you only need to do two things:  
1. Implement one of the interfaces in Injector.Contracts package according to the case (Singleton, Scoped, Transient).  
2. builder.Services.AddInjector().RegisterModule(typeof(Program));

## Features:
* Contracts:  
  * Abstraction for Injector so it can be used in any project such as class libraries.  
* Services:  
  * Calling AddInjector() Do the magic by scanning all provided modules and register services to IOC.  
  * Three types are supported (Singleton, Scoped, Transient).  
* HostedServices:  
  * Registers all hosted services in any given module to IOC.

## How To Run:
* Using Visual Studio
* Open Injector.sln
* Set example\TestApp as startup project
* Run: press "F5"

## How To Use:
An Example of usage is included in [Example Folder](https://github.com/mahmoudShaheen/Injector/tree/master/Injector/example).
