using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompanionManager : MonoBehaviour
{
    // Variables
    [SerializeField] int companionValue = 10;
    [SerializeField] int cost = 50;
    bool purchased = false;
    
    // Cache
    AutoClickManager autoClickManager;
    ShopManager shopManager;
        
    // Start is called before the first frame update
    void Start()
    {
        autoClickManager = FindObjectOfType<AutoClickManager>();
        shopManager = FindObjectOfType<ShopManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Checks if the upgrade has already been purcased
    public void CheckAvailable()
    {
        if (!purchased)
        {
            CheckBalance();
        }
        else
        {
            // Do nothing
        }
    }

    // Checks the players balance before proceeding with purchase
    private void CheckBalance()
    {
        var loveCredit = FindObjectOfType<ScoreManager>().GetScore();
        if (loveCredit >= cost)
        {
            Purchase();
        }
        else
        {
            // Do nothing
        }
    }

    // Makes the purchase
    private void Purchase()
    {
        shopManager.DebitScore(cost);
        ApplyUpgrade();
        purchased = true;
    }

    // APplies the upgrade
    private void ApplyUpgrade()
    {
        autoClickManager.ChangeCompanionModifier(companionValue);
        GetComponent<Image>().color = new Color32(100, 100, 100, 100);
    }

    // Returns the cost int
    public int GetCost()
    {
        return cost;
    }
}
