using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Input Keys
public enum InputKeyboard{
    arrows =0, 
    wasd = 1
}
public class MoveWithKeyboardBehavior : AgentBehaviour
{

    public InputKeyboard inputKeyboard;

    private void Start()
    {
    }
    public override Steering GetSteering()
    {
        //if(script.isGhost){
        //    agent.MoveOnStone();

        //}
        //else
        //{
        //    agent.ClearHapticFeedback();
        //    agent.SetCasualBackdriveAssistEnabled(true);
        //}
        Steering steering = new Steering();
            

            if (inputKeyboard == InputKeyboard.arrows)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            steering.linear = new Vector3(horizontal, 0, vertical) * agent.maxAccel;
            steering.linear = this.transform.parent.TransformDirection(Vector3.ClampMagnitude(steering.linear, agent.maxAccel));
        }
        else
        {
            float horizontalAD = Input.GetAxis("HorizontalAD");
            float verticalWS = Input.GetAxis("VerticalWS");

            steering.linear = new Vector3(horizontalAD, 0, verticalWS) * agent.maxAccel;
            steering.linear = this.transform.parent.TransformDirection(Vector3.ClampMagnitude(steering.linear, agent.maxAccel));
        }

        
        return steering;
    }

}
