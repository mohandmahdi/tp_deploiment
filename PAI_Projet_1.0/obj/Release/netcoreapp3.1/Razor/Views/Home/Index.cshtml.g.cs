#pragma checksum "C:\Users\tarik_saibi\Desktop\PAI_Projet_1.0\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59320b60e323ccdb26d9e07ffddb398e25bdce49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tarik_saibi\Desktop\PAI_Projet_1.0\Views\_ViewImports.cshtml"
using PAI_Projet_1._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tarik_saibi\Desktop\PAI_Projet_1.0\Views\_ViewImports.cshtml"
using PAI_Projet_1._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59320b60e323ccdb26d9e07ffddb398e25bdce49", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b077bf855acd41f9b5116c6259e87349e636bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59320b60e323ccdb26d9e07ffddb398e25bdce493541", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""icon"" href=""../images/favicon.ico"" type=""image/ico"" />

    <title>Handrails Management </title>

    <!-- Bootstrap -->
    <link href=""../vendors/bootstrap/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Font Awesome -->
    <link href=""../vendors/font-awesome/css/font-awesome.min.css"" rel=""stylesheet"">
    <!-- NProgress -->
    <link href=""../js/nprogress.css"" rel=""stylesheet"">
    <!-- iCheck -->
    <link href=""../vendors/iCheck/skins/flat/green.css"" rel=""stylesheet"">

    <!-- bootstrap-progressbar -->
    <link href=""../vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css"" rel=""stylesheet"">
    <!-- JQVMap -->
    <link href=""../vendors/jqvmap/dist/jqvmap.min.css"" rel=""");
                WriteLiteral("stylesheet\" />\r\n    <!-- bootstrap-daterangepicker -->\r\n    <link href=\"../vendors/bootstrap-daterangepicker/daterangepicker.css\" rel=\"stylesheet\">\r\n\r\n    <!-- Custom Theme Style -->\r\n    <link href=\"../css/custom.min.css\" rel=\"stylesheet\">\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59320b60e323ccdb26d9e07ffddb398e25bdce495873", async() => {
                WriteLiteral(@"
    <div class=""container body"">
        <div class=""main_container"">
            <div class=""col-md-3 left_col"">
                <div class=""left_col scroll-view"">
                    <div class=""navbar nav_title"" style=""border: 0;"">
                        <a href=""index.html"" class=""site_title""><i class=""fa fa-institution""></i><span>Handrails</span></a>
                    </div>

                    <div class=""clearfix""></div>

                    <!-- menu profile quick info -->
                    <div class=""profile clearfix"">
                        <div class=""profile_pic"">
                            <img src=""../images/img.jpg"" alt=""..."" class=""img-circle profile_img"">
                        </div>
                        <div class=""profile_info"">
                            <span>Welcome,</span>
                            <h2>John </h2>
                        </div>
                    </div>
                    <!-- /menu profile quick info -->

                    <b");
                WriteLiteral(@"r />

                    <!-- sidebar menu -->
                    <div id=""sidebar-menu"" class=""main_menu_side hidden-print main_menu"">
                        <div class=""menu_section"">
                            <h3>General</h3>
                            <ul class=""nav side-menu"">
                                <li>
                                    <a href=""index.html""><i class=""fa fa-home""></i> Home  </a>
                                </li>
                                <li>
                                    <a><i class=""fa fa-qq""></i> Client </a>
                                </li>

                                <li>
                                    <a><i class=""fa fa-user""></i> Security agent</a>
                                </li>

                                <li>
                                    <a><i class=""fa fa-table""></i> Planification </a>
                                </li>


                                <li>
                            ");
                WriteLiteral(@"        <a><i class=""fa fa-desktop""></i> Services </a>
                                </li>

                                <li>
                                    <a><i class=""fa fa-book""></i> Handrails </a>
                                </li>

                                <li>
                                    <a><i class=""fa fa-warning""></i>Incidents</a>
                                </li>
                            </ul>
                        </div>


                    </div>
                    <!-- /sidebar menu -->
                    <!-- /menu footer buttons -->
                    <div class=""sidebar-footer hidden-small"">
                        <a data-toggle=""tooltip"" data-placement=""top"" title=""Logout"" href=""login.html"">
                            <span class=""glyphicon glyphicon-off"" aria-hidden=""true""></span>
                        </a>
                    </div>
                    <!-- /menu footer buttons -->
                </div>
            </div");
                WriteLiteral(@">

            <!-- top navigation -->
            <div class=""top_nav"">
                <div class=""nav_menu"">
                    <div class=""nav toggle"">
                        <a id=""menu_toggle""><i class=""fa fa-bars""></i></a>
                    </div>
                    <nav class=""nav navbar-nav"">
                        <ul class="" navbar-right"">
                            <li class=""nav-item dropdown open"" style=""padding-left: 15px;"">
                                <a href=""javascript:;"" class=""user-profile dropdown-toggle"" aria-haspopup=""true"" id=""navbarDropdown"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    <img src=""../images/img.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5090, "\"", 5096, 0);
                EndWriteAttribute();
                WriteLiteral(@">John Doe
                                </a>
                                <div class=""dropdown-menu dropdown-usermenu pull-right"" aria-labelledby=""navbarDropdown"">
                                    <a class=""dropdown-item"" href=""javascript:;""> Profile</a>

                                    <a class=""dropdown-item"" href=""login.html""><i class=""fa fa-sign-out pull-right""></i> Log Out</a>
                                </div>
                            </li>

                            <li role=""presentation"" class=""nav-item dropdown open"">
                                <a href=""javascript:;"" class=""dropdown-toggle info-number"" id=""navbarDropdown1"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    <i class=""fa fa-envelope-o""></i>
                                    <span class=""badge bg-green"">6</span>
                                </a>
                                <ul class=""dropdown-menu list-unstyled msg_list"" role=""menu"" aria-labelledby=""navbarD");
                WriteLiteral(@"ropdown1"">
                                    <li class=""nav-item"">
                                        <a class=""dropdown-item"">
                                            <span class=""image""><img src=""../images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                                                <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                            </span>
                                            <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                            </span>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""dropdown-item"">
                                ");
                WriteLiteral(@"            <span class=""image""><img src=""../images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                                                <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                            </span>
                                            <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                            </span>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""dropdown-item"">
                                            <span class=""image""><img src=""../images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                          ");
                WriteLiteral(@"                      <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                            </span>
                                            <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                            </span>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""dropdown-item"">
                                            <span class=""image""><img src=""../images/img.jpg"" alt=""Profile Image"" /></span>
                                            <span>
                                                <span>John Smith</span>
                                                <span class=""time"">3 mins ago</span>
                                     ");
                WriteLiteral(@"       </span>
                                            <span class=""message"">
                                                Film festivals used to be do-or-die moments for movie makers. They were where...
                                            </span>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <div class=""text-center"">
                                            <a class=""dropdown-item"">
                                                <strong>See All Alerts</strong>
                                                <i class=""fa fa-angle-right""></i>
                                            </a>
                                        </div>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </nav>
                </div>
         ");
                WriteLiteral(@"   </div>
            <!-- /top navigation -->
            <div class=""right_col"" role=""main"">


                <div class=""tile_count"">

                    <div class=""col-md-2 col-sm-4  tile_stats_count"">
                        <span class=""count_top""><i class=""fa fa-user""></i> Total Agents</span>
                        <div class=""count"">250</div>
                    </div>

                    <div class=""col-md-2 col-sm-4  tile_stats_count"">
                        <span class=""count_top""><i class=""fa fa-user""></i> CQP  Agent</span>
                        <div class=""count"">120</div>

                    </div>

                    <div class=""col-md-2 col-sm-4  tile_stats_count"">
                        <span class=""count_top""><i class=""fa fa-user""></i> SSIAP Agent</span>
                        <div class=""count "">100</div>
                    </div>

                    <div class=""col-md-2 col-sm-4  tile_stats_count"">
                        <span class=""count_top""><i cla");
                WriteLiteral(@"ss=""fa fa-user""></i> dog officer</span>
                        <div class=""count"">30</div>
                    </div>

                    <div class=""col-md-2 col-sm-4  tile_stats_count"">
                        <span class=""count_top""><i class=""fa fa-user""></i> Free Agent</span>
                        <div class=""count"">30</div>
                    </div>

                </div>

                <div>

                </div>

            </div>




            <!-- footer content -->
          
            <!-- /footer content -->
            <!-- jQuery -->
            <script src=""../vendors/jquery/dist/jquery.min.js""></script>
            <!-- Bootstrap -->
            <script src=""../vendors/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
            <!-- FastClick -->
            <script src=""../vendors/fastclick/lib/fastclick.js""></script>
            <!-- NProgress -->
            <script src=""../vendors/nprogress/nprogress.js""></script>
            <!-- Chart.js");
                WriteLiteral(@" -->
            <script src=""../vendors/Chart.js/dist/Chart.min.js""></script>
            <!-- gauge.js -->
            <script src=""../vendors/gauge.js/dist/gauge.min.js""></script>
            <!-- bootstrap-progressbar -->
            <script src=""../vendors/bootstrap-progressbar/bootstrap-progressbar.min.js""></script>
            <!-- iCheck -->
            <script src=""../vendors/iCheck/icheck.min.js""></script>
            <!-- Skycons -->
            <script src=""../js/skycons.js""></script>
            <!-- Flot -->
            <script src=""../vendors/Flot/jquery.flot.js""></script>
            <script src=""../vendors/Flot/jquery.flot.pie.js""></script>
            <script src=""../vendors/Flot/jquery.flot.time.js""></script>
            <script src=""../vendors/Flot/jquery.flot.stack.js""></script>
            <script src=""../vendors/Flot/jquery.flot.resize.js""></script>
            <!-- Flot plugins -->
            <script src=""../vendors/flot.orderbars/js/jquery.flot.orderBars.js""></script");
                WriteLiteral(@">
            <script src=""../vendors/flot-spline/js/jquery.flot.spline.min.js""></script>
            <script src=""../vendors/flot.curvedlines/curvedLines.js""></script>
            <!-- DateJS -->
            <script src=""../vendors/DateJS/build/date.js""></script>
            <!-- JQVMap -->
            <script src=""../vendors/jqvmap/dist/jquery.vmap.js""></script>
            <script src=""../vendors/jqvmap/dist/maps/jquery.vmap.world.js""></script>
            <script src=""../vendors/jqvmap/examples/js/jquery.vmap.sampledata.js""></script>
            <!-- bootstrap-daterangepicker -->
            <script src=""../js/moment.min.js""></script>
            <script src=""../vendors/bootstrap-daterangepicker/daterangepicker.js""></script>

            <!-- Custom Theme Scripts -->
            <script src=""../build/js/custom.min.js""></script>
            </div>
        </div>

");
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