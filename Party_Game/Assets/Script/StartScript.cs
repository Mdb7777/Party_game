using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    Text startText;
    // Start is called before the first frame update
    void Start()
    {
        startText = gameObject.GetComponent<Text>();
        startText.text = "Are you Ready?";
        Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartGame());
    }

    public IEnumerator StartGame()
    {
        yield return new WaitForSeconds(2f);
        startText.text = "Go!";

    }
}
