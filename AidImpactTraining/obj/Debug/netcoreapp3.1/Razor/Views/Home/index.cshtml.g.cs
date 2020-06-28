#pragma checksum "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d0e984cf319ebcdde7421d3e55d2c05c2cde20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d0e984cf319ebcdde7421d3e55d2c05c2cde20", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Home\Index.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""about-me-section p-3 p-lg-5 theme-bg-light"">
    <div class=""container"">
        <div class=""profile-teaser media flex-column flex-lg-row"">

            <div class=""media-body"">
                <h2 class=""name font-weight-bold mb-1"">Jérémy Bourgne</h2>
                <div class=""tagline mb-3"">Développeur Logiciel Junior</div>
                <div class=""bio mb-4"">
                    Je suis développeur logiciel spécialisé dans le backend en alternance chez Studec. Ce blog à été réalisé dans le but de revoir et d'approfondir mes connaissances en ASP.NET Core MVC.

                    <h4 class=""my-3"">Points sur lesquels j'ai travaillé :</h4>
                    <ul class=""mb-5"">
                        <li class=""mb-2"">La configuration du fichier « startup »</li>
                        <li class=""mb-2"">Le « Model-View-Controller » (MVC)</li>
                        <li class=""mb-2"">Les « Razor Pages » et les « Partials »</li>
                        <li class=""mb-2"">Le concept de « Partial ");
            WriteLiteral(@"Rendering »</li>
                        <li class=""mb-2"">Les « Tag helpers » pour simplifier les formulaires</li>
                        <li class=""mb-2"">La communication vers une BDD avec « Entity Framework »</li>
                        <li class=""mb-2"">Sécurité de l'application avec « Authorized »</li>
                        <li class=""mb-2"">Système d'inscription, de connexion et de déconnexion avec les « Identity Services »</li>
                    </ul>
                </div><!--//bio-->
                <div class=""mb-4"">
                    <a class=""btn btn-primary mr-2 mb-3""");
            BeginWriteAttribute("href", " href=\"", 1641, "\"", 1676, 1);
#nullable restore
#line 26 "C:\Users\Bourgne\source\repos\AidImpactTraining\AidImpactTraining\Views\Home\Index.cshtml"
WriteAttributeValue("", 1648, Url.Action("Index", "Blog"), 1648, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-arrow-alt-circle-right mr-2""></i><span class=""d-none d-md-inline"">Voir le</span> Blog</a>
                    <a class=""btn btn-secondary mr-2 mb-3"" href=""https://github.com/BourgneJeremy/AidImpactTraining"" target=""_blank""><i class=""fab fa-github-alt mr-2""></i><span class=""d-none d-md-inline"">Github</span></a>
                </div>
            </div><!--//media-body-->
            <img class=""profile-image mb-3 mb-lg-0 ml-lg-5 mr-md-0"" style=""width: 15.5em; height: 24em;"" src=""assets/images/profile-lg.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2207, "\"", 2213, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n    </div>\n</section><!--//about-me-section-->");
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
