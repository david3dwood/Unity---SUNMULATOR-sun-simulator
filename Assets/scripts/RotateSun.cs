using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSun : MonoBehaviour{

    public float xAngle, yAngle, zAngle;

    // public Text grazeAngle; 

    // Update is called once per frame

    void Start() {
        // grazeAngle.text =  xAngle + " deg";       
    }

    void Update()
    {
         transform.rotation = Quaternion.Euler(xAngle, yAngle, zAngle);
    }


// entering the new sun angle values x = graze; y = azimuth.  z not used.
    public void InputxAngle(float newxAngle) {
        xAngle = newxAngle;    
        // grazeAngle.text = xAngle + " deg";    
        }
     public void InputyAngle(float newyAngle) {
        yAngle = newyAngle;     
        }
    public void InputzAngle(float newzAngle) {
        zAngle = newzAngle;     
        }
}
