using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamScoop : MonoBehaviour
{
    public GameObject cctub;
    public GameObject ctub;
    public GameObject vtub;
    public GameObject scooperScoop;
    public GameObject cupScoop1;
    public GameObject cupScoop2;
    public GameObject sugarScoop1;
    public GameObject sugarScoop2;
    public GameObject waffleScoop1;
    public GameObject waffleScoop2;
    public GameObject blender;
    public GameObject blenderScoop1;
    public GameObject blenderScoop2;
    public GameObject blenderScoop3;
    Renderer cctubr;
    Renderer ctubr;
    Renderer vtubr;
    Renderer ssr;
    Renderer cs1r;
    Renderer cs2r;
    Renderer ss1r;
    Renderer ss2r;
    Renderer ws1r;
    Renderer ws2r;
    Renderer bs1r;
    Renderer bs2r;
    Renderer bs3r;
    bool sscooped = false;
    bool cscooped1 = false;
    bool cscooped2 = false;
    bool sscooped1 = false;
    bool sscooped2 = false;
    bool wscooped1 = false;
    bool wscooped2 = false;
    bool fullblend = false;
    bool bscooped1 = false;
    bool bscooped2 = false;
    bool bscooped3 = false;

    // Start is called before the first frame update
    void Start()
    {
    cctubr = cctub.GetComponent<Renderer>();
    ctubr = ctub.GetComponent<Renderer>();
    vtubr = vtub.GetComponent<Renderer>();
    ssr = scooperScoop.GetComponent<Renderer>();
    cs1r = cupScoop1.GetComponent<Renderer>();
    cs2r = cupScoop2.GetComponent<Renderer>();
    ss1r = sugarScoop1.GetComponent<Renderer>();
    ss2r = sugarScoop2.GetComponent<Renderer>();
    ws1r = waffleScoop1.GetComponent<Renderer>();
    ws2r = waffleScoop2.GetComponent<Renderer>();
    bs1r = blenderScoop1.GetComponent<Renderer>();
    bs2r = blenderScoop2.GetComponent<Renderer>();
    bs3r = blenderScoop3.GetComponent<Renderer>();
    ssr.enabled = false;
    cs1r.enabled = false;
    cs2r.enabled = false;
    ss1r.enabled = false;
    ss2r.enabled = false;
    ws1r.enabled = false;
    ws2r.enabled = false;
    bs1r.enabled = false;
    bs2r.enabled = false;
    bs3r.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col) {
        if (sscooped == false) {
            if (col.gameObject == cctub) {
                sscooped = true;
                ssr.enabled = true;
                ssr.sharedMaterial = cctubr.sharedMaterial;
            } else if (col.gameObject == ctub) {
                sscooped = true;
                ssr.enabled = true;
                ssr.sharedMaterial = ctubr.sharedMaterial;
            } else if (col.gameObject == vtub) {
                sscooped = true;
                ssr.enabled = true;
                ssr.sharedMaterial = vtubr.sharedMaterial;
            }
        } else if (col.gameObject == cupScoop1 && sscooped && !cscooped1) {
            sscooped = false;
            ssr.enabled = false;
            cscooped1 = true;
            cs1r.enabled = true;
            cs1r.sharedMaterial = ssr.sharedMaterial;
        } else if (col.gameObject == cupScoop2 && sscooped && cscooped1 && !cscooped2 ) {
            sscooped = false;
            ssr.enabled = false;
            cscooped2 = true;
            cs2r.enabled = true;
            cs2r.sharedMaterial = ssr.sharedMaterial;
        } else if (col.gameObject == sugarScoop1 && sscooped && !sscooped1 ) {
            sscooped = false;
            ssr.enabled = false;
            sscooped1 = true;
            ss1r.enabled = true;
            ss1r.sharedMaterial = ssr.sharedMaterial;
        } else if (col.gameObject == sugarScoop2 && sscooped && sscooped1 && !sscooped2) {
            sscooped = false;
            ssr.enabled = false;
            sscooped2 = true;
            ss2r.enabled = true;
            ss2r.sharedMaterial = ssr.sharedMaterial;
        } else if (col.gameObject == waffleScoop1 && sscooped && !wscooped1) {
            sscooped = false;
            ssr.enabled = false;
            wscooped1 = true;
            ws1r.enabled = true;
            ws1r.sharedMaterial = ssr.sharedMaterial;
        } else if (col.gameObject == waffleScoop2 && sscooped && wscooped1 && !wscooped2) {
            sscooped = false;
            ssr.enabled = false;
            wscooped2 = true;
            ws2r.enabled = true;
            ws2r.sharedMaterial = ssr.sharedMaterial;
        } else if (col.gameObject == blender && sscooped && !fullblend) {
            if (!bscooped1) {
                sscooped = false;
                ssr.enabled = false;
                bscooped1 = true;
                bs1r.enabled = true;
                bs1r.sharedMaterial = ssr.sharedMaterial;
            } else if (!bscooped2) {
                sscooped = false;
                ssr.enabled = false;
                bscooped2 = true;
                bs2r.enabled = true;
                bs2r.sharedMaterial = ssr.sharedMaterial;
            } else if (!bscooped3) {
                sscooped = false;
                ssr.enabled = false;
                bscooped3 = true;
                bs3r.enabled = true;
                bs3r.sharedMaterial = ssr.sharedMaterial;
                fullblend = true;
            }
        }
    }
}
