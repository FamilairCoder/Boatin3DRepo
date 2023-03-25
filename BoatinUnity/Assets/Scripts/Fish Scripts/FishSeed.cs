using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSeed : MonoBehaviour
{
    public GameObject player, smallfish, medfish, bigfish;
    public float dist;
    public List<GameObject> fishlist;

    private bool did = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 300)
        {
            if (did)
            {
                foreach (var a in fishlist) { a.gameObject.SetActive(true); }
            }

            if (!did)
            {
                var amount = Random.Range(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    var posx = transform.position.x + Random.Range(-dist, dist);
                    var posz = transform.position.z + Random.Range(-dist, dist);
                    var chance = Random.Range(1, 4);
                    if (chance == 1) { var a = Instantiate(smallfish, new(posx, 0, posz), Quaternion.identity); fishlist.Add(a); }
                    if (chance == 2) { var a = Instantiate(medfish, new(posx, 0, posz), Quaternion.identity); fishlist.Add(a); }
                    if (chance == 3) { var a = Instantiate(bigfish, new(posx, 0, posz), Quaternion.identity); fishlist.Add(a); }
                    
                }
                did = true;
            }

        }
        if (Vector3.Distance(transform.position, player.transform.position) > 300)
        {
            foreach(var a in fishlist) { a.gameObject.SetActive(false); }
        }
    }
}
