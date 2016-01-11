using UnityEngine;
using System.Collections;

public class Upgrades : MonoBehaviour
{
    public RectTransform buttonTemplate;

    public int[] units = new int[10];


	void Start () 
    {
        
    }
	
	void Update () 
    {
	
	}

    public void AddUpgrade(int id)
    {
        PlayerInfo.currentDamage += units[id];
    }
}
