using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    private void Update()
    {
        transform.Translate(transform.forward * 2 * Time.deltaTime);
    }
}
