#pragma checksum "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\TutorTypes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ab34ccd732690422b368168c358285c3519d1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TutorTypes_Details), @"mvc.1.0.view", @"/Views/TutorTypes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TutorTypes/Details.cshtml", typeof(AspNetCore.Views_TutorTypes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5ab34ccd732690422b368168c358285c3519d1c", @"/Views/TutorTypes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a060a0b77bef058bf727801f1ef3801cf1bbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_TutorTypes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMMC.Models.TutorType>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\TutorTypes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 290, true);
            WriteLiteral(@"
<div class=""card border-primary mb-3"" style=""max-width: 20rem;"">
    <div class=""card-header"">Details</div>
    <div class=""card-body"">
        <h4 class=""card-title"">
            Tutor Type
        </h4>
        <dl class=""dl-horizontal"">
            <dt>
                Tutor: ");
            EndContext();
            BeginContext(366, 60, false);
#line 15 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\TutorTypes\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Tutor.Staff.Person.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(426, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(428, 59, false);
#line 15 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\TutorTypes\Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.Tutor.Staff.Person.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(487, 106, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n\r\n            </dd>\r\n            <dt>\r\n                Instrument: ");
            EndContext();
            BeginContext(594, 54, false);
#line 21 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\TutorTypes\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Instrument.Instrument1));

#line default
#line hidden
            EndContext();
            BeginContext(648, 105, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n\r\n            </dd>\r\n            <dt>\r\n                Max Grade: ");
            EndContext();
            BeginContext(754, 40, false);
#line 27 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\TutorTypes\Details.cshtml"
                      Write(Html.DisplayFor(model => model.MaxGrade));

#line default
#line hidden
            EndContext();
            BeginContext(794, 106, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(901, 68, false);
#line 36 "C:\Users\dinnm1\Desktop\git\smmc\SMMC - Copy\SMMC\Views\TutorTypes\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(969, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(977, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13a6d27e1ade4c73bb010c8a489d24b9", async() => {
                BeginContext(999, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1015, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMMC.Models.TutorType> Html { get; private set; }
    }
}
#pragma warning restore 1591
