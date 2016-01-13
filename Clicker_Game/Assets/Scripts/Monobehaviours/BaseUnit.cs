using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BaseUnit : MonoBehaviour
{
    public static string unitName;
    public static Image image;

    public EnemyBase enemy;

    public int damage;
    public float damageMultiplier;
    public int unitAmount;

    public float attackSpeed;
    public float attackSpeedTimer;

    public void BuyUnit(int amount)
    {
        unitAmount = unitAmount + amount;
        MultiplyDamage(damageMultiplier);
    }

    public void MultiplyDamage(float multiplier)
    {
        damage += (int)(damage * multiplier);
    }

    public void Update()
    {
        enemy = GetEnemy();
        attackSpeedTimer += Time.deltaTime;

        if (attackSpeedTimer > attackSpeed)
        {
            Attack();
            attackSpeedTimer = 0;
        }
    }

    public void Attack()
    {
        if(enemy)
        enemy.RemoveHp(damage);
    }

    public EnemyBase GetEnemy()
    {
        return GameObject.Find("EnemyPlaceholder").GetComponentInChildren<EnemyBase>();
    }
}
