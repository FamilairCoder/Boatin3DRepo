using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSeed : MonoBehaviour
{
    public GameObject player, fish;
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
                    var scalex = Random.Range(20f, 50f);
                    var scalez = scalex + Random.Range(-10f, 10f);
                    var a = Instantiate(fish, new(posx, 2, posz), Quaternion.identity);
                    fishlist.Add(a);
                    a.transform.localScale = new(scalex, 1, scalez);
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
