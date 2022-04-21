using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belts : MonoBehaviour
{

    public float speed;

    public List<GameObject> onBelt;

    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= onBelt.Count -1; i++)
        {
            onBelt[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onBelt.Add(collision.gameObject);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        onBelt.Remove(collision.gameObject);
    }
}
