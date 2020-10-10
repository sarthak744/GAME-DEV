
using System.CodeDom.Compiler;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class dice : MonoBehaviour
{
    public Text score;
    public Text hs;
    void Start()
    {
        hs.text = PlayerPrefs.GetInt("highscore",0).ToString();
    }
    public void rolldice()
    {
        int temp = Random.Range(1, 7);
        score.text = temp.ToString();
        if(temp>PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore", temp);
            hs.text = temp.ToString();
        }
       
    }

    public void reset()
    {
        PlayerPrefs.DeleteKey("highscore");
        hs.text = "0";

    }
}
