using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherControl : MonoBehaviour
{

    public Animator otherCtrl;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            otherCtrl.SetFloat("Blend", 1);
        }
        else
        {
            otherCtrl.SetFloat("Blend", 0);
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            otherCtrl.Play("Action");
        }
    }
}
