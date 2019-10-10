using System.Collections;
using UnityEngine;

public class PropertiesAndCoroutines : MonoBehaviour    //Attached to GO Robot
{
    public float smoothing = 7f;
    public Vector3 Target
    {
        get { return Target; }
        set
        {
            target = value;
            StopCoroutine("Movement");
            StartCoroutine("Movement", target);

        }
    }
    public Vector3 target;

    IEnumerator Movement( Vector3 target)
    {
       while( Vector3.Distance(transform.position, target) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);
            yield return null;
        }
        print("Reached the target");
        yield return new WaitForSeconds(3f);    // Usefull to launch an action
        print("MyCoroutine is now finished");
        
    }
}
