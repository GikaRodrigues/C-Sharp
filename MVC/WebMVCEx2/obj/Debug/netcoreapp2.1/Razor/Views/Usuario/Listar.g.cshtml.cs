#pragma checksum "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760d0090916b9bdbffe5ba1971099dc9ff4e464f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 1 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
using WebMVCEx2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760d0090916b9bdbffe5ba1971099dc9ff4e464f", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "Lista de Usuarios";

#line default
#line hidden
            BeginContext(105, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(110, 21, false);
#line 7 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
Write(TempData["menssagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(131, 262, true);
            WriteLiteral(@"</h2>
<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Email</th>
            <th>Senha</th>
            <th>Data de Nascimento</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
     foreach(var item in ViewData["usuarios"] as List<UsuarioModel>)
    {

#line default
#line hidden
            BeginContext(470, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(493, 7, false);
#line 23 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(500, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(520, 9, false);
#line 24 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
       Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(529, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(549, 10, false);
#line 25 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(559, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(579, 10, false);
#line 26 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
       Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(589, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(609, 39, false);
#line 27 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
       Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(648, 35, true);
            WriteLiteral("</td>\r\n        <td>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 683, "\"", 717, 2);
            WriteAttributeValue("", 690, "/Usuario/Editar?id=", 690, 19, true);
#line 29 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 709, item.Id, 709, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(718, 27, true);
            WriteLiteral(">Editar</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 745, "\"", 780, 2);
            WriteAttributeValue("", 752, "/Usuario/Excluir?id=", 752, 20, true);
#line 30 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 772, item.Id, 772, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(781, 42, true);
            WriteLiteral(">Excluir</a>\r\n\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 34 "C:\Users\38850490828\Documents\Aulas C#\MVC\WebMVCEx2\Views\Usuario\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(830, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591