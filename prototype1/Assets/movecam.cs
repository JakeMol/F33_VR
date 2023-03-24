using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecam : MonoBehaviour
{
    public GameObject[] wayPoints; 
    private int index = 0;

    private float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, wayPoints[index].transform.position);

        if (distance < 0.5f)
        {
            index++;
        }
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[index].transform.position, step);
    }
}
