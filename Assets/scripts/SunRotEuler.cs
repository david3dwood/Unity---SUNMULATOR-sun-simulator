using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunRotEuler : MonoBehaviour {

    public InputField X;
    public InputField Y;

    public Text rotDegreesx;
    public Text rotDegreesy;

    public float yRotation = 12.0F;
    public float xRotation = 77.0F;

    public void SubmitButtonClick () {
        float xrotation  = float.Parse(X.text);
        float yrotation  = float.Parse(Y.text);
        // xRotation = InputField X;
        // yRotation = InputField Y;

        this.transform.eulerAngles = new Vector3 (xRotation, yRotation, 0);

        rotDegreesx.text = "Rotation Degrees" + xRotation.ToString ();
        rotDegreesy.text = "Rotation Degrees" + yRotation.ToString ();

    }

    // void Example () {
    //     print (transform.eulerAngles.x);
    //     print (transform.eulerAngles.y);
    //     print (transform.eulerAngles.z);
    // }
}