#pragma checksum "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a648e81e4a2f2d42cd5cb4d24235fb7b40ffd2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formations_Edit), @"mvc.1.0.view", @"/Views/Formations/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Formations/Edit.cshtml", typeof(AspNetCore.Views_Formations_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a648e81e4a2f2d42cd5cb4d24235fb7b40ffd2ed", @"/Views/Formations/Edit.cshtml")]
    public class Views_Formations_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilRougeApi.Models.Formation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(79, 1650, true);
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Formation</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""FormationID"" />
            <div class=""form-group"">
                <label asp-for=""PersonneID"" class=""control-label""></label>
                <select asp-for=""PersonneID"" class=""form-control"" asp-items=""ViewBag.PersonneID""></select>
                <span asp-validation-for=""PersonneID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Titre"" class=""control-label""></label>
                <input asp-for=""Titre"" class=""form-control"" />
                <span asp-validation-for=""Titre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Duree"" class=""control-label""></label>
                <input asp-for=""Duree"" class=""form-c");
            WriteLiteral(@"ontrol"" />
                <span asp-validation-for=""Duree"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Date_Deb"" class=""control-label""></label>
                <input asp-for=""Date_Deb"" class=""form-control"" />
                <span asp-validation-for=""Date_Deb"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1747, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilRougeApi.Models.Formation> Html { get; private set; }
    }
}
#pragma warning restore 1591