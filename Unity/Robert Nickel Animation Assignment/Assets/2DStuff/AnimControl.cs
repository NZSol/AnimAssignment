using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour {

    public Animator charCtrl;
    

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
        {
            charCtrl.SetFloat("Blend", 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            charCtrl.SetFloat("Blend", -1);
        }
        else
        {
            charCtrl.SetFloat("Blend", 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            charCtrl.Play("Action");
        }
	}
}
