
# Toast Component
Is component to enable toast notifications in application.


To install NuGet package run

      Install-Package NoJS.Toast -Version 1.0.0

Version with setting up countdown timer manually (old version was hardcoded to 5 seconds)
      
    Install-Package NoJS.Toast -Version 1.0.1

In **_Imports.razor**
 add
 
    @using NoJS.Toast
    @using NoJS.Toast.Services

In **Startup.cs**
 add
 
     public void ConfigureServices(IServiceCollection services)
        {
            services.AddNoJSToast();

        }
In **MainLayout.razor**
 add component
 
       <NoJSToast />


In page where you need toast notification inject service
 
      @inject INoJSToastService NoJSToast


you can test notifications directly over this example
 
      TOAST test:
    <button class="btn btn-info" @onclick="@(() => NoJSToast.ShowToast("I'm an INFO message", NoJSToastLevel.Info,2000))">Info Toast</button>
    <button class="btn btn-success" @onclick="@(() => NoJSToast.ShowToast("I'm a SUCCESS message", NoJSToastLevel.Success,2000))">Success Toast</button>
    <button class="btn btn-warning" @onclick="@(() => NoJSToast.ShowToast("I'm a WARNING message", NoJSToastLevel.Warning,2000))">Warning Toast</button>
    <button class="btn btn-danger" @onclick="@(() => NoJSToast.ShowToast("I'm an ERROR message", NoJSToastLevel.Error,2000))">Error Toast</button>


or call it from anywhere in code like this
 
      try
    {
    //do some magic
     NoJSToast.ShowToast("Sucess!!", NoJSToastLevel.Success,1000);
    }
    catch(exception ex)
    {
    NoJSToast.ShowToast("Something bad happen!!", NoJSToastLevel.Error,3000);
    }


That's it.



