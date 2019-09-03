using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSunSliders : MonoBehaviour{

    public float xAngle, yAngle, zAngle;

    public Text grazeAngle; 
    public Text azimuthAngle;

    // Update is called once per frame

    void Start() {

    }

    void Update()
    {
         this.transform.eulerAngles = new Vector3 (xAngle, yAngle, zAngle);
            grazeAngle.text =  xAngle + " deg";       
            azimuthAngle.text =  yAngle + " deg";       
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
