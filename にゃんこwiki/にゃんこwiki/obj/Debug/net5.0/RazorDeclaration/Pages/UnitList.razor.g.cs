// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace にゃんこwiki.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using にゃんこwiki;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/_Imports.razor"
using にゃんこwiki.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/UnitList.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/UnitList.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/UnitList.razor"
using にゃんこwiki.scripts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UnitList")]
    public partial class UnitList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/UnitList.razor"
      
    List<MasterUnit> 味方一覧 = new List<MasterUnit>();

    protected override async Task OnInitializedAsync()
    {
        string json = await HttpClient.GetStringAsync(requestUri: "https://script.google.com/macros/s/AKfycbxZqFx1QUcjP9OIfItchQ5HFCCT2l-wmolVrq7j1QHO3_lTvdVFEqemL4dgwgRVxUyu4w/exec");
    // Console.WriteLine(json);json

        JsonDocument jsonDocument = JsonDocument.Parse(json);
        JsonElement jsonElement = jsonDocument.RootElement.GetProperty("[D]master_unit");
        JsonElement.ArrayEnumerator list = jsonElement.EnumerateArray();

        foreach (JsonElement masterUnitObject in list)
        {
            int 識別番号 = masterUnitObject.GetProperty("識別番号").GetInt32();
            UnitRank ランク = (UnitRank) masterUnitObject.GetProperty("ランク").GetInt32();
            string キャラクター名 = masterUnitObject.GetProperty("キャラクター名").GetString();
            int カスタマイズレベル = masterUnitObject.GetProperty("カスタマイズレベル").GetInt32();
            int 体力 = masterUnitObject.GetProperty("体力").GetInt32();
            int ノックバック = masterUnitObject.GetProperty("ノックバック").GetInt32();
            int 速度 = masterUnitObject.GetProperty("速度").GetInt32();
            int 攻撃力 = masterUnitObject.GetProperty("攻撃力").GetInt32();
            int DPS = masterUnitObject.GetProperty("DPS").GetInt32();
            UnitRange 範囲 = (UnitRange) masterUnitObject.GetProperty("範囲").GetInt32();
            int 頻度フレーム = masterUnitObject.GetProperty("頻度フレーム").GetInt32();
            int 発生フレーム = masterUnitObject.GetProperty("発生フレーム").GetInt32();
            int 射程 = masterUnitObject.GetProperty("射程").GetInt32();
            int コスト = masterUnitObject.GetProperty("コスト").GetInt32();
            int 再生産フレーム = masterUnitObject.GetProperty("再生産フレーム").GetInt32();
            string 特性 = masterUnitObject.GetProperty("特性").GetString();

            MasterUnit masterUnit = new MasterUnit(
                識別番号,
                ランク,
                キャラクター名,
                カスタマイズレベル,
                体力,
                ノックバック,
                速度,
                攻撃力,
                DPS,
                範囲,
                頻度フレーム,
                発生フレーム,
                射程,
                コスト,
                再生産フレーム,
                特性);
            味方一覧.Add(masterUnit);
        }

    }

    public void OnClickDetail(int 味方の識別番号)
    {
        Console.WriteLine(味方の識別番号);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
