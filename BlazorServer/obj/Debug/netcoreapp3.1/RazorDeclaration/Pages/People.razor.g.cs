// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\Pages\People.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\Pages\People.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\Pages\People.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Bas\Documents\GitHub\ConnectingToMySQL\BlazorServer\Pages\People.razor"
       
    List<PersonModel> people;

    private async Task InsertData()
    {
        string sql = "insert into people (Firstname, Lastname) values (@FirstName, @LastName);";

        await _data.SaveData(sql, new { FirstName = "Henk", LastName = "Jansen" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task UpdateData()
    {
        string sql = "update people set Firstname = @FirstName where LastName = @LastName";

        await _data.SaveData(sql, new { FirstName = "Bob", LastName = "Melis" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task DeleteData()
    {
        string sql = "delete from people where LastName = @LastName";

        await _data.SaveData(sql, new { LastName = "Jansen" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from ytdemo.people";

        people = await _data.LoadData<PersonModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
