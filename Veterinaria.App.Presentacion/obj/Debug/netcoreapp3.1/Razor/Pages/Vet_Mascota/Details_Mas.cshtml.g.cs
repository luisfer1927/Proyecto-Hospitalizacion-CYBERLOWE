#pragma checksum "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\Vet_Mascota\Details_Mas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "465975f7de3b9f6f5c5338f1e0acdc75c277ecea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Vet_Mascota.Pages_Vet_Mascota_Details_Mas), @"mvc.1.0.razor-page", @"/Pages/Vet_Mascota/Details_Mas.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Vet_Mascota
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
#line 1 "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465975f7de3b9f6f5c5338f1e0acdc75c277ecea", @"/Pages/Vet_Mascota/Details_Mas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vet_Mascota_Details_Mas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Lista", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\Vet_Mascota\Details_Mas.cshtml"
Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    id: ");
#nullable restore
#line 7 "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\Vet_Mascota\Details_Mas.cshtml"
   Write(Model.Mascota.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Edad: ");
#nullable restore
#line 10 "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\Vet_Mascota\Details_Mas.cshtml"
     Write(Model.Mascota.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Tipo_Mascota: ");
#nullable restore
#line 13 "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\Vet_Mascota\Details_Mas.cshtml"
             Write(Model.Mascota.Tipo_Mascota);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Estado_Salud: ");
#nullable restore
#line 16 "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\Vet_Mascota\Details_Mas.cshtml"
             Write(Model.Mascota.Estado_Salud);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    dueño: ");
#nullable restore
#line 19 "C:\proyecto\Proyecto-MASCOTAFELIZ-CYBERLOWE\Veterinaria.App.Presentacion\Pages\Vet_Mascota\Details_Mas.cshtml"
      Write(Model.Mascota.dueño);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "465975f7de3b9f6f5c5338f1e0acdc75c277ecea5464", async() => {
                WriteLiteral("Lista de Mascota");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.Details_MasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.Details_MasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.Details_MasModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.Details_MasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
