using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionReply : AgentBehaviour
{

    public bool canReply;
    // Start is called before the first frame update
    void Start()
    {
        canReply = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnCelluloTouchBegan(int key)
    {
        if (canReply)
        {

        }
        base.OnCelluloTouchBegan(key);
    }
}
