This Proof of Concept (POC) was created as a minimal API project with a skeleton app including components needed for a .NET 7.0 Minimal API using Endpoints instead of legacy controllers. It can serve as a starting point for new API projects.

### The following subfolders are included:

#### Endpoints: 
Represents API endpoints and handlers for implementation.
#### Extensions: 
Contains C# extension methods.

#### Helpers: 
Contains useful and reusable helper classes.

#### Middleware: 
Contains .NET middleware components to add additional functionality to the API.
Usage: To use the project, run the following command:

### How to Use

Use this entire solution as a starter for your own Minimal API.

To make it easy to update the project name to your new name run this script

``` 
PS .\update-name.ps1 -newname "NewProjectName"
```


### For more complex Projects
For larger projects, it is recommended to have multiple projects within a single solution for better organization and maintainability of the codebase.

### Why use Minimal API over Controller-based API
Minimal API provides a modern, lightweight and streamlined alternative to the older and more complex Controller-based API. It offers better performance, scalability, and easier maintenance compared to the traditional Controller model. It is considered the recommended approach for .NET developers to create APIs.