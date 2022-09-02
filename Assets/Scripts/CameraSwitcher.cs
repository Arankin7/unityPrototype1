using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    public Camera thirdPersonView;
    public Camera firstPersonView;

    public float cameraInput;

    private void Start()
    {
        thirdPersonView.enabled = true;
        firstPersonView.enabled = false;
    }

    public void ChangeView ()
    {
        if (firstPersonView.enabled == true)
        {
            firstPersonView.enabled = false;
            thirdPersonView.enabled = true;
        }
        else if(thirdPersonView.enabled == true)
        {
            firstPersonView.enabled = true;
            thirdPersonView.enabled = false;
        }
    }

    private void LateUpdate()
    {
        cameraInput = Input.GetAxis("Jump");

        if (cameraInput == 1)
        {
            ChangeView();
        }
        

    }

}
