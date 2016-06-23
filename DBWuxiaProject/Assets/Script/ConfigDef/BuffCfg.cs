using UnityEngine;
using System.Collections;

public enum BuffType
{
    None = 0,
    Atk,
    Def,
    Rang,
    Dodge,
    Life,
    MaxLife,
    Mana,
    MaxMana,
    MoveEff,
    ForbidAtk,
    ForbidFatal,
    Taunt,
    SuddenDeath,
    RunAway,
    Obey,
}

public enum BuffValueType
{
    Value = 1,
    Percent,
}

public enum BuffTarget
{
    Enemy = 1,
    Self,
    Ally,
}

public class BuffCfg : MonoBehaviour
{
    public int ID;
    public string BuffName;
    public Texture2D Icon;
    public GameObject Effect;

    public BuffType Type;                                   // buff类型
    public BuffValueType ValueType = BuffValueType.Value;   // 数值类型
    public BuffTarget Target = BuffTarget.Enemy;            // 释放对象

    public int EffValue;        // 效果数值
    public int Sustain;         // 持续回合（0是瞬时结算）
    public int HitRate;         // 发动概率
    public int Overlay;         // 最大叠加层数
}