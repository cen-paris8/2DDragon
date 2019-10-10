using UnityEngine;

public class FireBall : MonoBehaviour
{
    // Attached : GO FireballPrefab()
    // Obj : Move Fireballs on the scene
    // Param : 
    public Vector2 StartingVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 5);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var Enemy = collision.collider.GetComponent<Enemy>();
        Enemy?.Die();

        Destroy(gameObject);
    }
}

