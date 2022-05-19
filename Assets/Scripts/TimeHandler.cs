using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHandler : MonoBehaviour
{
    public static float time = 120f;
    // Start is called before the first frame update
    public void HandleInputData(int val)
    {
        if(val == 0){
            time = 60f;
        }

        if(val == 1){
            time = 120f;
        }

        if(val == 2){
            time = 180f;
        }

        if(val == 3){
            time = 240f;
        }
        
    }

}
