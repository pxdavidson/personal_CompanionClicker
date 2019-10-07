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
    ItemManager itemManager;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        ObtainCostFromParent();
    }

    private void ObtainCostFromParent()
    {
        itemManager = GetComponentInParent<ItemManager>();
        cost = itemManager.GetCost();
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
