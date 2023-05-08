using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	private Animator animator;

        private AudioSource pick;
	public static int CoinCount = 0;

        void Start()
        {
		++Coin.CoinCount;
                GameObject CoinSound = GameObject.Find("PickCoin");
                pick = CoinSound.GetComponent<AudioSource>();
        }

        void Update()
        {
                transform.Rotate(0, 0, 2);
        }

	void OnTriggerEnter(Collider other)
	{
                if (other.CompareTag("Player")) {
                        pick.Play();
			Destroy(this.gameObject);
                }
	}

	void OnDestroy()
	{
		--Coin.CoinCount;
		if (Coin.CoinCount <= 0) {
			GameObject Timer = GameObject.Find("LevelTimer");
			Destroy(Timer);

			// TODO: door
			GameObject block0 = GameObject.Find("block0");
			animator = block0.GetComponent<Animator>();
			animator.SetTrigger("Game Over");

			GameObject block1 = GameObject.Find("block1");
			animator = block1.GetComponent<Animator>();
			animator.SetTrigger("Game Over");

			GameObject block2 = GameObject.Find("block2");
			animator = block2.GetComponent<Animator>();
			animator.SetTrigger("Game Over");

			GameObject block3 = GameObject.Find("block3");
			animator = block3.GetComponent<Animator>();
			animator.SetTrigger("Game Over");

		}
	}
}
