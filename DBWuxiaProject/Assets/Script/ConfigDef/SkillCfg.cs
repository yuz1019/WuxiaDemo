using UnityEngine;
using System.Collections;

public enum SkillShapeType
{
    None = 0,
    Circle,
    Rectangle,
}

public enum SkillCastType
{
    Normal = 1,
    Special,
}

public class SkillCfg : MonoBehaviour
{
    public int ID;
    public string SkillName;
    public Texture2D Icon;
    public GameObject Effect;

    public SkillShapeType ShapeType;
    public float ShapeParm1;    // 矩形：宽/圆：度数
    public float ShapeParm2;    // 矩形：长/圆：半径

    public SkillCastType CastType = SkillCastType.Normal;
    public float DamageEff;     // 伤害系数
    public int Consume;         // 消耗
    public int HitRate;         // 命中概率
    public int HitNum;          // 最大命中数量

    public int[] AddBuffList;   // 附加的buffID
}
