#pragma checksum "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e1caf571b7a76b77f4a8a8ce95834a6ec83f77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\_ViewImports.cshtml"
using GestionProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\_ViewImports.cshtml"
using GestionProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e1caf571b7a76b77f4a8a8ce95834a6ec83f77", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e0241b3ac3ce846973a3b0cefaae9a47eea6e7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\User\Index.cshtml"
   Layout = "_DashboardLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row page-titles"">
    <div class=""col-md-5 align-self-center"">
        <h3 class=""txt-themecolor"">List Users</h3>
    </div>
    <div class=""col-md-7 align-self-center"">

    </div>

</div>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">

                    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"" data-whatever=""");
            WriteLiteral(@"@mdo"">Add New Task </button>


                    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalLabel"">Create User </h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e1caf571b7a76b77f4a8a8ce95834a6ec83f774786", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-8 col-sm-6"">
                                                <label>Full Name</label>
                                                <input class=""form-control"" type=""text"" name=""name"">
                                            </div>
                                            <div class=""col-4 col-sm-6"">
                                                <label>Username</label>
                                                <input class=""form-control"" type=""text"" name=""username"">
                                            </div>
                                        </div>


                                        <div class=""form-group"">
                                            <label for=""date"" class=""col-form-label"">date:</label>
                                            <input type=""datetime"" class=""form-control"" id=""completed"">
                                        </div>


");
                WriteLiteral(@"                                        <div class=""form-group"">
                                            <label for=""email"" class=""col-form-label"">email:</label>
                                            <input type=""email"" class=""form-control"" id=""completed"">
                                        </div>
                                        <div class=""form-group"">

                                            <label for=""password"" class=""col-form-label""> Password:</label>
                                            <input class=""form-control"" type=""password"" placeholder=""••••••"">
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                    <button type=""button"" class=""btn btn-primary"">Add</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>




        </div>
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">


                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>Full Name</th>
                                    <th>User Name</th>
                                    <th>Date</th>
                                    <th>Email</th>
                   ");
            WriteLiteral(@"                 <th class=""text-nowrap"">Action</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>eli max</td>
                                    <td>eli </td>


                                    <td>May 15, 2015</td>
                                    <td> sjndjkndf@gmail.com</td>

                                    <td class=""text-nowrap"">
                                        <a href=""#"" data-toggle=""tooltip"" data-original-title=""Edit""> <i class=""fas fa-pencil-alt text-inverse mr-1""></i> </a>
                                        <a href=""#"" data-toggle=""tooltip"" data-original-title=""Close""> <i class=""fas fa-times text-danger""></i> </a>
                                    </td>
                                </tr>


                            </tbody>
                        </table>
                    </div>
                    <!-- /#page-content-wrapp");
            WriteLiteral(@"er -->
                    <nav aria-label=""..."">
                        <ul class=""pagination"">
                            <li class=""page-item disabled"">
                                <span class=""page-link"">Previous</span>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item active"" aria-current=""page"">
                                <span class=""page-link"">
                                    2
                                    <span class=""sr-only"">(current)</span>
                                </span>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
 ");
            WriteLiteral("       </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591