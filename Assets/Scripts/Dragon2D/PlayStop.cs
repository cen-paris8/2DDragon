using UnityEngine;
using UnityEngine.UI;

public class PlayStop : MonoBehaviour
{
    // Attached : GO Background()
    // Obj : To put game on pause and play
    // No more used
    // Param : 
    public Sprite SubstitutePlay;
    public Sprite SubstitutePause;
    public GameObject ButtonChangeMode;

    public void Awake()
    {
        ButtonChangeMode = GameObject.FindWithTag("Button");// GetComponent<Score>();
    }

    // Start is called before the first frame update
    public void OnChangeMode()
    {

        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ButtonChangeMode.GetComponent<Image>().sprite = SubstitutePlay;
        }
        else
        {
            Time.timeScale = 1;
            ButtonChangeMode.GetComponent<Image>().sprite = SubstitutePause;
        }



    }
}

   