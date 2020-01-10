
# PDFViewer Component
Small component to enable displaying and downloading PDF files/documents in Blazor.


To install NuGet package run

      Install-Package NoJS.PDFViewer -Version 1.0.0

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



