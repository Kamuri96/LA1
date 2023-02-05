using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Friendly : MonoBehaviour
{
    public Text hpText;
    public GameManager gameManager;
    public int hp;
    public int mp;
    public float attackPower;

    /// <summary>
    /// Textへhpの値を反映させるメソッド
    /// </summary>
    public void DisplayHpValue()
    {
        hpText.text = "HP: " + hp.ToString();
    }

    internal abstract void AddDamage();

    internal abstract void OnAttack();

    internal abstract void OnSpSkill();

}
