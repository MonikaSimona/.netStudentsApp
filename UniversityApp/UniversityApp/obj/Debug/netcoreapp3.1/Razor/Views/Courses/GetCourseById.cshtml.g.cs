#pragma checksum "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b50d1934e1e021c3cfe76de0bee2e3aed33777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_GetCourseById), @"mvc.1.0.view", @"/Views/Courses/GetCourseById.cshtml")]
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
#line 1 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b50d1934e1e021c3cfe76de0bee2e3aed33777", @"/Views/Courses/GetCourseById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad95a638237f3f256aa08dc63160873bdeb208b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_GetCourseById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityApp.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Professors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
  
    ViewData["Title"] = "GetCourseById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h2>Course ");
#nullable restore
#line 8 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
      Write(Html.DisplayFor(item => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Year\r\n            </th>\r\n            <th>\r\n                Semester\r\n            </th>\r\n        </tr>\r\n        \r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n");
#nullable restore
#line 25 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
             if (Model.Semester != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    Not Specified\r\n                </td>\r\n                <td>\r\n                  ");
#nullable restore
#line 31 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
             Write(Model.Semester);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 33 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tr>
       
    </tbody>
</table>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Professors Teaching <br /> on this course
            </th>
            <th>
                Degree
            </th>
            <th>
                Academic Rank
            </th>
            
        </tr>
       
    </thead>
    <tbody>
        <tr>
");
#nullable restore
#line 57 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
             if (Model.FirstProfessor != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b50d1934e1e021c3cfe76de0bee2e3aed337776536", async() => {
                WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
                                                                                                            Write(Model.FirstProfessor.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
                                                                          WriteLiteral(Model.FirstProfessor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
               Write(Model.FirstProfessor.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
               Write(Model.FirstProfessor.AcademicRank);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 68 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n");
#nullable restore
#line 71 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
             if (Model.SecondProfessor != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b50d1934e1e021c3cfe76de0bee2e3aed3377710792", async() => {
                WriteLiteral(" ");
#nullable restore
#line 74 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
                                                                                                             Write(Model.SecondProfessor.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
                                                                          WriteLiteral(Model.SecondProfessor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
               Write(Model.SecondProfessor.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
               Write(Model.SecondProfessor.AcademicRank);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 82 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetCourseById.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityApp.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
