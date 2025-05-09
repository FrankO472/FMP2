using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractManager : MonoBehaviour
{
    public int totalInteracts;
    public int maxInteracts;
    public TMP_Text interactText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        interactText.text = "Sabotage the Objective: " + totalInteracts + "/" + maxInteracts;
    }
}
