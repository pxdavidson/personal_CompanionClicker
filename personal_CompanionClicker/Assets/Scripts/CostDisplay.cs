using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostDisplay : MonoBehaviour
{
    // Variables
    int cost;
    Text text;

    // Cache
    CompanionManager companionManager;
    ItemManager itemManager;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        SetParentScript();
    }

    private void SetParentScript()
    {
        companionManager = GetComponentInParent<CompanionManager>();
        if (!companionManager)
        {
            itemManager = GetComponentInParent<ItemManager>();
            cost = itemManager.GetCost();
        }
        else
        {
            cost = companionManager.GetCost();
        }
        UpdateText();
    }

    private void UpdateText()
    {
        text.text = cost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
