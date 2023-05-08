using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	private Animator animator;

	/* Start is called before the first frame update */
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")) {
			animator.SetTrigger("IsOpen");
		}
	}

	/* Update is called once per frame */
	void Update()
	{
	}
}
