#pragma checksum "C:\Users\Fatih\source\repos\Projects\First\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6941492dbf88b94d7358db72de55c783cd525548ad9ec087d27e472bd4f3d7e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Fatih\source\repos\Projects\First\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\source\repos\Projects\First\Areas\Identity\Pages\_ViewImports.cshtml"
using First.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatih\source\repos\Projects\First\Areas\Identity\Pages\_ViewImports.cshtml"
using First.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Fatih\source\repos\Projects\First\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using First.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6941492dbf88b94d7358db72de55c783cd525548ad9ec087d27e472bd4f3d7e8", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"67d8b6f5b6c151ceeee169715b798e6c119eb32a4533ff138a4b658ac9bf2bc7", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7bbe8576cbde9c25fe5b390363b2d70e4dd6dbdfa76273fa78768201595197db", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Fatih\source\repos\Projects\First\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Email Onaylama";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Fatih\source\repos\Projects\First\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
