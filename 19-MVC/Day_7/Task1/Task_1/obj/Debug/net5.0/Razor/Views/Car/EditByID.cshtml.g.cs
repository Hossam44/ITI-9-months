#pragma checksum "D:\9_months\19-MVC\Day_7\Task1\Task_1\Views\Car\EditByID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b1debdd09ce541e0e5aea08d450306623d3b2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_EditByID), @"mvc.1.0.view", @"/Views/Car/EditByID.cshtml")]
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
#line 1 "D:\9_months\19-MVC\Day_7\Task1\Task_1\Views\Car\EditByID.cshtml"
using Task1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b1debdd09ce541e0e5aea08d450306623d3b2d", @"/Views/Car/EditByID.cshtml")]
    #nullable restore
    public class Views_Car_EditByID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\9_months\19-MVC\Day_7\Task1\Task_1\Views\Car\EditByID.cshtml"
  
    ViewBag.Title = "EditByID";
    car Edit_Car = ViewBag.Edit_Car;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    * {
        box-sizing: border-box;
    }

    input[type=text], select, textarea {
        width: 100%;
        padding: 12px;
        border: 1px solid #ccc;
        border-radius: 4px;
        resize: vertical;
    }

    label {
        padding: 12px 12px 12px 0;
        display: inline-block;
    }

    input[type=submit] {
        background-color: #04AA6D;
        color: white;
        padding: 12px 20px;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        float:right
    }

        input[type=submit]:hover {
            background-color: #45a049;
        }

    .col-25 {
        float: left;
        width: 25%;
        margin-top: 6px;
    }

    /* Clear floats after the columns */
    .row::after {
        content: """";
        display: table;
        clear: both;
    }
</style>

<h2>Edit Car</h2>
<form action=""/Car/EditByID"" method=""post"" style="" border-radius: 5px; background-color: #f2f2f2; padding: 20px;"">");
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-25\">\r\n            <label>ID</label>\r\n        </div>\r\n        <div class=\"col-25\">\r\n            <input type=\"text\" name=\"ID\"");
            BeginWriteAttribute("value", " value=\"", 1299, "\"", 1319, 1);
#nullable restore
#line 62 "D:\9_months\19-MVC\Day_7\Task1\Task_1\Views\Car\EditByID.cshtml"
WriteAttributeValue("", 1307, Edit_Car.ID, 1307, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly=\"readonly\">\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-25\">\r\n            <label>Model</label>\r\n        </div>\r\n        <div class=\"col-25\">\r\n            <input type=\"text\" name=\"Model\"");
            BeginWriteAttribute("value", " value=\"", 1547, "\"", 1570, 1);
#nullable restore
#line 70 "D:\9_months\19-MVC\Day_7\Task1\Task_1\Views\Car\EditByID.cshtml"
WriteAttributeValue("", 1555, Edit_Car.Model, 1555, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-25\">\r\n            <label>Color</label>\r\n        </div>\r\n        <div class=\"col-25\">\r\n            <input type=\"text\" name=\"Color\"");
            BeginWriteAttribute("value", " value=\"", 1778, "\"", 1801, 1);
#nullable restore
#line 78 "D:\9_months\19-MVC\Day_7\Task1\Task_1\Views\Car\EditByID.cshtml"
WriteAttributeValue("", 1786, Edit_Car.Color, 1786, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-25\">\r\n            <label>Manfacture</label>\r\n        </div>\r\n        <div class=\"col-25\">\r\n            <input type=\"text\" name=\"Manfacture\"");
            BeginWriteAttribute("value", " value=\"", 2019, "\"", 2047, 1);
#nullable restore
#line 86 "D:\9_months\19-MVC\Day_7\Task1\Task_1\Views\Car\EditByID.cshtml"
WriteAttributeValue("", 2027, Edit_Car.Manfacture, 2027, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-25\">\r\n        </div>\r\n        <div class=\"col-25\">\r\n            <input type=\"submit\" />\r\n        </div>\r\n\r\n    </div>\r\n</form>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
