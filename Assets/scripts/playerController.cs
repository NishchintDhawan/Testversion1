using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

  void Update(){
  var xRotation =Input.GetAxis("Horizontal");
  var zRotation =Input.GetAxis("Vertical");
  
  transform.parent.transform.Rotate(0,xRotation,0);
  transform.parent.transform.Translate(0,0,zRotation);
  
  }
  
}
