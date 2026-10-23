using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringBackPlayer : MonoBehaviour
{
	public Camera myCamera;
	
	// Clicked Position
	private Transform targetTransform;
	
	// z-Offset, how back you want to be
	private float zOffset = 5f;
	
	void Start()
	{
		// Initial Position
		targetTransform.position = transform.position;
	}
	
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
			GrabClickedObject();
			
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (targetTransform != null)
            {
				Vector3 pos = targetTransform.position;
                pos.z -= targetTransform.forward.z * zOffset;
				
				// Direct Teleport
                transform.position = pos;

            }
        }//if
    }
	
	
	private void GrabClickedObject()
	{
		Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
                   
		if (Physics.Raycast(ray, out hit, 500))
		{
            if (hit.transform.tag == "Monster")
				targetTransform = hit.transform;
        }

    }
}
