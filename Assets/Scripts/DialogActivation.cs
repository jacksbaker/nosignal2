using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogActivation : MonoBehaviour
{
    public GameObject dialogManager;
    public GameObject text;
    public GameObject continueText;


    // Start is called before the first frame update
    void Start()
    {
        dialogManager.SetActive(false);
        text.SetActive(false);
        continueText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            dialogManager.SetActive(true);
            text.SetActive(true);
            continueText.SetActive(true);
        }
    }
}
