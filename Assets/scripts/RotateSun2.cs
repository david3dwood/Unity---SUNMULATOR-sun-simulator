using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class RotateSun2 : MonoBehaviour {

    public int xAngle, yAngle, zAngle;
    public InputField newxAngle;
    public InputField newyAngle;
    public GameObject textX;
    public GameObject textY;

    void Update () {
        transform.rotation = Quaternion.Euler (xAngle, yAngle, zAngle);
    }

    // entering the new sun angle values x = graze; y = azimuth.  z not used.
    public void InputxAngleX (int newxxAngle) {
        // xAngle = newxAngle.Toint;
        // Print the rotation around the parent's X Axis    
        print (transform.localEulerAngles.x);
        transform.rotation = Quaternion.Euler (xAngle, yAngle, zAngle);
    }
    public void InputyAngleY (int newyAngle) {
        yAngle = newyAngle;
        // Print the rotation around the parent's Y Axis
        print (transform.localEulerAngles.y);
        transform.rotation = Quaternion.Euler (xAngle, yAngle, zAngle);
    }

    // public void processRotation(){
    //     xAngle = X.GetComponent<Text>().text;
    //     textX.GetComponent<Text>.text = "Azimuth     " + xAngle;
    // }




    // public void InputzAngle (int newzAngle) {
    //     zAngle = newzAngle;
    //     // Print the rotation around the parent's Z Axis
    //     print (transform.localEulerAngles.z);
    // }


}