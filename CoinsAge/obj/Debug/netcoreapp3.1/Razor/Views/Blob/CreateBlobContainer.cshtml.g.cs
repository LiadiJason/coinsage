#pragma checksum "C:\Users\Jason Liadi\Desktop\APU Y3S6\DDAC\Assignment\CoinsAge\CoinsAge\Views\Blob\CreateBlobContainer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bed7bb2912acbe2444c647f5f446e590a68b274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blob_CreateBlobContainer), @"mvc.1.0.view", @"/Views/Blob/CreateBlobContainer.cshtml")]
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
#line 1 "C:\Users\Jason Liadi\Desktop\APU Y3S6\DDAC\Assignment\CoinsAge\CoinsAge\Views\_ViewImports.cshtml"
using CoinsAge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jason Liadi\Desktop\APU Y3S6\DDAC\Assignment\CoinsAge\CoinsAge\Views\_ViewImports.cshtml"
using CoinsAge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bed7bb2912acbe2444c647f5f446e590a68b274", @"/Views/Blob/CreateBlobContainer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd85cd8132af269000beadc4cb6f34f0b18df93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blob_CreateBlobContainer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jason Liadi\Desktop\APU Y3S6\DDAC\Assignment\CoinsAge\CoinsAge\Views\Blob\CreateBlobContainer.cshtml"
  
    ViewData["Title"] = "CreateBlobContainer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreateBlobContainer</h1>\r\n\r\n<p>\r\n    The ");
#nullable restore
#line 9 "C:\Users\Jason Liadi\Desktop\APU Y3S6\DDAC\Assignment\CoinsAge\CoinsAge\Views\Blob\CreateBlobContainer.cshtml"
   Write(ViewBag.BlobContainerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is created!\r\n    ");
#nullable restore
#line 10 "C:\Users\Jason Liadi\Desktop\APU Y3S6\DDAC\Assignment\CoinsAge\CoinsAge\Views\Blob\CreateBlobContainer.cshtml"
Write(ViewBag.Success == true ? "Succeeded!" : "Failed! Because the container is exist.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
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
