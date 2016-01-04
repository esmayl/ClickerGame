using UnityEngine;
using System.Collections;

public class EnemyBase : MonoBehaviour,IEnemy 
{
    [SerializeField]
    public EnemyInfo enemyInfo = new EnemyInfo();

    public float knockBackHeight = 100f;

    Rigidbody enemyController;

    void OnEnable()
    {

        if (GetComponent<Rigidbody>())
        {
            enemyController = GetComponent<Rigidbody>();
        }
        else
        {
            enemyController = gameObject.AddComponent<Rigidbody>();
        }

    }

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
                RemoveHp(PlayerInfo.currentDamage);
            }
        }
        
        return;
    }

    public void RemoveHp(int damage)
    {
        if (enemyController.velocity.magnitude > 0)
        {
            return;
        }
        enemyInfo.hp -= damage;

        enemyController.AddForce(transform.up*knockBackHeight);

        //TO-DO: Show damage in interface
    }

    public void Die()
    {
        UserInterface.SetText(enemyInfo.lootTable[0].lootWorth);

        //TO-DO: Add particle effect and death animation
        Destroy(gameObject);
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
