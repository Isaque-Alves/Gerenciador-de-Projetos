#pragma checksum "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ec6c95f8cbed0e5cf6cc6ba9bd2cdf33fed40d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projeto_Index), @"mvc.1.0.view", @"/Views/Projeto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projeto/Index.cshtml", typeof(AspNetCore.Views_Projeto_Index))]
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
#line 1 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\_ViewImports.cshtml"
using Trabalho_Trimestral;

#line default
#line hidden
#line 2 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\_ViewImports.cshtml"
using Trabalho_Trimestral.Models;

#line default
#line hidden
#line 2 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec6c95f8cbed0e5cf6cc6ba9bd2cdf33fed40d8", @"/Views/Projeto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea753299c5ba788af0e6598bf26cf910a434272", @"/Views/_ViewImports.cshtml")]
    public class Views_Projeto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trabalho_Trimestral.Models.Projeto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "projeto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Tem certeza que deseja ecluir o componente?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(78, 108, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <center style=\"margin-top: 80px;\">\r\n        <h2>Projetos adicionados</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
         if (Context.Session.GetInt32("Administrador") == 1)
        {

#line default
#line hidden
            BeginContext(259, 33, true);
            WriteLiteral("            <p>\r\n                ");
            EndContext();
            BeginContext(292, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ec6c95f8cbed0e5cf6cc6ba9bd2cdf33fed40d86639", async() => {
                BeginContext(362, 60, true);
                WriteLiteral("\r\n                    Adicionar um projeto\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(426, 20, true);
            WriteLiteral("\r\n            </p>\r\n");
            EndContext();
#line 15 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(457, 223, true);
            WriteLiteral("    </center>\r\n\r\n    <table class=\"table table-sm table-hover\">\r\n        <tr>\r\n            <th>Data de Entrega</th>\r\n            <th>Nome</th>\r\n            <th>Solicitante</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 26 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
         foreach (Projeto p in ViewBag.Projetos)
        {


#line default
#line hidden
            BeginContext(743, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(782, 13, false);
#line 30 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
               Write(p.DataEntrega);

#line default
#line hidden
            EndContext();
            BeginContext(795, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(823, 6, false);
#line 31 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
               Write(p.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(829, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(857, 13, false);
#line 32 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
               Write(p.Solicitante);

#line default
#line hidden
            EndContext();
            BeginContext(870, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 34 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
                     if (Context.Session.GetInt32("Administrador") == 1)
                    {

#line default
#line hidden
            BeginContext(996, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1020, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ec6c95f8cbed0e5cf6cc6ba9bd2cdf33fed40d810737", async() => {
                BeginContext(1120, 62, true);
                WriteLiteral("\r\n                            Editar\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
                                                                          WriteLiteral(p.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1190, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1214, 268, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ec6c95f8cbed0e5cf6cc6ba9bd2cdf33fed40d813596", async() => {
                BeginContext(1415, 63, true);
                WriteLiteral("\r\n                            Excluir\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
                                                                           WriteLiteral(p.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1482, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1507, 46, true);
            WriteLiteral("                </td>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 49 "C:\Users\isaque.alves\source\repos\Trabalho-Trimestral\Trabalho-Trimestral\Views\Projeto\Index.cshtml"


        }

#line default
#line hidden
            BeginContext(1568, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trabalho_Trimestral.Models.Projeto> Html { get; private set; }
    }
}
#pragma warning restore 1591
