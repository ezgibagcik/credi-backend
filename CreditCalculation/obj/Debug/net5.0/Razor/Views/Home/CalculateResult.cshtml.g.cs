#pragma checksum "C:\Users\ezgib\source\repos\Staj\CreditCalculation\Views\Home\CalculateResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb09eb338b1eda7d7aeda11936b6d08e188a02a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CalculateResult), @"mvc.1.0.view", @"/Views/Home/CalculateResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb09eb338b1eda7d7aeda11936b6d08e188a02a8", @"/Views/Home/CalculateResult.cshtml")]
    public class Views_Home_CalculateResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.PaymentPlan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ezgib\source\repos\Staj\CreditCalculation\Views\Home\CalculateResult.cshtml"
  
    ViewData["Title"] = "CalculateResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>sonuç: ");
#nullable restore
#line 6 "C:\Users\ezgib\source\repos\Staj\CreditCalculation\Views\Home\CalculateResult.cshtml"
      Write(ViewBag.r);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.PaymentPlan> Html { get; private set; }
    }
}
#pragma warning restore 1591