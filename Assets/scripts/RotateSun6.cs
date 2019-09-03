using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class RotateSun6 : MonoBehaviour {

    public int xAngle, yAngle, zAngle;
    public InputField newxAngle;
    public InputField newyAngle;
    public Text grazeAngle; 
    public Text azimuthAngle;
    public Button Submit1;

    /// Update is called every frame, if the MonoBehaviour is enabled.
    void Update()
    {
            grazeAngle.text =  xAngle + " deg";       
            azimuthAngle.text =  yAngle + " deg";       
    }

    public void processRotation()
    {
        xAngle = Convert.ToInt32(newxAngle.text);
        yAngle = Convert.ToInt32(newyAngle.text);
        transform.rotation = Quaternion.Euler (xAngle, yAngle, zAngle);
                print (transform.localEulerAngles.x);
                print (transform.localEulerAngles.y);
                grazeAngle.text =  xAngle + " deg";       
                azimuthAngle.text =  yAngle + " deg";   
    }

}