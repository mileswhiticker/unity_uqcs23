using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveNew : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(5 * Vector3.forward * Time.deltaTime);
        }
    }
}
