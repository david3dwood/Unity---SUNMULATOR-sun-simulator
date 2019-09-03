//   set 2 layers = Ground and MoveableObject  and set objects to these layers before running
//   then use right mouse button to click and move objects
//   Also create a mouse position on ground target object too

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Move_Drop_06 : MonoBehaviour {
    public bool moveableObjectGrabbed = false;

    Ray moRay;
    public Transform moTransform;
    public LayerMask whatIsMovableObject;
    RaycastHit moHit;

    public LayerMask whatIsGround;
    public Transform ground;
    RaycastHit groundHit;

    public Transform mousePosMarker;
    RaycastHit mousePosHit;
    public float moYOffsetFromGround = 3f;
    public float mousePosYOffsetFromGround = 0.2f;
    public Vector3 mousePosRelToGround;

    // Start is called before the first frame update
    void Start () {
        moHit = new RaycastHit ();
        groundHit = new RaycastHit ();
        mousePosMarker.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update () {
        moRay = Camera.main.ScreenPointToRay (Input.mousePosition);

        if (Input.GetMouseButtonDown (1)) {
            FindAndGrabMoveableObject ();
        }

        if (Input.GetMouseButtonUp (1)) {
            DropMoveableObject ();
        }

        moveableObjectGrabbed = moTransform != null;
        mousePosMarker.gameObject.SetActive (moveableObjectGrabbed);

        if (moveableObjectGrabbed) //  *************************
        {
            TraceMousePosRelativeToGround ();
        }
    }

    void FindAndGrabMoveableObject () {
        if (Physics.Raycast (
                moRay,
                out moHit,
                Mathf.Infinity,
                whatIsMovableObject)) {
            moTransform = moHit.transform;
            moTransform.GetComponent<Rigidbody> ().isKinematic = true;
            FindGroundBelowMoveableObject ();
        }
    }

    void FindGroundBelowMoveableObject () {
        if (Physics.Raycast (
                moTransform.position,
                Vector3.down,
                out groundHit,
                Mathf.Infinity,
                whatIsGround)) {
            ground = groundHit.transform;
        }
    }

    void TraceMousePosRelativeToGround () {
        if (Physics.Raycast (
                moRay,
                out mousePosHit,
                Mathf.Infinity,
                whatIsGround)) {
            mousePosRelToGround = mousePosHit.point;
            moTransform.position = new Vector3 (
                mousePosRelToGround.x,
                mousePosRelToGround.y + moYOffsetFromGround,
                mousePosRelToGround.z);
            mousePosMarker.position = new Vector3 (
                mousePosRelToGround.x,
                mousePosRelToGround.y + mousePosYOffsetFromGround,
                mousePosRelToGround.z);
        }
    }

    void DropMoveableObject () {
        if (moTransform != null)
            moTransform.GetComponent<Rigidbody> ().isKinematic = false;
        moTransform = null;
        ground = null;
    }

}