#pragma checksum "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d355dd53cc145b9fcc2737dd7f284e04bc37ef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotnet.Pages.Pages_create), @"mvc.1.0.razor-page", @"/Pages/create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/create.cshtml", typeof(dotnet.Pages.Pages_create), null)]
namespace dotnet.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/_ViewImports.cshtml"
using dotnet;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d355dd53cc145b9fcc2737dd7f284e04bc37ef6", @"/Pages/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c685988959c55f18b7c321aaafeaf701f4899819", @"/Pages/_ViewImports.cshtml")]
    public class Pages_create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/create.cshtml"
  
    ViewData["Title"] = "Record creating";

#line default
#line hidden
            BeginContext(73, 21, true);
            WriteLiteral("<h1>Request URL:</h1>");
            EndContext();
            BeginContext(95, 15, false);
#line 6 "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/create.cshtml"
                Write(Model.login_url);

#line default
#line hidden
            EndContext();
            BeginContext(110, 31, true);
            WriteLiteral("\n<br/>\n<h1>Request Method:</h1>");
            EndContext();
            BeginContext(142, 18, false);
#line 8 "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/create.cshtml"
                   Write(Model.login_method);

#line default
#line hidden
            EndContext();
            BeginContext(160, 29, true);
            WriteLiteral("\n<br/>\n<h1>Request Body:</h1>");
            EndContext();
            BeginContext(190, 19, false);
#line 10 "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/create.cshtml"
                 Write(Model.login_request);

#line default
#line hidden
            EndContext();
            BeginContext(209, 97, true);
            WriteLiteral("\n<br/>\n<h1>Response:</h1>See console for output of application\n<br/>\n<br/>\n\n<h1>Request URL:</h1>");
            EndContext();
            BeginContext(307, 14, false);
#line 16 "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/create.cshtml"
                Write(Model.list_url);

#line default
#line hidden
            EndContext();
            BeginContext(321, 31, true);
            WriteLiteral("\n<br/>\n<h1>Request Method:</h1>");
            EndContext();
            BeginContext(353, 17, false);
#line 18 "/home/ix/dev/work/databoom/EnterpriseUniversalAPI/examples/dotnet/Pages/create.cshtml"
                   Write(Model.list_method);

#line default
#line hidden
            EndContext();
            BeginContext(370, 103, true);
            WriteLiteral("\n<br/>\n<h1>Request Body:</h1> None\n<br/>\n<h1>Response:</h1>See console for output of application\n<br/>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CreateModel>)PageContext?.ViewData;
        public CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
