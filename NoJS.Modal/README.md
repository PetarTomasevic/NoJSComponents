
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



The MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.