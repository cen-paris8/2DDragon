using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class PersistentScript : MonoBehaviour
{
    public static PersistentScript control;

    public float health;
    public float experience;
    PlayerData playerData;

    // Create a singleton
    private void Awake()
    {
        if (control == null)
        {
           // DontDestroyOnLoad(gameObject); => Replace by BinaryFormatter
            control = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Health " + health);
        GUI.Label(new Rect(10, 40, 100, 30), "Experience " + experience);
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        playerData = new PlayerData()
        {
            health = health,
            experience = experience
        };
        bf.Serialize(file, playerData);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            playerData = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = playerData.health;
            experience = playerData.experience;
        }


    }
}
