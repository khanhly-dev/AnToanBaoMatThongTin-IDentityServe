#pragma checksum "D:\Project\Quickstarts\4_JavaScriptClient\src\MvcClient\Views\Shared\json.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61284ebad0b4d6bc2db3a2cb8203f7f4ee3a8136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_json), @"mvc.1.0.view", @"/Views/Shared/json.cshtml")]
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
#line 1 "D:\Project\Quickstarts\4_JavaScriptClient\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\Quickstarts\4_JavaScriptClient\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61284ebad0b4d6bc2db3a2cb8203f7f4ee3a8136", @"/Views/Shared/json.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc1f45ec327c217f62474bbe078819a158424a43", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_json : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<pre>");
#nullable restore
#line 1 "D:\Project\Quickstarts\4_JavaScriptClient\src\MvcClient\Views\Shared\json.cshtml"
Write(ViewBag.Json);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>");
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
