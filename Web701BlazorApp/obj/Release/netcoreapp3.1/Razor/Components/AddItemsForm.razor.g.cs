#pragma checksum "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ae9c52d6b2f812bd60041cf703ad3832389993d"
// <auto-generated/>
#pragma warning disable 1591
namespace Web701BlazorApp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Web701BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Web701BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
using Web701BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
using SQLReflectionMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
using Web701BlazorApp.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
using Web701BlazorApp.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class AddItemsForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
  Thread.CurrentThread.CurrentCulture = new CultureInfo("en-NZ");

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
                  item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
                                       OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "bg-white shadow-md rounded px-8 pt-6 pb-8 mb-4 w-full max-w-4xl");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "grid grid-cols-2 gap-1");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "mb-4");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<label class=\"block text-gray-700 text-sm font-bold mb-2\" for=\"itemname\">Item Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline");
                __builder2.AddAttribute(17, "placeholder", "Item Name");
                __builder2.AddAttribute(18, "id", "itemname");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
                                    item.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Name = __value, item.Name))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "mb-4");
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.AddMarkupContent(27, "<label class=\"block text-gray-700 text-sm font-bold mb-2\" for=\"itemsize\">Item Size (cm.)</label>\r\n            ");
                __Blazor.Web701BlazorApp.Components.AddItemsForm.TypeInference.CreateInputNumber_0(__builder2, 28, 29, "shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline", 30, "Item Size", 31, "itemsize", 32, "15", 33, 
#nullable restore
#line 22 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
                                      item.Size

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Size = __value, item.Size)), 35, () => item.Size);
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "mb-4");
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.AddMarkupContent(41, "<label class=\"block text-gray-700 text-sm font-bold mb-2\" for=\"item\">Item Quantity</label>\r\n            ");
                __Blazor.Web701BlazorApp.Components.AddItemsForm.TypeInference.CreateInputNumber_1(__builder2, 42, 43, "shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline", 44, "Item Quantity", 45, "itemqty", 46, 
#nullable restore
#line 26 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
                                      item.Quantity

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Quantity = __value, item.Quantity)), 48, () => item.Quantity);
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "mb-4");
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.AddMarkupContent(54, "<label class=\"block text-gray-700 text-sm font-bold mb-2\" for=\"itemcat\">Item Category</label>\r\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "relative");
                __builder2.AddMarkupContent(57, "\r\n                ");
                __Blazor.Web701BlazorApp.Components.AddItemsForm.TypeInference.CreateInputSelect_2(__builder2, 58, 59, "block appearance-none w-full bg-gray-200 border border-gray-200 text-gray-700 py-3 px-4 rounded leading-tight focus:outline-none focus:bg-white focus:border-gray-500", 60, "itemcat", 61, 
#nullable restore
#line 31 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
                                          item.Category

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Category = __value, item.Category)), 63, () => item.Category, 64, (__builder3) => {
                    __builder3.AddMarkupContent(65, "\r\n                    ");
                    __builder3.AddMarkupContent(66, "<option value>Select category ...</option>\r\n                    ");
                    __builder3.AddMarkupContent(67, "<option value=\"extra\">Extra</option>\r\n                    ");
                    __builder3.AddMarkupContent(68, "<option value=\"1st\">I</option>\r\n                    ");
                    __builder3.AddMarkupContent(69, "<option value=\"2nd\">II</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(70, "\r\n                ");
                __builder2.AddMarkupContent(71, @"<div class=""pointer-events-none absolute inset-y-0 right-0 flex items-center px-2 text-gray-700"">
                    <svg class=""fill-current h-4 w-4"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20""><path d=""M9.293 12.95l.707.707L15.657 8l-1.414-1.414L10 10.828 5.757 6.586 4.343 8z""></path></svg>
                </div>
            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "mb-6");
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.AddMarkupContent(78, "<label class=\"block text-gray-700 text-sm font-bold mb-2\" for=\"itemsize\">Calculated Buy Out Price</label>\r\n        ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "disabled", "true");
                __builder2.AddAttribute(81, "value", 
#nullable restore
#line 47 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
                                       PriceCalc()

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(82, "class", "shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline");
                __builder2.AddAttribute(83, "placeholder", "Item Size");
                __builder2.AddAttribute(84, "id", "itemsize");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n    ");
                __builder2.AddMarkupContent(87, "<div class=\"flex items-center justify-between\">\r\n        <button class=\"bg-gray-800 hover:bg-gray-600 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline\" type=\"submit\">\r\n            Add Item\r\n        </button>\r\n    </div>\r\n    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "mt-4 text-red-700");
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(91);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Components\AddItemsForm.razor"
       
    private Item item = new Item();
    private string PriceCalc()
    {
        return $"{calculation().ToString("C")}";
    }
    private float calculation() // price calculator based on form params
    {
        double boPrice = 1;
        switch (item.Category)
        {
            case "extra":
                boPrice = boPrice * 1.3 + item.Size * 0.1;
                break;
            case "1st":
                boPrice = boPrice * 1.1 + item.Size * 0.1;
                break;
            default:
                boPrice = boPrice * 1 + item.Size * 0.1;
                break;
        }

        return (float)boPrice * item.Quantity;
    }
    private async void OnSubmit() //request db upon form submit
    {
        item.BuyOutPrice = calculation();
        var uid = await Common.GetCurrentUserId(AuthenticationStateProvider);
        var p = new ParamList
        {
            ["ItemName"] = item.Name,
            ["BuyOutPrice"] = item.BuyOutPrice,
            ["MemberId"] = uid,
            ["ItemCat"] = item.Category,
            ["ItemSize"] = item.Size,
            ["Qty"] = item.Quantity
        };
        try
        {
            DBExecuter.execNonQuerySPAutoFillParams("sp_AddItem", p);
            StateControl.OrderPlacement.Inserted();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.GetBaseException().Message);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateControl StateControl { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
namespace __Blazor.Web701BlazorApp.Components.AddItemsForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "max", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
