using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public bool state;
    public float speed;
    public GameObject first;
    public GameObject second;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!state)
        {
            transform.position = Vector3.MoveTowards(transform.position, first.transform.position, Time.deltaTime * speed);
        }
        if (transform.position == first.transform.position)
        {
            state = true;
        }
        if (state)
        {
            transform.position = Vector3.MoveTowards(transform.position, second.transform.position, Time.deltaTime * speed);
        }
        if (transform.position == second.transform.position)
        {
            state = false;
        }
    }
}
