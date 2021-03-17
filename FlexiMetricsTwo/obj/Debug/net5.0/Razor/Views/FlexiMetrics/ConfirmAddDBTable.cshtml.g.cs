#pragma checksum "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a683d982a57728d834daeb01918f4f0f4641b911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlexiMetrics_ConfirmAddDBTable), @"mvc.1.0.view", @"/Views/FlexiMetrics/ConfirmAddDBTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a683d982a57728d834daeb01918f4f0f4641b911", @"/Views/FlexiMetrics/ConfirmAddDBTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f07b5eb14c35998871168ce663ab8fbc50ee49a", @"/Views/_ViewImports.cshtml")]
    public class Views_FlexiMetrics_ConfirmAddDBTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChangeRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
  
    ViewData["Title"] = "AddDBTable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
  //ChangeTypeId = 1 Is Table Name, ChangeTypeId = 4 is Column
    ChangeRequest Table = Model.Where(x => x.ChangeTypeId == 1).First();
    int TableID = Table.ChangeRequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Add Table to the Database</h4>\r\n\r\n\r\n    <p>Confirm that you would like to add the following table to the Database:</p>\r\n    <p>");
#nullable restore
#line 14 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
  Write(Table.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p></p>\r\n\r\n    <table class=\"table-bordered\">\r\n        <tr>\r\n");
#nullable restore
#line 19 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
             foreach (var column in Model)
            { 
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
                 if (column.ChangeTypeId == 4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <p>");
#nullable restore
#line 24 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
                      Write(column.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 25 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
                      Write(column.ValueType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n");
#nullable restore
#line 27 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>     \r\n    </table>\r\n\r\n    <p><a");
            BeginWriteAttribute("href", " href=\"", 834, "\"", 877, 2);
            WriteAttributeValue("", 841, "/FlexiMetrics/AddDBTable?Id=", 841, 28, true);
#nullable restore
#line 32 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmAddDBTable.cshtml"
WriteAttributeValue("", 869, TableID, 869, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to add this table to the Database</a></p>\r\n\r\n\r\n");
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
