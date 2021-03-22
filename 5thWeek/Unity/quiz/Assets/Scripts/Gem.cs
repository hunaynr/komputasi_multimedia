using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            // print("Gems Picked Up");
            Destroy(gameObject);
            GemScore.countGem += 1;
        }
    }
}
