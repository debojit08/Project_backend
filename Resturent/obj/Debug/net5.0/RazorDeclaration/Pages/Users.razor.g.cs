// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Resturent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "E:\ResturentDemo\Resturent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\ResturentDemo\Resturent\_Imports.razor"
using Resturent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\ResturentDemo\Resturent\_Imports.razor"
using Resturent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\ResturentDemo\Resturent\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ResturentDemo\Resturent\Pages\Users.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ResturentDemo\Resturent\Pages\Users.razor"
using NPOI.SS.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ResturentDemo\Resturent\Pages\Users.razor"
using NPOI.XSSF.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ResturentDemo\Resturent\Pages\Users.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ResturentDemo\Resturent\Pages\Users.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "E:\ResturentDemo\Resturent\Pages\Users.razor"
       



    private bool dense = false;
    private bool hover = true;
    private bool striped = false;
    private bool bordered = false;
    private string searchString = "";




    List<User> objUser;
    List<User> objUser1;
    User obj = new User();

    private HashSet<User> selectedItems = new HashSet<User>();
    private HashSet<User> user = new HashSet<User>();



    //display
    private HashSet<User> GetUsers()
    {

        objUser = objUserService.GetUser(); //after delete display
        return user;
    }

    protected override async Task OnInitializedAsync()
    {
        objUser = await Task.Run(() => objUserService.GetUser());

    }


    //search
    private bool FilterFunc(User element)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                          
    if ($"{element.UserName} {element.MobileNo}".Contains(searchString))
        return true;

    return false;
}

//delete
protected void Delete(long UserId)
{
    objUserService.Delete(UserId);
    GetUsers();

}
//multiDelete
protected void DeleteMulti(long[] num)
{
    foreach (long x in num)
    {
        objUserService.Delete(x);
    }
    GetUsers();
}



//----------------------------------------Excel export----------------------------------//

public async Task GenerateExcel()
{
    objUser = objUserService.GetUser();

    IWorkbook workbook = new XSSFWorkbook();

    var dataformat = workbook.CreateDataFormat();
    var datastyle = workbook.CreateCellStyle();
    datastyle.DataFormat = dataformat.GetFormat("dd - MMM - yyyy hh: mm");

    ISheet worksheet = workbook.CreateSheet("Sheet1");

    int rowNumber = 0;
    IRow row = worksheet.CreateRow(rowNumber++);

    //-------------------------sheet header------------------

    ICell cell = row.CreateCell(0);
    cell.SetCellValue("User Name");

    cell = row.CreateCell(1);
    cell.SetCellValue("Email Id");

    cell = row.CreateCell(2);
    cell.SetCellValue("Mobile No.");

    cell = row.CreateCell(3);
    cell.SetCellValue("Entry Date");

    cell = row.CreateCell(4);
    cell.SetCellValue("Modify Date");


    //sheet value

    foreach (var user in objUser)
    {

        row = worksheet.CreateRow(rowNumber++);

        cell = row.CreateCell(0);
        cell.SetCellValue(user.UserName);

        cell = row.CreateCell(1);
        cell.SetCellValue(user.EmailId);

        cell = row.CreateCell(2);
        cell.SetCellValue(user.MobileNo);

        cell = row.CreateCell(3);
        cell.SetCellValue(user.EDate?.ToString("dd-MMM-yyyy hh:mm"));

        cell = row.CreateCell(4);
        cell.SetCellValue(user.MDate?.ToString("dd-MMM-yyyy hh:mm"));



    }


    MemoryStream ms = new MemoryStream();
    workbook.Write(ms);
    byte[] bytes = ms.ToArray();
    ms.Close();

    await jsruntime.SaveAsFileAsync("User List", bytes, "application/vnd.ms-excel");


}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService objUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
    }
}
#pragma warning restore 1591
