#pragma checksum "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "051d7aba188be668feb7289df0d88eddd37aa560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlexiMetrics_ConfirmDeleteUCTable), @"mvc.1.0.view", @"/Views/FlexiMetrics/ConfirmDeleteUCTable.cshtml")]
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
#line 1 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\_ViewImports.cshtml"
using FlexiMetricsTwo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\_ViewImports.cshtml"
using FlexiMetricsTwo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051d7aba188be668feb7289df0d88eddd37aa560", @"/Views/FlexiMetrics/ConfirmDeleteUCTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f07b5eb14c35998871168ce663ab8fbc50ee49a", @"/Views/_ViewImports.cshtml")]
    public class Views_FlexiMetrics_ConfirmDeleteUCTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChangeRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
  
    ViewData["Title"] = "ConfirmDeleteUCTable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
  //ChangeTypeId = 1 Is Table Name, ChangeTypeId = 4 is Column
    ChangeRequest Table = Model.Where(x => x.ChangeTypeId == 1).First();
    int TableID = Table.ChangeRequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Delete Table Under Construction</h4>\r\n\r\n<p>");
#nullable restore
#line 13 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
Write(Table.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table-bordered\">\r\n    <tr>\r\n");
#nullable restore
#line 17 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
         foreach (var column in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
             if (column.ChangeTypeId == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <p>");
#nullable restore
#line 22 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
                  Write(column.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 23 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
                  Write(column.ValueType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </td>\r\n");
#nullable restore
#line 25 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n\r\n<p>Are you sure you want to delete the table <b>");
#nullable restore
#line 30 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
                                           Write(Table.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>that you have under construction? All columns and data types will be lost and gone forever.</p>\r\n<p></p>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 916, 2);
            WriteAttributeValue("", 863, "/FlexiMetrics/DeleteUCTable?Id=", 863, 31, true);
#nullable restore
#line 33 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
WriteAttributeValue("", 894, Table.ChangeRequestId, 894, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete ");
#nullable restore
#line 33 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTable.cshtml"
                                                                  Write(Table.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n<p></p>\r\n<a href=\"/FlexiMetrics/Index\">Return to Index</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ChangeRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
