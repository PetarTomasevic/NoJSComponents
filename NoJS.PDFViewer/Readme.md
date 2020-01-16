
# PDFViewer Component
Small component to enable displaying and downloading PDF files/documents in Blazor.


To install NuGet package run

      Install-Package NoJS.PDFViewer -Version 1.0.1

In **_Imports.razor**
 add
 
    @using NoJS.PDFViewer



In page where you want to show Pdf document add component;

    <NoJS.PDFViewer.PDFViewer 
                          Document="@getBytesFromPDF()" 
                          DocumentHeight="100%" 
                          DocumentName="@DocumentName()" 
                          DocumentWidth="100%" 
                          SaveBtnImage="css/nojs-icons/icons8-save-26.png" />

Examples how to fetch document for display ,and document name for download

    @code{


    //fetch your pdf from your machine or from your service
    public static string pdfFilePath = "C:/pdftest/Report.pdf";

    public byte[] getBytesFromPDF()
    {
        //Get byte[] from  your API or services
        var abc = System.IO.File.ReadAllBytes(pdfFilePath);
        var get64 = Convert.ToBase64String(abc);
        return abc;
    }

    public string DocumentName()
    {
        //use your way to fetch your file name or generate one
        return "ExamplePdf";
    }
    }


That's it.



The MIT License

Copyright (c) 2010-2020 Google, Inc. http://angularjs.org

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