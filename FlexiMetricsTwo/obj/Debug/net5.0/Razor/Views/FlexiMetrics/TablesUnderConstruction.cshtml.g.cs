#pragma checksum "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a46beed7e42edd276126af6584f3233bbdd21a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlexiMetrics_TablesUnderConstruction), @"mvc.1.0.view", @"/Views/FlexiMetrics/TablesUnderConstruction.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a46beed7e42edd276126af6584f3233bbdd21a3", @"/Views/FlexiMetrics/TablesUnderConstruction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f07b5eb14c35998871168ce663ab8fbc50ee49a", @"/Views/_ViewImports.cshtml")]
    public class Views_FlexiMetrics_TablesUnderConstruction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChangeRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
  
    ViewData["Title"] = "TablesUnderConstruction";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Tables Currently Under Construction:</h4>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
 if (@Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table-bordered\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
         foreach (var row in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
           Write(row.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 319, "\"", 381, 2);
            WriteAttributeValue("", 326, "/FlexiMetrics/ViewUCTableToEdit?id=", 326, 35, true);
#nullable restore
#line 18 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
WriteAttributeValue("", 361, row.ChangeRequestId, 361, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Under Construction Table</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 441, "\"", 503, 2);
            WriteAttributeValue("", 448, "/FlexiMetrics/ConfirmAddDBTable?id=", 448, 35, true);
#nullable restore
#line 19 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
WriteAttributeValue("", 483, row.ChangeRequestId, 483, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add Table To Database</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 620, 2);
            WriteAttributeValue("", 562, "/FlexiMetrics/ConfirmDeleteUCTable?id=", 562, 38, true);
#nullable restore
#line 20 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
WriteAttributeValue("", 600, row.ChangeRequestId, 600, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Under Construction Table</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 24 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"
   
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>You currently do not have any tables under construction. Click here to <a href=\"/FlexiMetrics/AddUCTable\">Create a New Table</a></p>\r\n");
#nullable restore
#line 29 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\TablesUnderConstruction.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
