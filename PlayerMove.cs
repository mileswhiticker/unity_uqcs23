using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public Rigidbody rigidBody = null;
	
    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		// WASD controls
		
		if (Input.GetAxis("Vertical") > 0)
        {
            this.transform.Translate(5 * Vector3.forward * Time.deltaTime);
        }
		if (Input.GetAxis("Vertical") < 0)
        {
            this.transform.Translate(5 * -Vector3.forward * Time.deltaTime);
        }
		if (Input.GetAxis("Horizontal") < 0)
        {
            this.transform.Rotate(new Vector3(0, -140, 0) * Time.deltaTime);
        }
		if (Input.GetAxis("Horizontal") > 0)
        {
            this.transform.Rotate(new Vector3(0, 140, 0) * Time.deltaTime);
        }
		
		// Jumping
		
		if (Input.GetAxis("Jump") != 0 && this.rigidBody.velocity.y == 0)
        {
            this.rigidBody.AddForce(Vector3.up * 5.0f, ForceMode.Impulse);
        }
    }
}
