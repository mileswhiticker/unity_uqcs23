using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
	public GameObject bulletTemplate = null;
	public float tLeftCanShoot = 1.0f;
	public float shootCooldown = 1.0f;
	public int shotsLeft = 1;
	public UnityEngine.UI.Text uiAmmo = null;
	
    // Start is called before the first frame update
    void Start()
    {
		this.uiAmmo.text = "Ammo left: " + this.shotsLeft;
    }

    // Update is called once per frame
    void Update()
    {
		if(this.tLeftCanShoot > 0)
		{
			this.tLeftCanShoot -= Time.deltaTime;
		}
		if (Input.GetAxis("Fire3") > 0)
        {
            this.Shoot();
        }
		if (Input.GetKeyDown(KeyCode.R))
        {
            this.Reload();
        }
    }
	
	void Shoot()
	{
		if(this.tLeftCanShoot <= 0 && this.shotsLeft > 0)
		{
			this.tLeftCanShoot = this.shootCooldown;
			this.shotsLeft--;
			GameObject newBullet = Object.Instantiate(bulletTemplate, this.transform.position, this.transform.rotation);
			this.uiAmmo.text = "Ammo left: " + this.shotsLeft;
		}
	}
	void Reload()
	{
		this.shotsLeft = 10;
		this.uiAmmo.text = "Ammo left: " + this.shotsLeft;
	}
}
