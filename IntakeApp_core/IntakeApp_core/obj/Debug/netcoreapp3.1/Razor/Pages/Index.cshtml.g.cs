#pragma checksum "C:\Users\Judith\source\repos\IntakeApp_core\IntakeApp_core\IntakeApp_core\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a87a289ac69839e58cf25af27bc0327d6a3fa17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace CoreApp.Pages
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
#line 1 "C:\Users\Judith\source\repos\IntakeApp_core\IntakeApp_core\IntakeApp_core\Pages\_ViewImports.cshtml"
using CoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Judith\source\repos\IntakeApp_core\IntakeApp_core\IntakeApp_core\Pages\Index.cshtml"
using IntakeApp_core.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a87a289ac69839e58cf25af27bc0327d6a3fa17", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78871ccd4ab14b0fa46ade7d908ac9dcad1a76e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ID", new global::Microsoft.AspNetCore.Html.HtmlString("btnAddProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("CssClass", new global::Microsoft.AspNetCore.Html.HtmlString("auto-style15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Judith\source\repos\IntakeApp_core\IntakeApp_core\IntakeApp_core\Pages\Index.cshtml"
  
	ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<title>Intake producten.</title>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a87a289ac69839e58cf25af27bc0327d6a3fa175702", async() => {
                WriteLiteral(@"
	<script src=""//code.jquery.com/jquery-1.11.2.min.js"" type=""text/javascript""></script>
	<script type=""text/javascript"">
        function ShowImagePreview(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=ImgPrv.ClientID%>').prop('src', e.target.result)
                        .width(240)
                        .height(150);
                };
                reader.readAsDataURL(input.files[0]);
                }
            }
	</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a87a289ac69839e58cf25af27bc0327d6a3fa177342", async() => {
                WriteLiteral(@"
	<style type=""text/css"">
		.auto-style2 {
			width: 254px;
			font-family: Arial, Helvetica, sans-serif;
		}

		.auto-style3 {
			width: 255px;
			font-family: Arial, Helvetica, sans-serif;
		}

		.auto-style12 {
			height: 26px;
		}

		.auto-style14 {
			width: 216px;
			height: 26px;
			font-family: Arial, Helvetica, sans-serif;
		}

		.auto-style15 {
			font-family: Arial, Helvetica, sans-serif;
		}

		.auto-style16 {
			width: 216px;
			font-family: Arial, Helvetica, sans-serif;
		}

		.auto-style17 {
			width: 100%;
		}

		.auto-style18 {
			width: 1551px;
			height: 170px;
		}

		.auto-style19 {
			height: 1080px;
			margin-left: 0px;
		}

		.auto-style20 {
			margin-left: 1360px;
			width: 191px;
			height: 94px;
		}

		.auto-style21 {
			width: 36%;
			position: absolute;
			left: -88px;
			top: 142px;
			font-family: Arial, Helvetica, sans-serif;
			margin-left: 1188px;
		}

		.auto-style22 {
			width: 255px;
			font-family: Arial, Helvet");
                WriteLiteral(@"ica, sans-serif;
			height: 26px;
		}

		.auto-style25 {
			width: 254px;
			font-family: Arial, Helvetica, sans-serif;
			height: 26px;
		}

		.auto-style26 {
			width: 504px;
		}

		.auto-style27 {
			width: 2265px;
		}

		.auto-style28 {
			width: 249px;
		}

		.auto-style29 {
			margin-left: 1360px;
			width: 191px;
			height: 51px;
		}

		.auto-style30 {
			width: 223px;
		}
	</style>
	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a87a289ac69839e58cf25af27bc0327d6a3fa179085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</html>
<div class=""auto-style19"" style=""background-image: url('Images/Background intake.png')"">
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<br />
	<br /> <!-- ergens een optie geven om een compleet nieuw product toe te voegen -->
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<br />
	<br />
	<br />


	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Image ID=""Image1"" runat=""server"" Height=""273px"" Width=""293px"" ImageUrl=""~/Images/Ruiolwinkel Vaals Logo.png"" ImageAlign=""AbsMiddle"" />
	<br />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&");
            WriteLiteral(@"nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<table class=""auto-style21"">
		<tr>
			<td class=""auto-style27"">Add Image</td>
			<td class=""auto-style26""> <input id=""articleImage0"" runat=""server"" type=""file"" class=""auto-style15"" onchange=""ShowImagePreview(this);"" /></td>
			<td>
				<asp:Image ID=""ImgPrv"" Height=""290px"" Width=""318px"" runat=""server"" />
		</tr>
		<tr>
			<td class=""auto-style27"">&nbsp;</td>
			<td class=""auto-style26"">&nbsp;</td>
			<td>&nbsp;</td>
		</tr>
		<tr>
			<td class=""auto-style27"">&nbsp;</td>
			<td class=""auto-style26"">&nbsp;</td>
			<td>&nbsp;</td>
		</tr>
	</table>
	<br />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<span class=""auto-style15"">
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp");
            WriteLiteral(@";&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<br />
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User
	</span>
	<asp:DropDownList ID=""userChooser"" runat=""server"" CssClass=""auto-style15"" DataSourceID=""SqlDataSource5"" DataTextField=""FirstName"" DataValueField=""UserID"">
	</asp:DropDownList>
	<br />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

	<!-- het uitkiezen voor welke user het toegevoegd moet worden -->
");
            WriteLiteral(@"	&nbsp;<br />
	<br />
	<table style=""width:100%;"" class=""auto-style15"">
		<tr>
			<td class=""auto-style22""></td>
			<td class=""auto-style14"">Category</td>
			<td class=""auto-style12"">
				<asp:DropDownList ID=""categoryChooser"" runat=""server"" DataSourceID=""SqlDataSource2"" DataTextField=""CategoryName"" DataValueField=""CategoryID"" CssClass=""auto-style15""></asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td class=""auto-style3"">&nbsp;</td>
			<td class=""auto-style16"">Product </td>
			<td>
				<asp:DropDownList ID=""productChooser"" runat=""server"" DataSourceID=""SqlDataSource4"" DataTextField=""ProductName"" DataValueField=""ProductID"" CssClass=""auto-style15""></asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td class=""auto-style3"">&nbsp;</td>
			<td class=""auto-style16"">Description </td>
			<td> <input id=""productDescription"" type=""text"" class=""auto-style15"" /></td>
		</tr>
	</table>
	<table class=""auto-style17"">
		<tr>
			<td class=""auto-style2"">&nbsp;</td>
			<td class=""auto-style16"">Status <!-- mis");
            WriteLiteral(@"schien automatiseren --></td>
			<td>
				<asp:DropDownList ID=""statusChooser"" runat=""server"" DataSourceID=""SqlDataSource3"" DataTextField=""StatusName"" DataValueField=""StatusID"" CssClass=""auto-style15"" OnSelectedIndexChanged=""statusChooser_SelectedIndexChanged""></asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td class=""auto-style25""></td>
			<td class=""auto-style14"">Commentary </td>
			<td class=""auto-style12""> <input id=""commentary"" runat=""server"" type=""text"" class=""auto-style15"" /></td>
		</tr>
	</table>
	<p class=""auto-style29"">
		<br />
		<asp:Button ID=""btnAddArticle0"" runat=""server"" Text=""Voeg artikel toe"" OnClick=""inputButton_Clicked"" CssClass=""auto-style15"" />
		<%--     &nbsp;<asp:Button ID=""btnAddProduct"" runat=""server"" Text=""Submit"" OnClick=""addProductBtn_Clicked"" CssClass=""auto-style15"" />--%>
	</p>
	<table class=""auto-style15"" style=""width:100%;"">
		<tr>
			<td class=""auto-style28"">&nbsp;</td>
			<td class=""auto-style30"">Product name</td>
			<td>
				<input id=""productName"" run");
            WriteLiteral(@"at=""server"" type=""text"" />
			</td>
		</tr>
		<tr>
			<td class=""auto-style28"">&nbsp;</td>
			<td class=""auto-style30"">Category</td>
			<td>
				<asp:DropDownList ID=""categoryChooser0"" runat=""server"" DataSourceID=""SqlDataSource2"" DataTextField=""CategoryName"" DataValueField=""CategoryID"" CssClass=""auto-style15""></asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td class=""auto-style28"">&nbsp;</td>
			<td class=""auto-style30"">Product Description</td>
			<td>
				<input id=""productDescriptionNA"" runat=""server"" type=""text"" />
			</td>
		</tr>
	</table>
	<div id=""addNewProduct"" class=""auto-style18"" draggable=""true"">
		<p class=""auto-style20"">
			<br />
			<%--     &nbsp;");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a87a289ac69839e58cf25af27bc0327d6a3fa1717355", async() => {
                WriteLiteral("Add Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
			<asp:Button ID=""btnAddProduct"" runat=""server"" Text=""Submit"" OnClick=""addProductBtn_Clicked"" CssClass=""auto-style15"" />--%>
			<br />
			&nbsp;<asp:Button ID=""btnAddProduct"" runat=""server"" CssClass=""auto-style15"" OnClick=""addProductBtn_Clicked"" Text=""Add Product"" />
		</p>
		<asp:SqlDataSource ID=""SqlDataSource1"" runat=""server""></asp:SqlDataSource>
		<asp:SqlDataSource ID=""SqlDataSource2"" runat=""server"" ConnectionString=""<%$ ConnectionStrings:RuilwinkelDBConnectionString %>"" SelectCommand=""SELECT * FROM [Categories]""></asp:SqlDataSource>
		<asp:SqlDataSource ID=""SqlDataSource3"" runat=""server"" ConnectionString=""<%$ ConnectionStrings:RuilwinkelDBConnectionString %>"" SelectCommand=""SELECT * FROM [Statusses]""></asp:SqlDataSource>
		<asp:SqlDataSource ID=""SqlDataSource4"" runat=""server"" ConnectionString=""<%$ ConnectionStrings:RuilwinkelDBConnectionString %>"" SelectCommand=""SELECT * FROM [Products]""></asp:SqlDataSource>
		<asp:SqlDataSource ID=""SqlDataSource5"" runat=""server"" ConnectionString=""<%$ Connect");
            WriteLiteral("ionStrings:RuilwinkelDBConnectionString %>\" SelectCommand=\"SELECT * FROM [Users]\"></asp:SqlDataSource>\r\n\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
