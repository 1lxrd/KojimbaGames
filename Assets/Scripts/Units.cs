using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
	public int hp = 100;
	public int damage = 1;

	/*public void Death()
	{

	}*/

	public void DealDamage(object target)
	{
		target.hp -= damage;

		if (target.hp <= 0)
		{
			target.death;
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
