using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHP : MonoBehaviour
{
	private int hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Enemy"))
		{
			hp -= 10;
			Destroy(other.gameObject);
			if(hp<0)
				Debug.Log("You Lose");
			// Destroy(other.GetComponent<MoveToWayPoints>().hp);
		}
	}
}
