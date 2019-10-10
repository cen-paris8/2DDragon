using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<BadGuy> badGuys = new List<BadGuy>
        {
            new BadGuy("Harvey", 50),
            new BadGuy("Magneto", 100),
            new BadGuy("Pip", 5)
        };

        // Other nomenclature :
        /*
         * List<BadGuy> badguys = new List<BadGuy>();
        
        //Here you add 3 BadGuys to the List
        badguys.Add( new BadGuy("Harvey", 50));
        badguys.Add( new BadGuy("Magneto", 100));
        badguys.Add( new BadGuy("Pip", 5));
        */

        // To access to an element in the list as an array:
        // badGuys[0].name;
        // RemoveAt() to delete an element by index.
        // Insert() to Add an element by Index.
        
        badGuys.Sort();     //Call CompareTo function 

        foreach(BadGuy guy in badGuys)
        {
            print(guy.name + " " + guy.power);
        }
        badGuys.Clear();

    }

}
