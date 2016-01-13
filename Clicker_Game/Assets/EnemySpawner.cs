using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class EnemySpawner : MonoBehaviour 
{

    public GameObject enemyPlayholder;

    public int enemyNumber = 0;//for selecting the corect enemy for respawning

    public int hp = 100;
    public float multiplier = 1.05f;

    [SerializeField]
    public EnemyBase[] Enemies;

    GameObject tempObj;

    bool spawning = false;

	void Start () 
    {
        if (!enemyPlayholder)
        {
            Debug.LogError("Please assign a placeholder for the enemy spawning, disabling script...");
            this.enabled = false;
        }
	}
	
	void Update () 
    {
        if (enemyPlayholder.transform.childCount < 1 && !spawning)
        {
            Invoke("Respawn",0.5f);
            spawning = true;
        }
        else{ return; }
	}

    void Respawn()
    {
        if (tempObj != null){ tempObj = null; }

        tempObj = Instantiate(Enemies[enemyNumber].gameObject, enemyPlayholder.transform.position, Quaternion.identity) as GameObject;
        tempObj.transform.parent = enemyPlayholder.transform;

        hp = (int) (hp*multiplier);
        EnemyBase e = tempObj.GetComponent<EnemyBase>();
        e.enemyInfo.maxHp = (int)(hp * multiplier);
        e.enemyInfo.hp = hp;
        
        
        if (enemyNumber < Enemies.Length-1)
        {
            enemyNumber++;
        }
        else
        {
            enemyNumber = 0;
        }

        spawning = false;
    }
}
