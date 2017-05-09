using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLvl : MonoBehaviour {

    public string LvlNext;

    void OnCollisionEnter (Collision MyCollision)
    {
        if (MyCollision.gameObject.name == "[CameraRig]")
        {
            Application.LoadLevel(LvlNext);
            
        }
    }
	
}
