using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipLoadText : MonoBehaviour
{
    public static float shipload;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var load = Mathf.Floor(shipload / 3);
        GetComponent<TextMeshProUGUI>().text = load.ToString() + " lb";
        if (load > 1) { GetComponent<TextMeshProUGUI>().text += "s"; }
    }
}
