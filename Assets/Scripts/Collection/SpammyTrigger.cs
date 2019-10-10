using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpammyTrigger : MonoBehaviour
{
    private HashSet<Enemy> _enemies = new HashSet<Enemy>();

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        bool didAdd = _enemies.Add(enemy);

        if (didAdd)
        {
            Debug.Log(message: $" Added {enemy} in my list");
        } else
        {
            Debug.Log(message: $"{enemy} was already in my list of stuff");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        bool didRemove = _enemies.Remove(enemy);
    }
}
