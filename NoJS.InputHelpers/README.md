# InputHelpers Component
Extensions for input form elements in Blazor with regular expression validation.

Helpers:
Credit Card Helper
Email Helper
IP Address Helper
Number Regex Helper
Phone Helper


To install NuGet package run

     Install-Package NoJS.InputHelpers -Version 1.0.0

In **_Imports.razor** add
 
        @using NoJS.InputHelpers





 **Usage example**
 
        <EditForm @ref="testform" OnValidSubmit="SubmitForm" Model="exampleDataModel">
    <DataAnnotationsValidator />
    <div class="form-group">
        <label class="form-label">Phone</label>
        <InputPhone class="form-control" Id="phone" ErrorMessage="something is wrong" @bind-Value="exampleDataModel.Phone" />
        <ValidationMessage For="@(()=> exampleDataModel.Phone)" />
    </div>
    <div class="form-group">
        <label class="form-label">Email</label>
        <InputEmail Id="email" class="form-control" @bind-Value="exampleDataModel.Email" />
        <ValidationMessage For="@(()=> exampleDataModel.Email)" />
    </div>

    <div class="form-group">
        <label class="form-label">Number</label>
        <InputNumberRegex Id="number" class="form-control" CustomRegex="^[0-9]*$" @bind-Value="exampleDataModel.IntegerNumber" />
        <ValidationMessage For="@(()=> exampleDataModel.IntegerNumber)" />
    </div>

    <div class="form-group">
        <label class="form-label">Credit Card</label>
        <InputCreditCard Id="creditcard" class="form-control" @bind-Value="exampleDataModel.CreditCardNumber" />
        <ValidationMessage For="@(()=> exampleDataModel.CreditCardNumber)" />
    </div>
    <div class="form-group">
        <label class="form-label">IP Address</label>
        <InputIPAddress Id="ipaddress" class="form-control" @bind-Value="exampleDataModel.IPAddress" />
        <ValidationMessage For="@(()=> exampleDataModel.IPAddress)" />
    </div>
    <button type="submit" class="btn btn-outline-primary btn-sm">Test</button></EditForm>

        @code{
    EditForm testform { get; set; }
    InputTestFormData exampleDataModel = new InputTestFormData();
    async Task SubmitForm()
    {

    }

 **Parameters**


Id - setting name/id for input field
CustomRegex - define your own regex for validation
ErrorMessage - override custom error message with your own




 **The MIT License**


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