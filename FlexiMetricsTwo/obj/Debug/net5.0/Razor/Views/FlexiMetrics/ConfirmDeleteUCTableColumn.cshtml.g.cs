#pragma checksum "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e186262f88fdbed81faad9c60d3e410bde11a82c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlexiMetrics_ConfirmDeleteUCTableColumn), @"mvc.1.0.view", @"/Views/FlexiMetrics/ConfirmDeleteUCTableColumn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e186262f88fdbed81faad9c60d3e410bde11a82c", @"/Views/FlexiMetrics/ConfirmDeleteUCTableColumn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f07b5eb14c35998871168ce663ab8fbc50ee49a", @"/Views/_ViewImports.cshtml")]
    public class Views_FlexiMetrics_ConfirmDeleteUCTableColumn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChangeRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
  
    ViewData["Title"] = "ConfirmDeleteUCTableColumn";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
  
    ChangeRequest ColumnToEdit = Model.Where(x => x.ParentId != null).First();
    ChangeRequest Parent = Model.Where(x => x.ParentId == null).First();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Delete Column</h4>\r\n<p>Please confirm that you want to delete the column<b> ");
#nullable restore
#line 13 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
                                                   Write(ColumnToEdit.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>of data type<b> ");
#nullable restore
#line 13 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
                                                                                              Write(ColumnToEdit.ValueType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>from the under construction table <b> ");
#nullable restore
#line 13 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
                                                                                                                                                                Write(Parent.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b></p>\r\n\r\n<p><a");
            BeginWriteAttribute("href", " href=\"", 480, "\"", 585, 4);
            WriteAttributeValue("", 487, "/FlexiMetrics/DeleteUCTableColumn?Id=", 487, 37, true);
#nullable restore
#line 15 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
WriteAttributeValue("", 524, ColumnToEdit.ChangeRequestId, 524, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 553, "&TableId=", 553, 9, true);
#nullable restore
#line 15 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
WriteAttributeValue("", 562, Parent.ChangeRequestId, 562, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Column: ");
#nullable restore
#line 15 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
                                                                                                                          Write(ColumnToEdit.NewValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n\r\n<p>Click here to return to <a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 730, 2);
            WriteAttributeValue("", 672, "/FlexiMetrics/ViewUCTableToEdit?Id=", 672, 35, true);
#nullable restore
#line 17 "C:\Users\millr\source\repos\FlexiMetricsTwo\FlexiMetricsTwo\Views\FlexiMetrics\ConfirmDeleteUCTableColumn.cshtml"
WriteAttributeValue("", 707, Parent.ChangeRequestId, 707, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Table Edit</a> page</p>\r\n\r\n<p>Click here to return to <a href=\"/FlexiMetrics/Index\"</p>");
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
