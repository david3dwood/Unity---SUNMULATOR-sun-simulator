using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDestroy : MonoBehaviour
{

GameObject[] gameObjects;
  
public void DestroyAllObjects()
 {
      gameObjects = GameObject.FindGameObjectsWithTag ("models");
      for(var i = 0 ; i < gameObjects.Length ; i ++)
     {
         Destroy(gameObjects[i]);
     }
 }


}
