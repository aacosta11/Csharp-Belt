#pragma checksum "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4d0b685618b21c713a3b95c3809a491d2c49715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Csharp_Belt.Models.ActivityModel.Views_ActivityModel_ActivityView), @"mvc.1.0.view", @"/Views/ActivityModel/ActivityView.cshtml")]
namespace Csharp_Belt.Models.ActivityModel
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d0b685618b21c713a3b95c3809a491d2c49715", @"/Views/ActivityModel/ActivityView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9f9aa4cf5346e53c129da2d4346e04c25ac705", @"/Views/_ViewImports.cshtml")]
    public class Views_ActivityModel_ActivityView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "HomeNavPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
  Layout="_MetaLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4d0b685618b21c713a3b95c3809a491d2c497153287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div style=\"padding: 2rem;\" class=\"g G1col RG1\">\r\n    <div class=\"Wmost x JCspace-between\">\r\n        <h1>");
#nullable restore
#line 8 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
       Write(Model.ActivityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
             if (Model.UserId == Model.TempUserId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 302, "\"", 362, 4);
            WriteAttributeValue("", 309, "/home/", 309, 6, true);
#nullable restore
#line 11 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
WriteAttributeValue("", 315, Model.UserId, 315, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 328, "/delete-activity/", 328, 17, true);
#nullable restore
#line 11 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
WriteAttributeValue("", 345, Model.ActivityId, 345, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">delete</a></td>\r\n");
#nullable restore
#line 12 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
            } else if (Model.ActivityParticipants.Any(dis => dis.UserId == Model.TempUserId&&dis.ActivityId==Model.ActivityId)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 597, 4);
            WriteAttributeValue("", 541, "/home/", 541, 6, true);
#nullable restore
#line 13 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
WriteAttributeValue("", 547, Model.UserId, 547, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 560, "/un-add-participant/", 560, 20, true);
#nullable restore
#line 13 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
WriteAttributeValue("", 580, Model.ActivityId, 580, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">un-add</a></td>\r\n");
#nullable restore
#line 14 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 660, "\"", 720, 4);
            WriteAttributeValue("", 667, "/home/", 667, 6, true);
#nullable restore
#line 15 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
WriteAttributeValue("", 673, Model.UserId, 673, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 686, "/add-participant/", 686, 17, true);
#nullable restore
#line 15 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
WriteAttributeValue("", 703, Model.ActivityId, 703, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">add</a></td>\r\n");
#nullable restore
#line 16 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <h3>Event Coordinator: ");
#nullable restore
#line 19 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
                      Write(Model.ActivityOwner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div style=\"padding-left: 2rem;\" class=\"g G1col RG2\">\r\n        <div>\r\n            <h3>Description: </h3>\r\n            <p>");
#nullable restore
#line 23 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"g G1col RG1\">\r\n            <h3>Participants</h3>\r\n            <ul style=\"padding-left: 3rem;\">\r\n");
#nullable restore
#line 28 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
                 foreach(Participant prt in Model.ActivityParticipants)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 30 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
                   Write(prt.UserAsParticipant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "C:\Users\acost\Desktop\Csharp-Belt\Views\ActivityModel\ActivityView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activity> Html { get; private set; }
    }
}
#pragma warning restore 1591