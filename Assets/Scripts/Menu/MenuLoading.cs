using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLoading : MonoBehaviour
{
    private int indexScene = 4;
    public Text sceneName;
    public Button previous;
    public Button next;
    List<MenuSceneData> menuSceneList = new List<MenuSceneData>();

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        
        menuSceneList.Add(new MenuSceneData("Pool"));
        menuSceneList.Add(new MenuSceneData("Presentation"));
        menuSceneList.Add(new MenuSceneData("Coroutine"));
        menuSceneList.Add(new MenuSceneData("Persistent"));
        menuSceneList.Add(new MenuSceneData("DragonScene"));
        menuSceneList.Add(new MenuSceneData("Swipe"));
        menuSceneList.Add(new MenuSceneData("SavingData1"));


        SceneManager.LoadScene(indexScene);
        sceneName.text = SceneManager.GetActiveScene().name;
    }

    public void OnChangeScene(int position)
    {
        if (position == 1) 
        {
            previous.interactable = true;
            
            if (indexScene > 5)
            {
                indexScene = 5;
                next.interactable = false;
                // To Do : Also disable button
            }
            indexScene++;

            //Scene scene = SceneManager.GetSceneByName("Menu");
            //SceneManager.LoadScene("Menu");
        }
        else 
        {
            next.interactable = true;
            if (indexScene < 1)
            {
                indexScene = 1;
                previous.interactable = false;
                // To Do : Also disable button
            }

            indexScene--;
        }

        //sceneName.text = SceneManager.GetSceneByBuildIndex(indexScene).name;
        sceneName.text = menuSceneList[indexScene].name;
        SceneManager.LoadScene(sceneName.text);

    }

}
