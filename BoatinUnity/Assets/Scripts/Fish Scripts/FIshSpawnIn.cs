using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIshSpawnIn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var spr = GetComponent<SpriteRenderer>().color;
        spr = new(spr.r, spr.g, spr.b, spr.a + 2 * Time.deltaTime);
        GetComponent<SpriteRenderer>().color = spr;
    }
}
