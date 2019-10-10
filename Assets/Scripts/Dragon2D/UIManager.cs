using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    // Attached : GO Canvas()
    // Obj : Avoid to destroy InputField of Canvas when scene reloaded
    public virtual void Awake()
    {
            DontDestroyOnLoad(this.gameObject);

    }
}
