#pragma checksum "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac3a3930498ada08d753008a05082b16fc408f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnrollmentMusicClasses_Index), @"mvc.1.0.view", @"/Views/EnrollmentMusicClasses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnrollmentMusicClasses/Index.cshtml", typeof(AspNetCore.Views_EnrollmentMusicClasses_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac3a3930498ada08d753008a05082b16fc408f7", @"/Views/EnrollmentMusicClasses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a060a0b77bef058bf727801f1ef3801cf1bbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_EnrollmentMusicClasses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMMC.Models.EnrollmentMusicClass>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4fceda9785546ad8047e1cd7e7b669e", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 40, false);
#line 16 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(296, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(352, 46, false);
#line 19 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Enrollment));

#line default
#line hidden
            EndContext();
            BeginContext(398, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(454, 46, false);
#line 22 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MusicClass));

#line default
#line hidden
            EndContext();
            BeginContext(500, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(618, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(667, 39, false);
#line 31 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(706, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(762, 58, false);
#line 34 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Enrollment.EnrollmentId));

#line default
#line hidden
            EndContext();
            BeginContext(820, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(876, 58, false);
#line 37 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MusicClass.MusicClassId));

#line default
#line hidden
            EndContext();
            BeginContext(934, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(990, 114, false);
#line 40 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id1 = item.EnrollmentId, id2 = item.MusicClassId /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1125, 119, false);
#line 41 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id1 = item.EnrollmentId, id2 = item.MusicClassId/* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1265, 117, false);
#line 42 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id1 = item.EnrollmentId, id2 = item.MusicClassId/* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\EnrollmentMusicClasses\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1421, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMMC.Models.EnrollmentMusicClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
