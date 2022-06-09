using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHandler : MonoBehaviour
{
    public static float time = 10f;
    // Start is called before the first frame update
    public void HandleInputData(int val)
    {
        if(val == 0){
            time = 20f;
        }

        if(val == 1){
            time = 15f;
        }

        if(val == 2){
            time = 10f;
        }

        if(val == 3){
            time = 5f;
        }
        
    }

}
