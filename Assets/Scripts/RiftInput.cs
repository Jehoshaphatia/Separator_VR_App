using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class RiftInput : MonoBehaviour {
    [SteamVR_DefaultAction("Interact With UI")]
    public SteamVR_Action_Single interactWithUI;

    
    public GameObject componentDetailsCanvas; // Assign in inspector
    private bool isShowing;
    // Update is called once per frame
    void Update ()
    {
        if (SteamVR_Input._default.inActions.Teleport.GetStateDown(SteamVR_Input_Sources.Any))
        {
            Debug.Log("Teleport Button down");
        }
        if (SteamVR_Input._default.inActions.GrabGrip.GetStateUp(SteamVR_Input_Sources.Any))
        {
            Debug.Log("GrabGrip Button down");
        }

        float trigerValue = interactWithUI.GetAxis(SteamVR_Input_Sources.Any);

        if (trigerValue > 0.0f)
        {
            Debug.Log("Trigger button pulled");
        }
    }

    public void ShowCanvas()
    {
        //Canvas gameobject enable
        isShowing = !isShowing;
        componentDetailsCanvas.SetActive(isShowing);
    }

    public void HideCanvas()
    {
        //Canvas gameobject enable
        isShowing = !isShowing;
        componentDetailsCanvas.SetActive(!isShowing);
    }
}
