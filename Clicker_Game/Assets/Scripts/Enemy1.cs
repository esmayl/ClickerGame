using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour,IEnemy 
{
    [SerializeField]
    public EnemyInfo enemyInfo = new EnemyInfo();

    void Update()
    {
        if (enemyInfo.hp <= 0)
        {
            Die();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (CheckPos(Input.mousePosition) && enemyInfo.hp > 0)
            {
                Debug.Log("Clicked enemy");
                RemoveHp(PlayerInfo.currentDamage);
            }
        }

    }

    void RemoveHp(int damage)
    {
        enemyInfo.hp -= damage;

        Debug.Log(enemyInfo.hp);
        //TO-DO: Show damage in interface
    }

    void Die()
    {
        //TO-DO: Add particle effect and death animation
        Destroy(gameObject);

        UserInterface.SetText(enemyInfo.lootTable[0].lootWorth);
    }

    public bool CheckPos(Vector3 mousePos)
    {
        Vector2 tempPos = Camera.main.WorldToScreenPoint(transform.position);

        if (Vector2.Distance(mousePos, tempPos) < 100)
        {
            return true;
        }
        return false;
    }
    
}
