using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlsHandler : MonoBehaviour
{
    public TextMeshProUGUI output;
    public static bool change = false;

    // Start is called before the first frame update
    public void HandleInputData(int val)
    {
        if (val == 0){
            output.text = "Arrows";
            change = false;
        }

        else {
            output.text = "WASD";
            change = true;
        }
    }
}
