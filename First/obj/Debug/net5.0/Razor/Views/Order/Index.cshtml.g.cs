#pragma checksum "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\Fatih\source\repos\Projects\First\Views\_ViewImports.cshtml"
using First;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\source\repos\Projects\First\Views\_ViewImports.cshtml"
using First_Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"62c5d9161d2fb6cf9572c01953114cd23975b06269ad132c7e7fc34394f427f4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<First_Models.ViewModels.OrderListVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "FullName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Ad Soyad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "199", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "PhoneNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Telefon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "OrderStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Durum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "OrderDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "Sipariş Tarihi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "84", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("template", "<a rel=\'nofollow\' href=\'Order/Details/${Id}\' class=\'btn btn-primary\'> <i class=\'fas fa-list\'></i> <a> ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "Grid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Syncfusion.EJ2.Grids.Grid __Syncfusion_EJ2_Grids_Grid;
        private global::Syncfusion.EJ2.Grids.GridFilterSettings __Syncfusion_EJ2_Grids_GridFilterSettings;
        private global::Syncfusion.EJ2.Grids.GridLoadingIndicator __Syncfusion_EJ2_Grids_GridLoadingIndicator;
        private global::Syncfusion.EJ2.Grids.GridPageSettings __Syncfusion_EJ2_Grids_GridPageSettings;
        private global::Syncfusion.EJ2.Grids.GridColumns __Syncfusion_EJ2_Grids_GridColumns;
        private global::Syncfusion.EJ2.Grids.GridColumn __Syncfusion_EJ2_Grids_GridColumn;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c9736", async() => {
                WriteLiteral(@"
	<div class=""container p-4 my-3"">
		<h2 class=""text-info"">Sipariş Yönetimi</h2>
		<div class=""border bg-white p-3"" style=""border-radius:15px"">
			<div class=""row"">
				<div class=""col-12"">
					<div class=""row"" style=""padding-top:10px"">
						<div class=""col-4"">
							");
#nullable restore
#line 11 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
                       Write(Html.Editor("searchName", new { htmlAttributes = new {@class = "form-control", @placeholder = "İsim..."}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-4\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 14 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
                       Write(Html.Editor("searchEmail", new { htmlAttributes = new {@class = "form-control", @placeholder = "Email..."}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-4\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 17 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
                       Write(Html.Editor("searchPhone", new { htmlAttributes = new {@class = "form-control", @placeholder = "Telefon..."}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"row pt-1\">\r\n\t\t\t\t\t\t<div class=\"col-4\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 22 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
                       Write(Html.DropDownListFor(u=>u.Status,Model.StatusList,"--Sipariş Durumu--",new {@class="form-select"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"offset-4 col-4\">\r\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"h-100 btn btn-info form-control\">\r\n\t\t\t\t\t\t\t\t<i class=\"fas fa-search\"></i>Ara\r\n\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr />\r\n<div class=\"bg-white p-3\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ejs-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c13449", async() => {
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-filtersettings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c13740", async() => {
                }
                );
                __Syncfusion_EJ2_Grids_GridFilterSettings = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridFilterSettings>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridFilterSettings);
#nullable restore
#line 38 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridFilterSettings.Type = global::Syncfusion.EJ2.Grids.FilterType.Menu;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_EJ2_Grids_GridFilterSettings.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-loadingIndicator", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c15170", async() => {
                }
                );
                __Syncfusion_EJ2_Grids_GridLoadingIndicator = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridLoadingIndicator>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridLoadingIndicator);
#nullable restore
#line 39 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridLoadingIndicator.IndicatorType = global::Syncfusion.EJ2.Grids.IndicatorType.Shimmer;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("indicatorType", __Syncfusion_EJ2_Grids_GridLoadingIndicator.IndicatorType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-pagesettings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c16645", async() => {
                }
                );
                __Syncfusion_EJ2_Grids_GridPageSettings = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridPageSettings>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridPageSettings);
#nullable restore
#line 40 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridPageSettings.PageSize = 10;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("pageSize", __Syncfusion_EJ2_Grids_GridPageSettings.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c18033", async() => {
                    WriteLiteral("\r\n\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c18340", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 42 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.IsPrimaryKey = true;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("isPrimaryKey", __Syncfusion_EJ2_Grids_GridColumn.IsPrimaryKey, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Right;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c20816", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 43 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Right;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c22670", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 44 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Right;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c24721", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#nullable restore
#line 45 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Right;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c26577", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_12.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#nullable restore
#line 46 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Right;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c28435", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_13.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_14.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
#nullable restore
#line 47 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.TextAlign = global::Syncfusion.EJ2.Grids.TextAlign.Right;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("textAlign", __Syncfusion_EJ2_Grids_GridColumn.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.CustomFormat = (new { type="date", format="dd/MM/yyyy" });

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("customFormat", __Syncfusion_EJ2_Grids_GridColumn.CustomFormat, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9fcf9cb6ca9ddeb778d338087becd1d65da2e41ccb322de8bbebdedd2649c30756", async() => {
                        WriteLiteral("\r\n\r\n\t\t\t");
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_15.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                    __Syncfusion_EJ2_Grids_GridColumn.Width = (string)__tagHelperAttribute_16.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
                    __Syncfusion_EJ2_Grids_GridColumn.Template = (string)__tagHelperAttribute_17.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t");
                }
                );
                __Syncfusion_EJ2_Grids_GridColumns = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumns>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumns);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
            }
            );
            __Syncfusion_EJ2_Grids_Grid = CreateTagHelper<global::Syncfusion.EJ2.Grids.Grid>();
            __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_Grid);
            __Syncfusion_EJ2_Grids_Grid.Id = (string)__tagHelperAttribute_18.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_18);
#nullable restore
#line 37 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.DataSource = Model.OrderHList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("dataSource", __Syncfusion_EJ2_Grids_Grid.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowFiltering = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("allowFiltering", __Syncfusion_EJ2_Grids_Grid.AllowFiltering, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowSorting = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("allowSorting", __Syncfusion_EJ2_Grids_Grid.AllowSorting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Fatih\source\repos\Projects\First\Views\Order\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowPaging = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("allowPaging", __Syncfusion_EJ2_Grids_Grid.AllowPaging, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<First_Models.ViewModels.OrderListVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
