using UnityEngine;
using UnityEngine.UI;
using System;


public class Score : GenericSingletonClass<Score>
{
    public int ScoreValue;

    public int MaxScore;
    public void Start()
    {
        ScoreValue = 0;
    }

    // Obj : Add 1 when red dragon die
    public void AddScore(int nb)
    {
        // System.Int32.TryParse(IFvar.text, out ScoreValue);

        //int x = Int32.Parse(IFvar.text);

        if (nb > 0)
            ScoreValue += nb;

        string value = ScoreValue.ToString();

        Debug.Log("ScoreValue: " + ScoreValue);
        Debug.Log("value: " + value);
        GameObject.FindGameObjectWithTag("Score").GetComponentInChildren<Text>().text = value;
    }

    // Obj : Show score on InputFiel of Canvas
    public void ShowScore()
    {

        string value = ScoreValue.ToString();
        string valueMax = PlayerPrefs.GetInt("Score", 0).ToString();
        //IFvar.text = value;
        
        //IFvar.text = value + "    / Max:  " + valueMax;
        //TO DO manage score by an other way.

    }

    // Obj : Save score in PlayerPrefs 
    // ToDo : Move in a better storage 
    public void SaveScore()
    {
        
        if (PlayerPrefs.HasKey("Score") == true)
        {
            MaxScore = PlayerPrefs.GetInt("Score");
        }
        if (ScoreValue > MaxScore)
        {
            PlayerPrefs.SetInt("Score", ScoreValue);
            PlayerPrefs.Save();
        }
    }
}
