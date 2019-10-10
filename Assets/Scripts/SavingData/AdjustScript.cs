using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 100, 100, 30), "Health Up"))
        {
            PersistentScript.control.health += 10;
        }
        if (GUI.Button(new Rect(10, 150, 100, 30), "Health Down"))
        {
            PersistentScript.control.health -= 10;
        }
        if (GUI.Button(new Rect(10, 200, 100, 30), "Experience Up"))
        {
            GUIStyle gUIStyle = GUI.skin.GetStyle("Label");
            PersistentScript.control.experience += 10;
        }
        if (GUI.Button(new Rect(10, 250, 100, 30), "Experience Up"))
        {
            PersistentScript.control.experience -= 10;
        }
        if (GUI.Button(new Rect(10, 300, 100, 30), "Save"))
        {
            PersistentScript.control.Save();
        }
        if (GUI.Button(new Rect(10, 350, 100, 30), "Load"))
        {
            PersistentScript.control.Load();
        }
    }
}
