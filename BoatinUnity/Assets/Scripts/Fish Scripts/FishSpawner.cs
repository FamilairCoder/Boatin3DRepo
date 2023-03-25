using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishseed, player;
    public float dist, amount;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            var posx = Random.Range(-dist, dist);
            var posz = Random.Range(-dist, dist);
            var a = Instantiate(fishseed, new(posx, 0, posz), Quaternion.identity);
            a.GetComponent<FishSeed>().player = player;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
