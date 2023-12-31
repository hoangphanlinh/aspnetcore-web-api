#pragma checksum "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea871de26f1325063b8de373c7c98d75122e2a88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\_ViewImports.cshtml"
using WebApiConsumeMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\_ViewImports.cshtml"
using WebApiConsumeMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea871de26f1325063b8de373c7c98d75122e2a88", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"253ff3d3facdbaaef7a9763072cf91c4b19a9286", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApiConsumeMVC.Models.BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""PlaceHolderHere""></div>
<div class=""table-responsive"">
    <div class=""table-wrapper"">
        <div class=""table-title"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <h2>Manage <b>Books</b></h2>
                </div>
                <div class=""col-sm-6"">
                    <button data-target=""#addEmployeeModal"" class=""btn btn-success"" data-toggle=""modal"" onclick=""addBook()""><i class=""material-icons"">&#xE147;</i> <span>Add New Employee</span></button>
");
            WriteLiteral(@"                </div>
            </div>
        </div>
        <table class=""table table-striped table-hover"" id=""bookTable"">
            <thead>
                <tr>
                    <th>BookId</th>
                    <th>Title</th>
                    <th>Description</th>
                    <th>IsRead</th>
                    <th>DateRead</th>
                    <th>Rate</th>
                    <th>Genre</th>
                    <th>Author</th>
                    <th>ConverURL</th>
                    <th>DateAdded</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 37 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 40 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 48 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IsRead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 50 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.DateRead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.CoverUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(item.DateAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a data-target=\"");
#nullable restore
#line 57 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                                        Write("#editEmployeeModal-"+item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"edit\" data-toggle=\"modal\" data-url=\"");
#nullable restore
#line 57 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                                                                                                                    Write(Url.Action($"Edit/{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"cursor:pointer\"><i class=\"material-icons\" data-toggle=\"tooltip\" title=\"Edit\">&#xE254;</i></a>\r\n                            ");
#nullable restore
#line 58 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
                       Write(await Html.PartialAsync("Edit", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2733, "\"", 2781, 1);
#nullable restore
#line 59 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
WriteAttributeValue("", 2740, Url.Action("Delete",new {id = item.Id }), 2740, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"material-icons\" data-toggle=\"tooltip\" title=\"Delete\">&#xE872;</i></a>\r\n\r\n                           \r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n        ");
#nullable restore
#line 70 "D:\Workspace\API\my-books\WebApiConsumeMVC\Views\Book\Index.cshtml"
   Write(await Html.PartialAsync("Create",new BookViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <!--Paging-->
        <div class=""clearfix"">
            <div class=""hint-text"">Showing <b>5</b> out of <b>25</b> entries</div>
            <ul class=""pagination"">
                <li class=""page-item disabled""><a href=""#"">Previous</a></li>
                <li class=""page-item""><a href=""#"" class=""page-link"">1</a></li>
                <li class=""page-item""><a href=""#"" class=""page-link"">2</a></li>
                <li class=""page-item active""><a href=""#"" class=""page-link"">3</a></li>
                <li class=""page-item""><a href=""#"" class=""page-link"">4</a></li>
                <li class=""page-item""><a href=""#"" class=""page-link"">5</a></li>
                <li class=""page-item""><a href=""#"" class=""page-link"">Next</a></li>
            </ul>
        </div>
    </div>
</div>
<script>
    function addBook() {
        $.ajax({
            type: ""Get"",
            url: ""/Book/Create"",
            success: function (result) {
                $(""#bookTable"").html(result);
                $(""#");
            WriteLiteral("addBook\").modal(\'show\');\r\n            }\r\n        });\r\n    }\r\n    function ShowModal(id) {\r\n        $(\"#deleteEmployeeModal\").val(id);\r\n        $(\"\")\r\n    }\r\n\r\n    \r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApiConsumeMVC.Models.BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
