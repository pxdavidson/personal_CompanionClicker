using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompanionManager : MonoBehaviour
{
    // Variables
    [SerializeField] int companionValue = 10;
    bool purchased = false;

    // Cache
    AutoClickManager autoClickManager;
        
    // Start is called before the first frame update
    void Start()
    {
        autoClickManager = FindObjectOfType<AutoClickManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Sends the companionValue to the AutoClickManager
    public void Purchase()
    {
        if (!purchased)
        {
            CheckShop();
        }
        else
        {
            // Do nothing
        }
    }

    private void CheckShop()
    {
        autoClickManager.ChangeCompanionModifier(companionValue);
        GetComponent<Image>().color = new Color32(100, 100, 100, 100);
        purchased = true;
    }
}
