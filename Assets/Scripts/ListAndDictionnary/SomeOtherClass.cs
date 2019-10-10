using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    public string value = "birds";

    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, BadGuy> badGuys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        badGuys.Add("gangster", bg1);
        badGuys.Add("mutant", bg2);

        BadGuy temp = null;
        /// If you don't know the key, and need a default value
        //badGuys.ElementAt(0);

        if (badGuys.TryGetValue(value, out temp))
        {
            //success
            print("Find value" + temp.power + " " + temp.name);
        }
        else
        {
            //failed
            print("not found");
        }
    }

}
