using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Colour
{
    green,
    blue
}

public class DogColour : MonoBehaviour
{
    CelluloAgentRigidBody script;

    public Colour color;

    // Start is called before the first frame update
    void Start()
    {

        script = GetComponent<CelluloAgentRigidBody>();
        if (color == Colour.green) {
            script.SetVisualEffect(0, Color.green, 255);
            
        }
        else
        {
            script.SetVisualEffect(0, Color.blue, 255);

        }


    }

    // Update is called once per frame
    void Update()

    {
      


    }

    

    

    
}
