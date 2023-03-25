using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    public float speed, scalespeed;
    private float timeleft;
    public bool trail;
    // Start is called before the first frame update
    void Start()
    {
        if (!trail) { transform.localScale = new(Random.Range(1000, 2000), Random.Range(1000, 2000), 1); }
        speed -= Random.Range(1f, 10f);
        timeleft = Random.Range(1, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!trail)
        {
            var posx = transform.position.x;
            var posy = transform.position.y;
            var posz = transform.position.z;
            transform.position = new(posx, posy, posz - speed * Time.deltaTime);
        }
        else
        {
            var posx = transform.localScale.x;
            var posy = transform.localScale.y;
            var posz = transform.localScale.z;
            transform.localScale = new(posx + scalespeed * Time.deltaTime, posy + scalespeed * Time.deltaTime, posz + scalespeed * Time.deltaTime);
            transform.position += -transform.up * speed * Time.deltaTime;
        }
        timeleft -= Time.deltaTime;
        if (timeleft <= 0) { Destroy(gameObject); }
    }
}
