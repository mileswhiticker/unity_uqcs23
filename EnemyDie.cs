using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
    {
		Bullet hitBullet = other.gameObject.GetComponent<Bullet>();
		Debug.Log(other);
		Debug.Log(other.gameObject);
		if(hitBullet != null)
		{
			Object.Destroy(this);
		}
		Object.Destroy(this);
    }
}
