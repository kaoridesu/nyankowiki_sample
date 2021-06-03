using System;

namespace にゃんこwiki.scripts
{
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
    }
