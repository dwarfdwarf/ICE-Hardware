using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int scoops;
    public List<string> flavors;
    public GameObject infoPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetOrder() {
        Random rnd = new Random();
        scoops = rnd.Next(1, 2);
        for (int i = 0; i < scoops; ++i) {
            int flavor = rnd.Next(0, 2);
            if (flavor == 0) flavors.Add("MintChoco");
            else if (flavor == 1) flavors.Add("Choco");
            else flavors.Add("Vanilla");
        }
        infoPanel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Number of Scoops: " + scoops.ToString();
    }

    public void SetInactive(GameObject target) {
        target.SetActive(false);
    }
}
