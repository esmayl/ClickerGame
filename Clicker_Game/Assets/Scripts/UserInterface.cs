using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserInterface : MonoBehaviour
{
    public Text scoreObject;

    static string scoreText = "";

	void Update ()
	{
	    if (scoreText != ""){scoreObject.text = scoreText;}
	}

    public static void SetText(int newText)
    {
        string tempText = "" + newText;
        
        string text = "";

        while (text.Length < 18-tempText.Length)
        {
            text += "0";
        }
        text += tempText;
        scoreText = string.Format("{0,10}",text);
    }
}
