#pragma checksum "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d322ffbd1520927f870ca8e31d8430ddd4b6fde4"
// <auto-generated/>
#pragma warning disable 1591
namespace にゃんこwiki.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 3 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
  
    // MasterEnemy わんこ = new MasterEnemy(識別番号: 1, 属性id: 1, キャラクター名: "わんこ", 強さ倍率: 100, 体力: 90, ノックバック: 3, 速度: 5, 攻撃力: 8, dps: 5, EnemyRange.単体, 頻度フレーム: 47, 発生フレーム: 8, 射程: 110, お金: 15, "");
    // MasterEnemy にょろ = new MasterEnemy(識別番号: 2, 属性id: 2, キャラクター名: "にょろ", 強さ倍率: 100, 体力: 100, ノックバック: 3, 速度: 8, 攻撃力: 15, dps: 12, EnemyRange.単体, 頻度フレーム: 37, 発生フレーム: 8, 射程: 110, お金: 30, "");
    // MasterEnemy 例のヤツ = new MasterEnemy(識別番号: 3, 属性id: 3, キャラクター名: "例のヤツ", 強さ倍率: 100, 体力: 90, ノックバック: 3, 速度: 5, 攻撃力: 20, dps: 20, EnemyRange.単体, 頻度フレーム: 30, 発生フレーム: 10, 射程: 110, お金: 75, "");
    //
    // List<int> list = new List<int>();
    // list.Add(item:1);
    // List<MasterEnemy> 敵一覧 = new List<MasterEnemy>();
    // 敵一覧.Add(わんこ);
    // 敵一覧.Add(にょろ);
    // 敵一覧.Add(例のヤツ);
    //MasterUnit ネコ = new MasterUnit(識別番号: 1, UnitRank.基本, キャラクター名: "ネコ", カスタマイズレベル:90, 体力: 4450, ノックバック: 3, 速度: 10, 攻撃力: 335, dps: 228, UnitRange.単体,　頻度フレーム: 37, 発生フレーム: 8, 射程: 140, コスト: 75, 再生産フレーム:68,"");
    //MasterUnit ネコビルダー = new MasterUnit(識別番号: 2, UnitRank.基本, キャラクター名: "ネコビルダー", カスタマイズレベル:90, 体力: 4450, ノックバック: 3, 速度: 10, 攻撃力: 35, dps: 228, UnitRange.単体, 頻度フレーム: 37, 発生フレーム: 8, 射程: 140, コスト: 75, 再生産フレーム:68,"");
    //MasterUnit ネコモヒカン = new MasterUnit(識別番号: 3, UnitRank.基本, キャラクター名: "ネコモヒカン", カスタマイズレベル:90, 体力: 8900, ノックバック: 3, 速度: 10, 攻撃力: 712, dps: 578, UnitRange.単体, 頻度フレーム: 37, 発生フレーム: 8, 射程: 140, コスト: 75, 再生産フレーム:68, "");
    //MasteEnemyAttribute 属性1 = new MasterEnemyAttribute(識別番号: 1, 敵のid: 2, EnemyAttributeType.白い敵);
    //MasterEnemyAttribute 属性2 = new MasterEnemyAttribute(識別番号: 2, 敵のid: 2, EnemyAttributeType.白い敵);
    //MasterEnemyAttribute 属性3 = new MasterEnemyAttribute(識別番号: 3, 敵のid: 3, EnemyAttributeType.白い敵);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddMarkupContent(1, @"<thead><tr><th>No</th>
        <th>属性</th>
        <th>キャラクター名</th>
        <th>強さ倍率</th>
        <th>体力</th>
        <th>㎅</th>
        <th>速度</th>
        <th>攻撃力</th>
        <th>DPS</th>
        <th>範囲</th>
        <th>頻度フレーム</th>
        <th>発生フレーム</th>
        <th>射程</th>
        <th>お金</th>
        <th>特性</th></tr></thead>
    ");
            __builder.OpenElement(2, "tbody");
#nullable restore
#line 47 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
      
        foreach (var 敵　in 敵一覧)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "td");
            __builder.AddContent(5, 
#nullable restore
#line 51 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.識別番号

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n                ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 52 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.属性ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 53 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.キャラクター名

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 54 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.強さ倍率

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 55 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.体力

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 56 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.ノックバック

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 57 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.速度

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 58 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.攻撃力

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 59 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.DPS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 60 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.範囲

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 61 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.頻度フレーム

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 62 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.発生フレーム

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 63 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.射程

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 64 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.お金

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 65 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                     敵.特性

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
        }

       
    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
            __builder.OpenElement(49, "table");
            __builder.AddMarkupContent(50, @"<thead><tr><th>No</th>
        <th>ランク</th>
        <th>キャラクター名</th>
        <th>カスタマイズレベル</th>
        <th>体力</th>
        <th>㎅</th>
        <th>速度</th>
        <th>攻撃力</th>
        <th>DPS</th>
        <th>範囲</th>
        <th>頻度フレーム</th>
        <th>発生フレーム</th>
        <th>射程</th>
        <th>コスト</th>
        <th>発生フレーム</th>
        <th>特性</th></tr></thead>
    ");
            __builder.OpenElement(51, "tbody");
#nullable restore
#line 148 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
      
        
        foreach (var 味方 in 味方一覧)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "tr");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 154 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.識別番号

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n            ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 155 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.ランク

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n            ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 156 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.キャラクター名

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n            ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 157 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.カスタマイズレベル

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n            ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 158 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.体力

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n            ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 159 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.ノックバック

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n            ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 160 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.速度

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n            ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 161 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.攻撃力

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n            ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 162 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.DPS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n            ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 163 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.範囲

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n            ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 164 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.頻度フレーム

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n            ");
            __builder.OpenElement(86, "td");
            __builder.AddContent(87, 
#nullable restore
#line 165 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.発生フレーム

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n            ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 166 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.射程

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n            ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 167 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.コスト

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n            ");
            __builder.OpenElement(95, "td");
            __builder.AddContent(96, 
#nullable restore
#line 168 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.再生産フレーム

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n            ");
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 169 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
                 味方.特性

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 171 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
        }

    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 180 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
 
    List<MasterEnemy> 敵一覧 = new List<MasterEnemy>();
    List<MasterUnit> 味方一覧 = new List<MasterUnit>();

    protected override async Task OnInitializedAsync()
    {
        string json = await HttpClient.GetStringAsync(requestUri: "master-data/master_enemy.json");
    // Console.WriteLine(json);json

        JsonDocument jsonDocument = JsonDocument.Parse(json);
        JsonElement jsonElement = jsonDocument.RootElement.GetProperty("[D]master_enemy");
        JsonElement.ArrayEnumerator list = jsonElement.EnumerateArray();

        foreach (JsonElement masterEnemyObject in list)
        {
            int 識別番号 = masterEnemyObject.GetProperty("識別番号").GetInt32();
            int 属性ID = masterEnemyObject.GetProperty("属性ID").GetInt32();
            string キャラクター名 = masterEnemyObject.GetProperty("キャラクター名").GetString();
            int 強さ倍率 = masterEnemyObject.GetProperty("強さ倍率").GetInt32();
            int 体力 = masterEnemyObject.GetProperty("体力").GetInt32();
            int ノックバック = masterEnemyObject.GetProperty("ノックバック").GetInt32();
            int 速度 = masterEnemyObject.GetProperty("速度").GetInt32();
            int 攻撃力 = masterEnemyObject.GetProperty("攻撃力").GetInt32();
            int DPS = masterEnemyObject.GetProperty("DPS").GetInt32();
            EnemyRange 範囲 = (EnemyRange) masterEnemyObject.GetProperty("範囲").GetInt32();
            int 頻度フレーム = masterEnemyObject.GetProperty("頻度フレーム").GetInt32();
            int 攻発フレーム = masterEnemyObject.GetProperty("攻発フレーム").GetInt32();
            int 射程 = masterEnemyObject.GetProperty("射程").GetInt32();
            int お金 = masterEnemyObject.GetProperty("お金").GetInt32();
            string 特性 = masterEnemyObject.GetProperty("特性").GetString();

            MasterEnemy masterEnemy = new MasterEnemy(
                識別番号,
                属性ID,
                キャラクター名,
                強さ倍率,
                体力,
                ノックバック,
                速度,
                攻撃力,
                DPS,
                範囲,
                頻度フレーム,
                攻発フレーム,
                射程,
                お金,
                特性);
            敵一覧.Add(masterEnemy);
        }

        string json2 = await HttpClient.GetStringAsync(requestUri: "master-data/master_unit.json");
    // Console.WriteLine(json);json

        JsonDocument jsonDocument2 = JsonDocument.Parse(json2);
        JsonElement jsonElement2 = jsonDocument2.RootElement.GetProperty("[D]master_unit");
        JsonElement.ArrayEnumerator list2 = jsonElement2.EnumerateArray();
        
        foreach (JsonElement masterUnitObject in list2)
        {
            int 識別番号 = masterUnitObject.GetProperty("識別番号").GetInt32();
            UnitRank ランク　= (UnitRank)masterUnitObject.GetProperty("ランク").GetInt32();
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

    public class MasterEnemy
    {
        public int 識別番号;
        public int 属性ID;
        public string キャラクター名;
        public int 強さ倍率;
        public int 体力;
        public int ノックバック;
        public int 速度;
        public int 攻撃力;
        public int DPS;
        public EnemyRange 範囲;
        public int 頻度フレーム;
        public int 発生フレーム;
        public int 射程;
        public int お金;
        public string 特性;
    //コンストラクタ
        public MasterEnemy(int 識別番号, int 属性id, string キャラクター名, int 強さ倍率, int 体力, int ノックバック, int 速度, int 攻撃力, int dps, EnemyRange 範囲, int 頻度フレーム, int 発生フレーム, int 射程, int お金, string 特性)
        {
            this.識別番号 = 識別番号;
            this.属性ID = 属性id;
            this.キャラクター名 = キャラクター名;
            this.強さ倍率 = 強さ倍率;
            this.体力 = 体力;
            this.ノックバック = ノックバック;
            this.速度 = 速度;
            this.攻撃力 = 攻撃力;
            this.DPS = dps;
            this.範囲 = 範囲;
            this.頻度フレーム = 頻度フレーム;
            this.発生フレーム = 発生フレーム;
            this.射程 = 射程;
            this.お金 = お金;
            this.特性 = 特性;
        }
    }

    public class MasterUnit
    {
        public int 識別番号;
        public UnitRank ランク;
        public string キャラクター名;
        public int カスタマイズレベル;
        public int 体力;
        public int ノックバック;
        public int 速度;
        public int 攻撃力;
        public int DPS;
        public UnitRange 範囲;
        public int 頻度フレーム;
        public int 発生フレーム;
        public int 射程;
        public int コスト;
        public int 再生産フレーム;
        public String 特性;

        public MasterUnit(int 識別番号, UnitRank ランク, string キャラクター名, int カスタマイズレベル, int 体力, int ノックバック, int 速度, int 攻撃力, int dps, UnitRange 範囲, int 頻度フレーム, int 発生フレーム, int 射程, int コスト, int 再生産フレーム, string 特性)
        {
            this.識別番号 = 識別番号;
            this.ランク = ランク;
            this.キャラクター名 = キャラクター名;
            this.カスタマイズレベル = カスタマイズレベル;
            this.体力 = 体力;
            this.ノックバック = ノックバック;
            this.速度 = 速度;
            this.攻撃力 = 攻撃力;
            this.DPS = dps;
            this.範囲 = 範囲;
            this.頻度フレーム = 頻度フレーム;
            this.発生フレーム = 発生フレーム;
            this.射程 = 射程;
            this.コスト = コスト;
            this.再生産フレーム = 再生産フレーム;
            this.特性 = 特性;
        }
    }

    public class MasterEnemyAttribute
    {
        int 識別番号;
        int 敵のID;
        EnemyAttributeType 敵の属性のタイプ;

        public MasterEnemyAttribute(int 識別番号, int 敵のid, EnemyAttributeType 敵の属性のタイプ)
        {
            this.識別番号 = 識別番号;
            敵のID = 敵のid;
            this.敵の属性のタイプ = 敵の属性のタイプ;
        }
    }

    public enum UnitRank
    {
        基本 = 1,
        Ex = 2
    }

    public enum UnitRange
    {
        単体 = 1,
        範囲 = 2
    }

    public enum EnemyRange
    {
        単体 = 1,
        範囲 = 2
    }

    public enum EnemyAttributeType
    {
        白い敵 = 1,
        赤い敵 = 2,
        黒い敵 = 3,
        浮いている敵 = 4
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
