#pragma checksum "D:\项目\A学习\JsonOnline\JsonOnline\JsonOnline\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1609bdc357a53349e16bb8027b3519193c1828f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1609bdc357a53349e16bb8027b3519193c1828f5", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("overflow:hidden;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zh-CN\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1609bdc357a53349e16bb8027b3519193c1828f53085", async() => {
                WriteLiteral(@"
    <title>JsonOnline</title>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta http-equiv=""Cache-Control"" content=""max-age=7200"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link");
                BeginWriteAttribute("href", " href=\"", 360, "\"", 409, 1);
#nullable restore
#line 9 "D:\项目\A学习\JsonOnline\JsonOnline\JsonOnline\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 367, Href("~/lib/bootstrap/bootstrap.min.css"), 367, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 439, "\"", 481, 1);
#nullable restore
#line 10 "D:\项目\A学习\JsonOnline\JsonOnline\JsonOnline\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 446, Href("~/css/font-awesome.min.css"), 446, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 511, "\"", 541, 1);
#nullable restore
#line 11 "D:\项目\A学习\JsonOnline\JsonOnline\JsonOnline\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 518, Href("~/css/base.css"), 518, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 571, "\"", 637, 1);
#nullable restore
#line 12 "D:\项目\A学习\JsonOnline\JsonOnline\JsonOnline\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 578, Href("~/lib/numberedtextarea/jquery.numberedtextarea.css"), 578, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <style></style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1609bdc357a53349e16bb8027b3519193c1828f56084", async() => {
                WriteLiteral(@"
<header class=""header"">
    <div class=""row-fluid"" >
        <div class=""col-md-5"" style=""position:relative;"">
            <a class=""logo"">Json<span style=""color:#555;"">Online</span></a>

        </div>
        <nav class=""col-md-7"" style=""padding:10px 0;""  align=""right"">
            <div  class=""navi"">
            	 <a href=""#"" data-placement=""bottom"" target=""_blank"">我的博客</a>
                <a href=""index.html"" data-placement=""bottom"">在线解析</a>
                <a href=""wiki.html""  data-placement=""bottom"">什么是Json</a>
                <a href=""code.html""  data-placement=""bottom"">Json解析代码</a>
                <a href=""component.html""  data-placement=""bottom"">Json组件</a>
            </div>
        </nav>
        <br style=""clear:both;"" />
    </div>
</header>
<main class=""row-fluid"" style=""height:85%;min-height:550px;"">
    <div class=""col-md-5"" style=""padding:0px;height:100%;"">
        <textarea id=""json-src"" placeholder=""在此输入json字符串或XML字符串...""   class=""form-control""  
        style=""height:");
                WriteLiteral(@"722px;padding:0 10px 10px 20px;border:0;border-right:solid 1px #ddd;border-bottom:solid 1px #ddd;
border-radius:0;resize: none; outline:none;"">
        {&#13""Json解析"":""支持格式化高亮折叠"",&#13""支持XML转换"":""支持XML转换Json,Json转XML"",&#13""Json格式验证"":""更详细准确的错误信息""}
    </textarea>
    </div>
    <div class=""col-md-7"" style=""padding:0;"">
        <div style=""padding:10px;font-size:16px;border-bottom:solid 1px #ddd;"" class=""navi"">
            <a href=""#"" class=""tip zip"" title=""压缩""  data-placement=""bottom""><i class=""fa fa-database""></i></a>
						<a href=""#"" class=""tip xml"" title=""转XML""  data-placement=""bottom""><i class=""fa fa-file-excel-o""></i></a>
            <a href=""#"" class=""tip shown""  title=""显示行号""  data-placement=""bottom""><i class=""glyphicon glyphicon-sort-by-order""></i></a>
            <a href=""#"" class=""tip clear"" title=""清空""  data-placement=""bottom""><i class=""fa fa-trash""></i></a>
            <a href=""#"" class=""tip save"" title=""保存""  data-placement=""bottom""><i class=""fa fa-download""></i></a>
            <a href=""#""");
                WriteLiteral(@" class=""tip copy"" title=""复制"" data-clipboard-target=""#json-target""  data-placement=""bottom""><i class=""fa fa-copy""></i></a>
            <a href=""#"" class=""tip compress"" title=""折叠""  data-placement=""bottom""><i class=""fa fa-compress""></i></a>
        </div>
        <div id=""right-box""  style=""height:679px;border-right:solid 1px #ddd;border-bottom:solid 1px #ddd;border-radius:0;resize: none;
overflow-y:scroll; outline:none;position:relative;"">
            <div id=""line-num"" style=""background-color:#fafafa;padding:0px 8px;float:left;border-right:dashed 1px #eee;display:none;
z-index:-1;color:#999;position:absolute;text-align:center;overflow:hidden;"">
            <div>0</div>
            </div>
            <div class=""ro"" id=""json-target"" style=""padding:0px 25px;"">
            </div>
        </div>
        <form id=""form-save"" method=""POST""><input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3644, "\"", 3652, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"txt-content\" name=\"content\"></form>\r\n    </div>\r\n    <br style=\"clear:both;\" />\r\n</main>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n     ");
#nullable restore
#line 68 "D:\项目\A学习\JsonOnline\JsonOnline\JsonOnline\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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