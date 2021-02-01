using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 0f;
    Text timerText;

    public AudioClip loseSound;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartTimer());
    }

    public IEnumerator StartTimer()
    {
        timerText.text = "Timer: " + Mathf.Round(timer);
        yield return new WaitForSeconds(4f);
        timer += Time.deltaTime;
        
    }
}
