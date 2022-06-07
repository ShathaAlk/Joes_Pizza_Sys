#pragma checksum "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa6d75d91f70b332cc34627de6a677df616b24fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderConfirmation), @"mvc.1.0.view", @"/Views/Home/OrderConfirmation.cshtml")]
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
#line 1 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\_ViewImports.cshtml"
using Joes_Pizza_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\_ViewImports.cshtml"
using Joes_Pizza_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa6d75d91f70b332cc34627de6a677df616b24fb", @"/Views/Home/OrderConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53e7118c8a43c845e1cc23fc873959178151112", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
  

    List<CustomerOrderTable> COT = ViewData["Orders Details"] as List<CustomerOrderTable>;
    Order ord = ViewData["Order"] as Order;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6d75d91f70b332cc34627de6a677df616b24fb4712", async() => {
                WriteLiteral("\r\n    <title>Order Confirmation</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6d75d91f70b332cc34627de6a677df616b24fb5719", async() => {
                WriteLiteral(@"

    <div class=""boxed-page"">     
        <section id=""gtco-OrderConfirmation"" class=""bg-fixed bg-white section-padding justify-content-center"">
            <div class=""container text-center"">
                <div class=""row justify-content-center pb-5"">
                    <span class=""col-4 subheading-red""><strong>&#9312; Shopping Cart</strong></span>
                    <span class=""col-4 subheading-red""><strong>&#9313; Billing & Checkout</strong></span>
                    <span class=""col-4 subheading-red""><strong>&#9314; Order Confirmation</strong></span>
                </div>
                <div class=""row justify-content-center"" id=""DivOrderConfirm"">
                    <div class=""col-lg-10"">
                        <div class=""section-content bg-white p-3 shadow"">
                            <div class=""heading-section"">
                                <span class=""subheading"">
                                    Confirmation
                                </span>
             ");
                WriteLiteral(@"                   <h2>
                                    The Order
                                </h2>
                                <img style=""width: 85px;"" src=""/img/checked.png"" />
                                <div class=""py-3"">
                                    <span class=""subheading"" style=""font-size:18px"">Order No. ");
#nullable restore
#line 39 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                                                                         Write(ord.OrderID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12 col-lg-12"">
                                    <div class=""row mb-0 text-center"">
                                        <div class=""col-1 themed-grid-col text-muted""></div>
                                        <div class=""col-3 themed-grid-col text-muted""><h6>Item Name</h6></div>
                                        <div class=""col-2 themed-grid-col text-muted""><h6>Price</h6></div>
                                        <div class=""col-3 themed-grid-col text-muted""><h6>Quantity</h6></div>
                                        <div class=""col-2 themed-grid-col text-muted""><h6>Total</h6></div>
                                    </div>


                                    <hr class=""my-4"">
                                    <div class=""Customeritems"">
");
#nullable restore
#line 55 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                         foreach (var item in COT)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""rowClass row mb-1 text-center"">
                                            <div class=""col-1 themed-grid-col text-muted""></div>
                                            <div class=""col-3 themed-grid-col text-muted"">
                                                <h6 class=""my-0"">");
#nullable restore
#line 60 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                                            Write(item.PizzaItem.PizzaName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                                <br />\r\n                                            </div>\r\n                                            <div class=\"col-2 themed-grid-col text-muted\"><span class=\"text-muted price\">$");
#nullable restore
#line 63 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                                                                                                     Write(item.PizzaItem.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                            <div class=\"col-3 themed-grid-col text-muted\">\r\n                                                <span class=\"text-muted Quantity\">");
#nullable restore
#line 65 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                                                             Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            </div>\r\n                                            <div class=\"col-2 themed-grid-col text-muted\"><span class=\"text-muted Total\">$");
#nullable restore
#line 67 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                                                                                                     Write(item.TotalPricePerItem);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 70 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <hr class=""my-4"">

                                        <div class=""row mb-2"">
                                            <div class=""col-12 themed-grid-col text-muted"">
                                                <h5 class=""my-0 text-center"">Total Price. $");
#nullable restore
#line 75 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                                                                      Write(ord.TotalAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>

                                            </div>
                                        </div>
                                        <div class=""row mb-2 justify-content-center"">
                                            <div class=""col-6 themed-grid-col "">
                                                <span class=""subheading"">Order Date. ");
#nullable restore
#line 81 "C:\Users\shath\source\repos\BackUps - .NET Projects\Joes_Pizza_Shop\Joes_Pizza_Shop\Views\Home\OrderConfirmation.cshtml"
                                                                                Write(ord.OrderDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                                            </div>
                                        </div>
                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </section>
        <!-- End of Order Checkout Section -->
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
