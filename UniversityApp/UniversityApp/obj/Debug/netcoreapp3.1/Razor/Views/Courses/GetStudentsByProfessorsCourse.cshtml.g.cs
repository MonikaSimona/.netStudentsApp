#pragma checksum "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b0737cf9f24a00542bdf9bb869001869a6777d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_GetStudentsByProfessorsCourse), @"mvc.1.0.view", @"/Views/Courses/GetStudentsByProfessorsCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b0737cf9f24a00542bdf9bb869001869a6777d7", @"/Views/Courses/GetStudentsByProfessorsCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad95a638237f3f256aa08dc63160873bdeb208b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_GetStudentsByProfessorsCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityApp.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enrollments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProfessorStudentChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
  
    ViewData["Title"] = "GetStudentsByProfessorsCourse";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Students on this course</h2>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Index
            </th>
            <th>
                Total Points
            </th>
            <th>
                Seminar URl
            </th>

            <th>
                Grade
            </th>
            <th>
                Enrollment Date
            </th>
            
            <th>Finish Date</th>
            <th></th>

        </tr>
    </thead>
    <tbody>
        

");
#nullable restore
#line 40 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
        foreach (var student in Model.Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
             if (student.Student.FullName != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
               Write(student.Student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 49 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
           Write(student.Student.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
           Write(student.ExamPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 55 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                                 Write(student.ProjectPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 55 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                                                          Write(student.SeminarPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 55 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                                                                                   Write(student.AdditionalPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
           Write(student.SeminarUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
           Write(student.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
           Write(student.Student.EnrollmentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 68 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                 if(student.FinishDate != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
               Write(student.FinishDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                                       
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Enrolled</p>\r\n");
#nullable restore
#line 75 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 79 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                 if (student.FinishDate == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b0737cf9f24a00542bdf9bb869001869a6777d710861", async() => {
                WriteLiteral("Change");
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
#line 81 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                                                                                           WriteLiteral(student.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Finished</p>\r\n");
#nullable restore
#line 86 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        \r\n\r\n        </tr>\r\n");
#nullable restore
#line 92 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\.netStudentsApp\UniversityApp\UniversityApp\Views\Courses\GetStudentsByProfessorsCourse.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </tbody>\r\n</table>\r\n\r\n");
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
