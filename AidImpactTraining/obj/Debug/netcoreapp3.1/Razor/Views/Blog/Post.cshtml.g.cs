#pragma checksum "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7070c1f2c03f7de90c888be5c48399b53ff07b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Post), @"mvc.1.0.view", @"/Views/Blog/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7070c1f2c03f7de90c888be5c48399b53ff07b1", @"/Views/Blog/Post.cshtml")]
    public class Views_Blog_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AidImpactTraining.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Post.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\"><hr></div>\r\n    <div class=\"container\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 8 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Post.cshtml"
   Write(await Html.PartialAsync("_Post"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"mb-4\">\r\n            <a class=\"btn btn-outline-secondary mr-2 mb-3\"");
            BeginWriteAttribute("href", " href=\"", 370, "\"", 405, 1);
#nullable restore
#line 11 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Post.cshtml"
WriteAttributeValue("", 377, Url.Action("Index", "Blog"), 377, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-backward mr-2\"></i><span class=\"d-none d-md-inline\">Retour</span></a>\r\n        </div>\r\n            <div class=\"container\"><hr></div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AidImpactTraining.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
