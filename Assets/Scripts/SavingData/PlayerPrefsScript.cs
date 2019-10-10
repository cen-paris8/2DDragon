using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsScript : MonoBehaviour
{
    public int sceneToLoad;

    void OnGUI()
    {
        GUI.Label(new Rect(200, 400, 100, 30), SceneManager.GetActiveScene().name);
        if (GUI.Button(new Rect(200, 420, 100, 30), "Change Scene"))
        {
            
            if ( SceneManager.GetActiveScene().name == "SavingData1")
            {
                SceneManager.LoadScene("SavingData2");
            }
            else
            {
                SceneManager.LoadScene("SavingData1");
            }

            PlayerPrefs.SetInt("Health", 50);
            int x = PlayerPrefs.GetInt("Health");
            
        }
    }
}
