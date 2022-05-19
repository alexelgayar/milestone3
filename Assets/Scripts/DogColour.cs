using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Colour
{
    red,
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

        if((color == Colour.red && !ControlsHandler.change) || (color == Colour.blue && ControlsHandler.change)) {
            script.SetVisualEffect(0, Color.red, 255);
            
        }
        else
        {
            script.SetVisualEffect(0, Color.blue, 255);

        }


    }

    // Update is called once per frame
    void Update()

    {
        if ((color == Colour.red && !ControlsHandler.change) || (color == Colour.blue && ControlsHandler.change))
        {
            script.SetVisualEffect(0, Color.red, 255);

        }
        else
        {
            script.SetVisualEffect(0, Color.blue, 255);

        }



    }
}
