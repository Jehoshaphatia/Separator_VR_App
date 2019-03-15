﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

[RequireComponent(typeof(AudioSource))]
public class HowItWorks : MonoBehaviour
{
    //[SteamVR_DefaultAction("Interact With UI")]
    //public SteamVR_Action_Single interactWithUI;


    //public GameObject componentDetailsCanvas; // Assign in inspector
    //public GameObject PerformanceReportCanvas;
    public GameObject componentLabels;
    private bool isShowing;
    AudioSource HowItWorksVoiceOver;

    // Update is called once per frame

    private void Start()
    {
        HowItWorksVoiceOver = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (SteamVR_Input._default.inActions.Teleport.GetStateDown(SteamVR_Input_Sources.Any))
        {
            //Event code goes here
        }
        if (SteamVR_Input._default.inActions.GrabGrip.GetStateUp(SteamVR_Input_Sources.Any))
        {
            //Event code goes here
        }

        //float trigerValue = interactWithUI.GetAxis(SteamVR_Input_Sources.Any);

        //if (trigerValue > 0.0f)
        //{
        //    //Event code goes here
        //}
    }

    public void ShowCanvas()
    {
        HowItWorksVoiceOver.Play(0);
        //Canvas gameobject enable
        isShowing = !isShowing;
        //componentDetailsCanvas.SetActive(isShowing);
        componentLabels.SetActive(isShowing);
    }

    public void HideCanvas()
    {
        //Canvas gameobject enable
        isShowing = !isShowing;
        //componentDetailsCanvas.SetActive(!isShowing);
        componentLabels.SetActive(!isShowing);
    }

  


}
