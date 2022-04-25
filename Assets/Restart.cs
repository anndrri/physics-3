using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject ball;
    public Vector3 ballPos;
    public float timer;
    public bool swtch;
    public GameObject ballCurr;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2;
        ballPos = ball.transform.position;
    }

    // Update is called once per frame
    public void Update()
    {
        if (!swtch && ballCurr != null)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0 && ballCurr != null)
        {
            swtch = true;
            ballCurr.transform.position = ballPos;
        }
        if (swtch)
        {
            timer += Time.deltaTime * 3;
        }
        if (timer >= 2)
        {
            swtch = false;
            ballCurr = null;
        }
    }
    public void OnCollisionStay(Collision col)
    {
        Debug.Log(col.gameObject);
        if (col.gameObject.layer == 3)
        {
            ballCurr = col.gameObject;
        }
    }
}
