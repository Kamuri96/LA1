using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Friendly
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

    //追加したところ

    public void AddHp()
    {
        hp += 10;
        DisplayHpValue();
    }

    internal override void AddDamage()
    {
        int damage = Random.Range(0, 10);
        hp -= damage;
        DisplayHpValue();
    }

    internal override void OnAttack()
    {
        Debug.Log("Playerテク子の攻撃！");
        _gameManager.OnEnemyDamage(attackPower);
    }

    internal override void OnSpSkill()
    {
        Debug.Log("Playerのスキル発動！Enemyへ二倍攻撃！");
        _gameManager.OnEnemyDamage(attackPower * 2);
    }

}
