
# Toast Component
Is component to enable toast notifications in application.


To install NuGet package run

      Install-Package NoJS.Toast -Version 1.0.0

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
    <button class="btn btn-info" @onclick="@(() => NoJSToast.ShowToast("I'm an INFO message", NoJSToastLevel.Info))">Info Toast</button>
    <button class="btn btn-success" @onclick="@(() => NoJSToast.ShowToast("I'm a SUCCESS message", NoJSToastLevel.Success))">Success Toast</button>
    <button class="btn btn-warning" @onclick="@(() => NoJSToast.ShowToast("I'm a WARNING message", NoJSToastLevel.Warning))">Warning Toast</button>
    <button class="btn btn-danger" @onclick="@(() => NoJSToast.ShowToast("I'm an ERROR message", NoJSToastLevel.Error))">Error Toast</button>


or call it from anywhere in code like this
 
      try
    {
    //do some magic
     NoJSToast.ShowToast("Sucess!!", NoJSToastLevel.Success);
    }
    catch(exception ex)
    {
    NoJSToast.ShowToast("Something bad happen!!", NoJSToastLevel.Error);
    }


That's it.



