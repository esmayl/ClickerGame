using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserInterface : MonoBehaviour
{
    public Text scoreObject;
    public Scrollbar enemyHpObject;

    static string scoreText = "";

    static int score = 0;
    static float hp = 1f;

	void Update ()
	{
	    if (scoreText != ""){scoreObject.text = scoreText;}

	    if (hp > 0)
	    {
	        if (enemyHpObject.GetComponent<CanvasGroup>().alpha < 1)
	        {
	            enemyHpObject.GetComponent<CanvasGroup>().alpha = 1f;
	        }

	        enemyHpObject.size = hp;
	    }
	    else
	    {
            enemyHpObject.GetComponent<CanvasGroup>().alpha = 0;
        }
	}

    public static void SetText(int newText)
    {
        score += newText;

        string tempText = "" + score;
        
        string text = "";

        while (text.Length < 18-tempText.Length)
        {
            text += "0";
        }
        text += tempText;
        scoreText = string.Format("{0,10}",text);
    }

    public static void ChangeHp(int currentHp, int maxHp)
    {
        float onePerc = maxHp/100f;
        float percentage = currentHp/onePerc;

        if (percentage > 0 && percentage < 100)
        {
            hp = percentage/100f;
        }
        else
        {
            hp = 0;
        }
    }

    public static void ResetHp()
    {
        hp = 1f;
    }
}
