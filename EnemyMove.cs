using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	public float distMoved = 0;
	public float moveRate = 1;
	public int moveDir = 1;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float moveThisTurn = moveDir * moveRate * Time.deltaTime;
		this.transform.position = this.transform.position + new Vector3(moveThisTurn, 0, 0);
		distMoved += moveThisTurn;
		
		if(moveDir > 0)
		{
			if(distMoved > 5)
			{
				moveDir = -1;
			}
		}
		else
		{
			if(distMoved < -5)
			{
				moveDir = 1;
			}
		}
    }
}
