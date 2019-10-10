using System.IO;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private RoundData[] allRoundData;
    private PlayerProgress playerProgress;
    private string gameDataFileName = "Quizz/data.json";

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad( gameObject );
        LoadDataGame();
        LoadPlayerProgress();

        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScreen");        
        
    }

    public RoundData GetCurrentRoundData()
    {
        return allRoundData[0];
    }

    public void SubmitNewPlayerScore(int newScore)
    {
        if (newScore > playerProgress.highestScore)
        {
            playerProgress.highestScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighestPlayerScore(){
        return playerProgress.highestScore;
    }
    private void LoadPlayerProgress()
    {
        playerProgress = new PlayerProgress();

        if (PlayerPrefs.HasKey("highestScore"))
        {
            playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
        }
    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    }

    private void LoadDataGame()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

            allRoundData = loadedData.allRoundData;

        }
        else
        {
            Debug.Log("Cannot load GameData " + filePath);
        }
    }

}