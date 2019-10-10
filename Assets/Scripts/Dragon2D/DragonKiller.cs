using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    // Attached : GO Dragon()
    // Obj : Situation where bluedragon die.
    // Param : 

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position.y > 10)
        {
            Score.Instance.ScoreValue = 0;
            SceneManager.LoadScene("DragonScene");
        }
        if (transform.position.y < -10)
        {
            Score.Instance.ScoreValue = 0;
            SceneManager.LoadScene("DragonScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Score.Instance.ScoreValue = 0;
        SceneManager.LoadScene("DragonScene");
    }
}
