using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LockRotation : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
  {
    transform.rotation = Quaternion.identity;
	}
}
