namespace にゃんこwiki.scripts
{
 
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
}