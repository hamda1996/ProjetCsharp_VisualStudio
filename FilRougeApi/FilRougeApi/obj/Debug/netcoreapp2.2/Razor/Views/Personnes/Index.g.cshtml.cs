#pragma checksum "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8a9b228b209d76837efa929b0410bc3e45f0b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnes_Index), @"mvc.1.0.view", @"/Views/Personnes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personnes/Index.cshtml", typeof(AspNetCore.Views_Personnes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8a9b228b209d76837efa929b0410bc3e45f0b7", @"/Views/Personnes/Index.cshtml")]
    public class Views_Personnes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FilRougeApi.Models.Personne>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 39, false);
#line 16 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 42, false);
#line 19 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(388, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(506, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(555, 38, false);
#line 28 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(593, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(649, 41, false);
#line 31 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(690, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 765, "\"", 796, 1);
#line 34 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
WriteAttributeValue("", 780, item.PersonneID, 780, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(797, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 849, "\"", 880, 1);
#line 35 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
WriteAttributeValue("", 864, item.PersonneID, 864, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(881, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 935, "\"", 966, 1);
#line 36 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
WriteAttributeValue("", 950, item.PersonneID, 950, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(967, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Personnes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1017, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FilRougeApi.Models.Personne>> Html { get; private set; }
    }
}
#pragma warning restore 1591
