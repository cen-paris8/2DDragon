using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionCounter : MonoBehaviour
{
    private Dictionary<Enemy, int> _enemySelectionCount = new Dictionary<Enemy, int>();

    public static SelectionCounter Instance { get; private set; }

    private void Select(Enemy enemy)
    {
        if (_enemySelectionCount.ContainsKey(enemy) == false)
        {
            _enemySelectionCount[enemy] = 1;
        } else
        {
            _enemySelectionCount[enemy]++;
        }

        TintEnemyIfWeClickedEnough(enemy);
    }

    public void TintEnemyIfWeClickedEnough(Enemy enemy)
    {
        if (_enemySelectionCount[enemy]  >= 5)
        {
            enemy.GetComponent<Renderer>().material.color = Color.red;
        }
    }

}
