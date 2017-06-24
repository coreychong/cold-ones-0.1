using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections; //contains raycast??
using Immerseum.VRSimulator;
public class Pickup : MonoBehaviour
{

    //Purpose: event trigger for picking up beverages 
    //Trigger: On primary trigger pressed and hold, grab the object
    //Release: Let go of object
    /*
     * Maybe implement some sort of raycast 
     * 
     */
    void OnEnable()
    {
        EventManager.OnPrimaryTriggerActivation += EventManager_OnPrimaryTriggerActivation;
    }

    void onDisable()
    {
        EventManager.OnPrimaryTriggerActivation -= EventManager_OnPrimaryTriggerActivation;
    }
    private void EventManager_OnPrimaryTriggerActivation(InputAction inputAction)
    {
        Debug.Log("something is happening"); 
        inputAction = InputActionManager.getInputAction("togglePrimaryTrigger");
        inputAction.pressedKeyList.Add(KeyCode.Space);
        inputAction.deregisterAction();
        inputAction.registerAction();
    }
}