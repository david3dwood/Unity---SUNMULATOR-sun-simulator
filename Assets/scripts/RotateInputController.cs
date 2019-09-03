using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateInputController : MonoBehaviour {

    public Vector3 currentRotation;

 //   public Vector3 anglesToRotate;

    // Use this for initialization
    void Start () {
        currentRotation = new Vector3 (currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
//        anglesToRotate = new Vector3 (anglesToRotate.x % 360f, anglesToRotate.y % 360f, anglesToRotate.z % 360f);
        this.transform.eulerAngles = currentRotation;
    }

    // Update is called once per frame
    void Update () {
//        currentRotation = currentRotation + anglesToRotate * Time.deltaTime;
        currentRotation = new Vector3 (currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
        this.transform.eulerAngles = currentRotation;
    }
}