using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DipBehavior : MonoBehaviour
{
    public GameObject cupChoco1;
    public GameObject cupChoco2;
    public GameObject sugarChoco1;
    public GameObject sugarChoco2;
    public GameObject waffleChoco1;
    public GameObject waffleChoco2;
    public GameObject cupScoop1;
    public GameObject cupScoop2;
    public GameObject sugarScoop1;
    public GameObject sugarScoop2;
    public GameObject waffleScoop1;
    public GameObject waffleScoop2;
    Renderer cc1r;
    Renderer cc2r;
    Renderer sc1r;
    Renderer sc2r;
    Renderer wc1r;
    Renderer wc2r;
    Renderer cs1r;
    Renderer cs2r;
    Renderer ss1r;
    Renderer ss2r;
    Renderer ws1r;
    Renderer ws2r;

    // Start is called before the first frame update
    void Start()
    {
        cc1r = cupChoco1.GetComponent<Renderer>();
        cc2r = cupChoco2.GetComponent<Renderer>();
        sc1r = sugarChoco1.GetComponent<Renderer>();
        sc2r = sugarChoco2.GetComponent<Renderer>();
        wc1r = waffleChoco1.GetComponent<Renderer>();
        wc2r = waffleChoco2.GetComponent<Renderer>();
        cs1r = cupScoop1.GetComponent<Renderer>();
        cs2r = cupScoop2.GetComponent<Renderer>();
        ss1r = sugarScoop1.GetComponent<Renderer>();
        ss2r = sugarScoop2.GetComponent<Renderer>();
        ws1r = waffleScoop1.GetComponent<Renderer>();
        ws2r = waffleScoop2.GetComponent<Renderer>();
        cc1r.enabled = false;
        cc2r.enabled = false;
        sc1r.enabled = false;
        sc2r.enabled = false;
        wc1r.enabled = false;
        wc2r.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject == cupChoco1 && cs1r.enabled) {
            cc1r.enabled = true;
        } else if (col.gameObject == cupChoco2 && cs2r.enabled == true) {
            cc2r.enabled = true;
        } else if (col.gameObject == sugarChoco1 && ss1r.enabled == true) {
            sc1r.enabled = true;
        } else if (col.gameObject == sugarChoco2 && ss2r.enabled == true) {
            sc2r.enabled = true;
        } else if (col.gameObject == waffleChoco1 && ws1r.enabled == true) {
            wc1r.enabled = true;
        } else if (col.gameObject == waffleChoco2 && ws2r.enabled == true) {
            wc2r.enabled = true;
        }
    }
}
