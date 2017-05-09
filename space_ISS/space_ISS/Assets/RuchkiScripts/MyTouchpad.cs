using UnityEngine;
using System.Collections;
using Valve.VR;

public class MyTouchpad : MonoBehaviour
{
    public GameObject player;

    SteamVR_Controller.Device device;
    SteamVR_TrackedObject controller;

    Vector2 touchpad;

    public float sensitivity = 1.5F;
  
    private Vector3 playerPos;

    void Start()
    {
        controller = gameObject.GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input((int)controller.index);
        //If finger is on touchpad
        
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
        {
            //Read the touchpad values
            touchpad = device.GetAxis(EVRButtonId.k_EButton_SteamVR_Touchpad);


          
            if (touchpad.y > 0.3f || touchpad.y < -0.3f)
            {
               
                player.transform.Rotate(touchpad.y * sensitivity, 0, 0);

            }

            // handle rotation via touchpad
            if (touchpad.x > 0.3f || touchpad.x < -0.3f)
            {
                player.transform.Rotate(0, touchpad.x * sensitivity, 0);
            }

          
        }
        if (device.GetPressDown(EVRButtonId.k_EButton_SteamVR_Trigger))
        {
           player.transform.rotation = Quaternion.identity;
            player.transform.localRotation = Quaternion.identity;

        }
    }
}
