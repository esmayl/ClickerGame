using UnityEngine;

public class PlayerInfo
{
    public static int money = 100;
    public static int currentDamage = 10;
    public static int playerLevel = 0;

    public static void ChangeDamage(int newDamage)
    {
        if (newDamage > currentDamage && newDamage < sizeof(int))
        {
            currentDamage = newDamage;
        }
    }

    public static void LevelUp()
    {
        playerLevel++;
    }
}
