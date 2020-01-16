
# Modal Component
Is component to enable Modals in application.


To install NuGet package run

      Install-Package NoJS.Modal -Version 1.0.0


In **_Imports.razor**
 add
 
    @using NoJS.Modal
    @using NoJS.Modal.Services

In **Startup.cs**
 add
 
     public void ConfigureServices(IServiceCollection services)
        {
             services.AddNoJSModal();

        }
In **MainLayout.razor**
 add component
 
      <NoJSModal />


In page where you need toast notification inject service
 
      @@inject INoJSModalService Modal


Find Usage examples in TestComponentApp
[Modal usage examples](https://github.com/PetarTomasevic/NoJSComponents/blob/master/TestComponentApp/Pages/Index.razor)


   
That's it.



