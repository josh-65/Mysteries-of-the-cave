using UnityEngine; 
using System.Collections;

public class skyMove : MonoBehaviour
{
    float target;
	void Start() 
	{

	}

	void Update()
	{
        target += Time.deltaTime / 125;

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, target), 0.05f);

	}
}