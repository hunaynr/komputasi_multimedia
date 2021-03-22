using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipping : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.eulerAngles.y == 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, 180, 0);

            }
        }
        else if (player.transform.eulerAngles.y == 180)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, -180, 0);

            }
        }
    }
}
