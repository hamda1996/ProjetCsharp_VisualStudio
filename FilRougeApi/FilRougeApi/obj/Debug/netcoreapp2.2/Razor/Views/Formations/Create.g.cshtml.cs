#pragma checksum "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00783d514b7f1fdf88150cc45c408d33368a346d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formations_Create), @"mvc.1.0.view", @"/Views/Formations/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Formations/Create.cshtml", typeof(AspNetCore.Views_Formations_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00783d514b7f1fdf88150cc45c408d33368a346d", @"/Views/Formations/Create.cshtml")]
    public class Views_Formations_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilRougeApi.Models.Formation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(81, 1515, true);
            WriteLiteral(@"
<h1>Create</h1>

<h4>Formation</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""PersonneID"" class=""control-label""></label>
                <select asp-for=""PersonneID"" class =""form-control"" asp-items=""ViewBag.PersonneID""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Titre"" class=""control-label""></label>
                <input asp-for=""Titre"" class=""form-control"" />
                <span asp-validation-for=""Titre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Duree"" class=""control-label""></label>
                <input asp-for=""Duree"" class=""form-control"" />
                <span asp-validation-for=""Duree"" class=""text-danger""></span>
            </div>
            <div class=""for");
            WriteLiteral(@"m-group"">
                <label asp-for=""Date_Deb"" class=""control-label""></label>
                <input asp-for=""Date_Deb"" class=""form-control"" />
                <span asp-validation-for=""Date_Deb"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
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
                BeginContext(1614, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Create.cshtml"
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
