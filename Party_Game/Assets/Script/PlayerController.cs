using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private float speed = 5.0f;
	public GameObject character;

	AudioSource audioSource;

	public Text textObject;

	Text winText;

	public int maxScore = 10;

	public int score { get { return currentScore; } }
	int currentScore;

	public AudioClip winSound;

	void Start()
    {
		audioSource = GetComponent<AudioSource>();

		currentScore = 0;
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

	public void ChangeScore(int amount)
	{
		currentScore = Mathf.Clamp(currentScore + amount, 0, maxScore);
		Debug.Log(currentScore);

		textObject.text = "You Win!";
	}

	public void PlaySound(AudioClip clip)
	{
		audioSource.PlayOneShot(winSound);
	}
}
