using UnityEngine;

public class Jump : MonoBehaviour
{
    // Attached : GO Dragon()
    // Obj : Bluedragon Jump.
    // Param : (int) index of scene
    public Vector2 JumpForce;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
            GetComponent<AudioSource>().Play();
        }
    }
}
