#pragma checksum "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52b7d597ff453b7eff8001c0390c5446e83f6a07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b7d597ff453b7eff8001c0390c5446e83f6a07", @"/Views/Blog/Index.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AidImpactTraining.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""cta-section theme-bg-light py-5"">
    <div class=""container text-center single-col-max-width"">
        <h2 class=""heading"">Mon Blog</h2>
        <div class=""intro"">
            <p>Retrouvez mes 5 derniers articles réalisés via ASP.NET Core MVC</p>
            <p>Date actuelle : ");
#nullable restore
#line 9 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
                          Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n\n        <div>\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 457, "\"", 493, 1);
#nullable restore
#line 13 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
WriteAttributeValue("", 464, Url.Action("Create", "Blog"), 464, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Créer un article</a>\n        </div>\n\n    </div><!--//container-->\n</section>\n\n<div class=\"container\">\n    <section>\n        <div class=\"blog-posts\">\n");
#nullable restore
#line 22 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
             foreach (var post in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <article class=\"blog-post mt-3\">\n                    <h1>\n                        ");
#nullable restore
#line 26 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
                   Write(Html.ActionLink(post.Title, "Post", "Blog",
                                                new { year = post.Posted.Year, month = post.Posted.Month, key = post.Key }
                                            ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </h1>\n                    <div class=\"details\">\n                        Créé le <span>");
#nullable restore
#line 31 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
                                 Write(post.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> par <span>");
#nullable restore
#line 31 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
                                                               Write(post.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    <div class=\"content\">\n                        ");
#nullable restore
#line 34 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
                   Write(post.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </article>\n");
#nullable restore
#line 37 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"container\"><hr></div>\n    </section>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AidImpactTraining.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
