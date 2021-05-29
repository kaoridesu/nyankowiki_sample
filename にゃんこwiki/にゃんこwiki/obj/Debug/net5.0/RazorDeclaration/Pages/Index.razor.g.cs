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
#line 4 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "/Users/kaori/Github/にゃんこwiki_sample/にゃんこwiki/にゃんこwiki/Pages/Index.razor"
 
    List<MasterEnemy> 敵一覧 = new List<MasterEnemy>();

    protected override async Task OnInitializedAsync()
    {
        string json = await HttpClient.GetStringAsync(requestUri: "master-data/master_enemy.json");
        Console.WriteLine(json);
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
    }

    // protected override void OnInitialized()
    // {
    // }
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
        int 速度;
        int 攻撃力;
        int DPS;
        UnitRange 範囲;
        int 頻度フレーム;
        int 発生フレーム;
        int 射程;
        int コスト;
        int 再生産フレーム;
        String 特性;

        // public MasterUnit(int 識別番号, UnitRank ランク, string キャラクター名, int カスタマイズレベル, int 体力, int ノックバック, int 速度, int 攻撃力, int dps, UnitRange 範囲, int 頻度フレーム, int 発生フレーム, int 射程, int コスト, int 再生産フレーム, string 特性)
        // {
        //     this.識別番号 = 識別番号;
        //     this.ランク = ランク;
        //     this.キャラクター名 = キャラクター名;
        //     this.カスタマイズレベル = カスタマイズレベル;
        //     this.体力 = 体力;
        //     this.ノックバック = ノックバック;
        //     this.速度 = 速度;
        //     this.攻撃力 = 攻撃力;
        //     this.DPS = dps;
        //     this.範囲 = 範囲;
        //     this.頻度フレーム = 頻度フレーム;
        //     this.発生フレーム = 発生フレーム;
        //     this.射程 = 射程;
        //     this.コスト = コスト;
        //     this.再生産フレーム = 再生産フレーム;
        //     this.特性 = 特性;
        // }
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
