using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendshipBracelet : MonoBehaviour
{
    // Variables
    [SerializeField] int upgradeCost;
    [SerializeField] int braceletBoost = 1;
    bool purchased = false;

    // Start is called before the first frame update
    void Start()
    {

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
        if (loveCredit >= upgradeCost)
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
        FindObjectOfType<ShopManager>().DebitScore(upgradeCost);
        purchased = true;
        GetComponent<Image>().color = new Color32(100, 100, 100, 100);
        ApplyUpgrade();
    }

    // Applies the upgrade
    private void ApplyUpgrade()
    {
        FindObjectOfType<AutoClickManager>().ActivateAutoClicker(braceletBoost);
    }
}
