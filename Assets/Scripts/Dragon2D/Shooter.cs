using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Attached : GO BlueDragon()
    // Obj : init Fireball
    // Param : 
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 deltaMove;
            deltaMove.x = 2;
            deltaMove.y = 0;
            deltaMove.z = 0;

            var projectile = GameObject.Instantiate(
                projectilePrefab,
                transform.position + deltaMove,
                projectilePrefab.transform.rotation); // Quaternion.identity
        }
        
    }
}
 