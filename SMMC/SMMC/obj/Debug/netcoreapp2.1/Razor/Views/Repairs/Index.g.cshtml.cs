#pragma checksum "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf14a99d0a1fa3be38bcc0c5332ed65c4105d50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repairs_Index), @"mvc.1.0.view", @"/Views/Repairs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Repairs/Index.cshtml", typeof(AspNetCore.Views_Repairs_Index))]
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
#line 1 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\_ViewImports.cshtml"
using SMMC;

#line default
#line hidden
#line 2 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\_ViewImports.cshtml"
using SMMC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf14a99d0a1fa3be38bcc0c5332ed65c4105d50", @"/Views/Repairs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a060a0b77bef058bf727801f1ef3801cf1bbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Repairs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMMC.Models.Repairs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 33, true);
            WriteLiteral("\r\n<h2>Incomplete Repairs</h2>\r\n\r\n");
            EndContext();
            BeginContext(118, 45, false);
#line 9 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
Write(Html.ActionLink("View Completed", "Complete"));

#line default
#line hidden
            EndContext();
            BeginContext(163, 155, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Instrument\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(319, 46, false);
#line 19 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Technician));

#line default
#line hidden
            EndContext();
            BeginContext(365, 145, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Date\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
         foreach (var item in Model)
        {

            if (@item.RepairEnd == null)
            {

#line default
#line hidden
            BeginContext(618, 76, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ID: ");
            EndContext();
            BeginContext(695, 37, false);
#line 35 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
                       Write(item.InstrumentInventory.InstrumentId);

#line default
#line hidden
            EndContext();
            BeginContext(732, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(735, 47, false);
#line 35 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
                                                               Write(item.InstrumentInventory.Instrument.Instrument1);

#line default
#line hidden
            EndContext();
            BeginContext(782, 80, true);
            WriteLiteral(")\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(863, 68, false);
#line 38 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Technician.Staff.Person.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(931, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(958, 67, false);
#line 39 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Technician.Staff.Person.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1105, 36, false);
#line 42 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
                   Write(item.RepairStart.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1141, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1221, 133, false);
#line 45 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
                   Write(Html.ActionLink("Complete", "Edit", new { id1 = item.Technician.TechnicianId, id2 = item.InstrumentInventory.InstrumentInventoryId }));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\Repairs\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1434, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMMC.Models.Repairs>> Html { get; private set; }
    }
}
#pragma warning restore 1591