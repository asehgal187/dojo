#pragma checksum "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c781ebb587de5766c6a3384d06468f4ad1e26e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c781ebb587de5766c6a3384d06468f4ad1e26e", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19, true);
            WriteLiteral("<h1>Home</h1>\r\n\r\n\r\n");
            EndContext();
#line 4 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
  
    bool isAttending = false;

#line default
#line hidden
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 242, true);
            WriteLiteral("    <table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Activity</th>\r\n        <th>Date & Time</th>\r\n        <th>Duration</th>\r\n        <th>Coordinator</th>\r\n        <th># of Participants</th>\r\n        <th>Action</th>\r\n    </tr>\r\n   \r\n");
            EndContext();
#line 19 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
     foreach(var i in ViewBag.AllAct)
    {

#line default
#line hidden
            BeginContext(351, 20, true);
            WriteLiteral("    <tr>\r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 371, "\"", 403, 2);
            WriteAttributeValue("", 378, "/actividad/", 378, 11, true);
#line 22 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 389, i.ActividadId, 389, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(404, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(406, 6, false);
#line 22 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
                                       Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(412, 19, true);
            WriteLiteral("</a></td>\r\n    <td>");
            EndContext();
            BeginContext(432, 33, false);
#line 23 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
   Write(i.Date.ToString("MMMM, dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(465, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(470, 6, false);
#line 23 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
                                         Write(i.Time);

#line default
#line hidden
            EndContext();
            BeginContext(476, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(492, 10, false);
#line 24 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
   Write(i.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(502, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(518, 14, false);
#line 25 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
   Write(i.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(532, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(548, 14, false);
#line 26 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
   Write(i.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(562, 17, true);
            WriteLiteral("</td>\r\n    <td>\r\n");
            EndContext();
#line 28 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
         if(ViewBag.CurrentUser.UserId == i.Creator.UserId)
        {

#line default
#line hidden
            BeginContext(651, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 661, "\"", 690, 2);
            WriteAttributeValue("", 668, "/delete/", 668, 8, true);
#line 30 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 676, i.ActividadId, 676, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(691, 14, true);
            WriteLiteral(">Delete</a> \r\n");
            EndContext();
#line 31 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
        }

        else
        {
            
        
            foreach(var x in i.Guests)
            {
                if(x.UserId == ViewBag.CurrentUser.UserId)
                {
                    isAttending = true;
                }
              
            }
              if(isAttending == true)
                {

#line default
#line hidden
            BeginContext(1050, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1072, "\"", 1100, 2);
            WriteAttributeValue("", 1079, "/leave/", 1079, 7, true);
#line 47 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1086, i.ActividadId, 1086, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1101, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 48 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
                    isAttending = false;  
                }

                else if(isAttending == false)
                {

#line default
#line hidden
            BeginContext(1244, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1293, 2);
            WriteAttributeValue("", 1273, "/join/", 1273, 6, true);
#line 53 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1279, i.ActividadId, 1279, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1294, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 54 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
                }
        }

#line default
#line hidden
            BeginContext(1335, 32, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    </td>\r\n    </tr>\r\n");
            EndContext();
#line 63 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
    }

#line default
#line hidden
            BeginContext(1374, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
            BeginContext(1393, 2, true);
            WriteLiteral("<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1395, "\"", 1434, 2);
            WriteAttributeValue("", 1402, "/new/", 1402, 5, true);
#line 67 "/Users/arjunsehgal/Documents/c#/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1407, ViewBag.CurrentUser.UserId, 1407, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1435, 38, true);
            WriteLiteral("><button>Plan an Activity</button></a>");
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
