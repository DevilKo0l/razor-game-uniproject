#pragma checksum "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57190d227087663c57720548b9c0fcb825310728"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Rabbits and Carrots</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " and current radio ");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                                   theRadio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<hr>\r\n");
#nullable restore
#line 6 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
  
    if(currentCount==0){   
       
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "environment");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 13 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
     for(var i=0; i<@e.total_of_rows(); i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 16 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
             for(var j=0; j<@e.total_of_cols(); j++){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                 if(e.bioUnit(i,j)!=null) {                   

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "                    <td class=\"cell alive\"></td>\r\n");
#nullable restore
#line 19 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                   
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "                    <td class=\"cell dead\"></td>\r\n");
#nullable restore
#line 24 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                 
                
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 28 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<hr>\r\n");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "radio");
            __builder.AddAttribute(23, "name", "myradiobtn");
            __builder.AddAttribute(24, "checked", 
#nullable restore
#line 33 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                       theRadio.Equals("step")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "value", "step");
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                       ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(27, " Step by step\r\n    ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "radio");
            __builder.AddAttribute(30, "name", "myradiobtn");
            __builder.AddAttribute(31, "checked", 
#nullable restore
#line 37 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                       theRadio.Equals("many")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "value", "many");
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                       ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(34, " Several step\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, " \r\n\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "display:" + " " + (
#nullable restore
#line 42 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                       theRadio.Equals("many")?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.AddMarkupContent(39, "<h5>Cycles specification</h5>\r\n    Number of cycles:\r\n    ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                  cyclesPerTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cyclesPerTime = __value, cyclesPerTime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(43, " (internal value: ");
            __builder.AddContent(44, 
#nullable restore
#line 45 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                                      cyclesPerTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, ") \r\n    <br>   \r\n    ");
            __builder.AddMarkupContent(46, "<button class=\"btn btn-primary\">Play</button>    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-info");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                       c => this.isCollapsed = !this.isCollapsed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.AddContent(52, 
#nullable restore
#line 54 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
       this.isCollapsed ? "Add Pattern (+)" : "Add Pattern (-)"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n<br>\r\n");
#nullable restore
#line 57 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
 if(!isCollapsed)
{ 

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "radio");
            __builder.AddAttribute(58, "name", "myradiobtn");
            __builder.AddAttribute(59, "value", "blinker");
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                                                        () => patternName = "blinker"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.AddMarkupContent(62, "<label for=\"blinker\">Blinker</label><br>\r\n    ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "radio");
            __builder.AddAttribute(65, "name", "myradiobtn");
            __builder.AddAttribute(66, "value", "toad");
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                                                    () => patternName = "toad"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.AddMarkupContent(69, "<label for=\"toad\">Toad</label><br>\r\n    ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "radio");
            __builder.AddAttribute(72, "name", "myradiobtn");
            __builder.AddAttribute(73, "value", "pentadecathlon");
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                                                               () => patternName = "pentadecathlon"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.AddMarkupContent(76, "<label for=\"pentadecathlon\">Pentadecathlon</label>\r\n");
#nullable restore
#line 65 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
}  

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(77, "\r\n<br>\r\n");
            __builder.OpenElement(78, "div");
            __builder.AddMarkupContent(79, "    \r\n    row\r\n    ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "style", "width: 100px;");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                        row

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => row = __value, row));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "  \r\n    col\r\n    ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "style", "width: 100px;");
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                       col

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => col = __value, col));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "   \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, " \r\n<br>\r\n");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "btn btn-success");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                          AddPatern

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n<hr>\r\n\r\n\r\n");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "class", "btn btn-info");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                       c => this.isCollapsed = !this.isCollapsed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.AddContent(100, 
#nullable restore
#line 81 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
       this.isCollapsed ? "Add Cell (+)" : "Add Cell (-)"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n");
#nullable restore
#line 84 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
 if(!isCollapsed)
{ 

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "    ");
            __builder.OpenElement(104, "div");
            __builder.AddMarkupContent(105, "  \r\n\r\n        ");
            __builder.OpenElement(106, "textarea");
            __builder.AddAttribute(107, "name", "");
            __builder.AddAttribute(108, "id", "");
            __builder.AddAttribute(109, "cols", "6");
            __builder.AddAttribute(110, "rows", "3");
            __builder.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                                         getTextArea

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => getTextArea = __value, getTextArea));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(113, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 92 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"

    
}  

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(116, "<br>\r\n");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "btn btn-success");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                          AddCell

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(120, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n\r\n<hr>\r\n");
            __builder.OpenElement(122, "button");
            __builder.AddAttribute(123, "class", "btn btn-primary");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(125, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
            __builder.AddMarkupContent(127, "<a class=\"btn btn-primary\" href=\"https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life\" target=\"_blank\">\r\n    Look for Patterns in wikipedi\r\n</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
           
    private bool isCollapsed = true; 
    private int cyclesPerTime = 0;
    private string patternName = "";
    public int row =0;
    public int col =0;
    public string getTextArea{get;set;} = string.Empty;
    private int[] positionInput()
    {
        
        string[] values = getTextArea.Split(new[] {',','\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[6];
        int i = 0;       
        foreach(var value in values)
        {
            int number;
            bool success = int.TryParse(value,out number);
            if(success)
            {
                nums[i]=number;
                i++;                
            }
        }
        
        return nums; 
    }

    private int currentCount = 0;
    private string theRadio="";
    private Data.Environment e = new Data.Environment(30,30);  
     
    private void AddCell()
    {
        int[] position = positionInput();
        for(int i = 0; i<6 ; i++)
        {
            if(i%2==0)
            {
                e.insert(position[i],position[i+1], new Data.BioUnit(position[i],position[i+1], e));
            }
        }
    } 
    
    private void AddPatern()
    {
        e.put_pattern(row,col,patternName);
    }
   
    private void IncrementCount()
    {
        currentCount++;
        e.nextConwayStep(); 
    }
    
    private void ClickRadio(ChangeEventArgs args)
    {
        theRadio = args.Value.ToString();
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
