using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Attached : GO DragonPrefab()
    // Obj : Lifecycle of red dragons
    // Param : 
    
    public void ManageScore()
    {
        Score.Instance.AddScore(1);
        //Score.Instance.ShowScore();
        //Score.Instance.SaveScore();
    }

    public void Die()
    {
        ManageScore();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }

    public void Respawn()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
}
