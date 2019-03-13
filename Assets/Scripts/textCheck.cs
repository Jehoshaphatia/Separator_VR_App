using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class textCheck : MonoBehaviour
{
    [SteamVR_DefaultAction("Interact With UI")]
    public SteamVR_Action_Single interactWithUI;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TestButton()
    {
        float trigerValue = interactWithUI.GetAxis(SteamVR_Input_Sources.Any);

        if (trigerValue > 0.0f)
        {
            Debug.Log("Trigger button pulled On information button");
        }
    }
}
