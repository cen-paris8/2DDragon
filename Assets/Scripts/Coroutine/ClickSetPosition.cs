using System.Collections;
using UnityEngine;

//Attached to GO Background 
public class ClickSetPosition : MonoBehaviour
{
    public PropertiesAndCoroutines coroutineScript; // From Robot GO.
    
    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Get Vector3 Mouse position on GameView != on Device Screen

        RaycastHit hit;
        Physics.Raycast(ray, out hit);  // Has to be true/false if ray intercept a gameObject, do not work on 2D => unuseful

        // As collider does not work, i call coroutine as soon as Mouse is down
        // And I use ray.origin instead of hit.point
        //if (hit.collider.gameObject == gameObject)
        //{
        //    print("Collider");
        //    coroutineScript.Target = hit.point;
        //}
        coroutineScript.Target = ray.origin;

    }

}
