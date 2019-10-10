using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; private set; }

    private void Awake() => Instance = this;

    private List<Enemy> enemies = new List<Enemy>();

    public void AddEnemy(Enemy _enemy)
    {
        enemies.Add(_enemy);
    }

    public void RemoveEnemy(Enemy _enemy) => enemies.Remove(_enemy);

}
