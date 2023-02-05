using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Friendly
{
    public GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal override void AddDamage()
    {
        int damage = Random.Range(0, 20);
        hp -= damage;
        DisplayHpValue();
    }

    internal override void OnAttack()
    {
        Debug.Log("ヒーラーウーノの攻撃！");
        _gameManager.OnEnemyDamage(attackPower);
    }

    internal override void OnSpSkill()
    {
        Debug.Log("ヒーラーのスキル発動！Playerを回復した");
        _gameManager.OnPlayerHeal();
    }

}
