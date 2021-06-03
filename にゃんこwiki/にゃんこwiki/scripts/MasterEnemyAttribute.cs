namespace にゃんこwiki.scripts
{
    public class MasterEnemyAttribute
    {
        public int 識別番号;
        public int 敵のID;
        public EnemyAttributeType 敵の属性のタイプ;

        public MasterEnemyAttribute(int 識別番号, int 敵のid, EnemyAttributeType 敵の属性のタイプ)
        {
            this.識別番号 = 識別番号;
            敵のID = 敵のid;
            this.敵の属性のタイプ = 敵の属性のタイプ;
        }
    }
}