using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Text text;

    public void Start()
    {
        text.text = "Choose a Rifle";
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Rifle
        if (Input.GetKeyDown("a"))
        {
            Basic();
        }

        // With Scope and Stabilizer
        if (Input.GetKeyDown("w"))
        {
            OverPowered();
        }

        // With Scope
        if (Input.GetKeyDown("s"))
        {
            Scope();
        }

        // With Stabilizer
        if (Input.GetKeyDown("d"))
        {
            Stabilizer();
        }
    }

    public void Basic()
    {
        IRifle rifle = new BasicRifle();
        text.text = "Basic Rifle -> Accuracy = " + rifle.GetAccuracy();
        Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
    }

    public void Scope()
    {
        IRifle rifle = new BasicRifle();
        rifle = new WithScope(rifle);
        text.text = "Rifle with Scope -> Accuracy = " + rifle.GetAccuracy();
        Debug.Log("+ Scope accuracy: " + rifle.GetAccuracy());
    }

    public void Stabilizer()
    {
        IRifle rifle = new BasicRifle();
        rifle = new WithStabilizer(rifle);
        text.text = "Rifle with Stabilizer -> Accuracy = " + rifle.GetAccuracy();
        Debug.Log("+ Stabilizer accuracy: " + rifle.GetAccuracy());
    }

    public void OverPowered()
    {
        IRifle rifle = new BasicRifle();
        rifle = new WithScope(new WithStabilizer(rifle));
        text.text = "Rifle with Scope and Stabilizer -> Accuracy = " + rifle.GetAccuracy();
        Debug.Log("Fancy accuracy: " + rifle.GetAccuracy());
    }
}
