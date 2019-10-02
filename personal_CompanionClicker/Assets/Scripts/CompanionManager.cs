using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompanionManager : MonoBehaviour
{
    // Variables
    [SerializeField] int companionValue = 10;
    [SerializeField] int companionCost = 50;
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

    // Checks if the companion has already been purcased
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

    private void CheckBalance()
    {
        var loveCredit = FindObjectOfType<ScoreManager>().GetScore();
        if (loveCredit >= companionCost)
        {
            Purchase();
        }
        else
        {
            // Do nothing
        }
    }

    private void Purchase()
    {
        shopManager.DebitScore(companionCost);
        autoClickManager.ChangeCompanionModifier(companionValue);
        GetComponent<Image>().color = new Color32(100, 100, 100, 100);
        purchased = true;
    }
}
