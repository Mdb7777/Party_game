using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private float speed = 5.0f;
	public GameObject character;

	AudioSource audioSource;

	Text winText;

	public AudioClip winSound;
	public AudioClip loseSound;

	void Start()
    {
		winText = gameObject.GetComponent<Text>();
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}

	
}
