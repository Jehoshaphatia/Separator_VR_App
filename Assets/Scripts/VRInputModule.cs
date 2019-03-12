using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;

public class VRInputModule : BaseInputModule
{
    public Camera m_Camera;
    public SteamVR_Input_Sources m_TargetSource;
    public SteamVR_Action_Boolean m_ClickedAction;

    private GameObject m_CurrentObject = null;
    private PointerEventData m_Data = null;

    protected override void Awake()
    {
        base.Awake();

        m_Data = new PointerEventData(eventSystem);
    }

    public override void Process()
    {
        //Reset data, set camera
        m_Data.Reset();
        m_Data.position = new Vector2(m_Camera.pixelWidth / 2, m_Camera.pixelHeight / 2);

        //Raycast
        eventSystem.RaycastAll(m_Data, m_RaycastResultCache);
        m_Data.pointerCurrentRaycast = FindFirstRaycast(m_RaycastResultCache);
        m_CurrentObject = m_Data.pointerCurrentRaycast.gameObject;

        //clear
        m_RaycastResultCache.Clear();

        //Hover
        HandlePointerExitAndEnter(m_Data, m_CurrentObject);

        //press
        if (m_ClickedAction.GetStateDown(m_TargetSource))
            ProcessPress(m_Data);

        //Released
        if (m_ClickedAction.GetStateUp(m_TargetSource))
            ProcessReleased(m_Data);
        
    }

    public PointerEventData GetData()
    {
        return m_Data;
    }
    private void ProcessPress(PointerEventData data)
    {

    }

    private void ProcessReleased( PointerEventData data)
    {

    }
}
