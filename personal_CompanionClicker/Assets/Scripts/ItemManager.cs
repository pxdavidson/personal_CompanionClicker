using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    // Variables
    [SerializeField] int cost;
    [SerializeField] int autoClickValue = 1;
    [SerializeField] int clickValue = 1;
    [SerializeField] int companionValue = 10;
    [SerializeField] int companionMultiplier = 0;
    bool purchased = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Process benefit for the friendship bracelet
    public void AdjustAutoClicks()
    {
        if (!purchased)
        {
            var loveCredit = FindObjectOfType<ScoreManager>().GetScore();
            if (loveCredit >= cost)
            {
                Purchase();
                FindObjectOfType<AutoClickManager>().SetAutoClickValue(autoClickValue);
            }
            else
            {
                // Do nothing
            }
        }
        else
        {
            // Do nothing
        }
    }

    // Process benefit for the special scrunchie
    public void AdjustClicks()
    {
        if (!purchased)
        {
            var loveCredit = FindObjectOfType<ScoreManager>().GetScore();
            if (loveCredit >= cost)
            {
                Purchase();
                FindObjectOfType<ClickerManager>().SetClickerValue(clickValue);
            }
            else
            {
                // Do nothing
            }
        }
        else
        {
            // Do nothing
        }
    }

    // Process benefit for the special scrunchie
    public void AdjustCompanionMultiplier()
    {
        if (!purchased)
        {
            var loveCredit = FindObjectOfType<ScoreManager>().GetScore();
            if (loveCredit >= cost)
            {
                Purchase();
                FindObjectOfType<AutoClickManager>().ChangeCompanionMultiplier(clickValue);
            }
            else
            {
                // Do nothing
            }
        }
        else
        {
            // Do nothing
        }
    }

    // Process benefit for the friendship bracelet
    public void Companion()
    {
        if (!purchased)
        {
            var loveCredit = FindObjectOfType<ScoreManager>().GetScore();
            if (loveCredit >= cost)
            {
                Purchase();
                FindObjectOfType<AutoClickManager>().ChangeCompanionModifier(companionValue);
            }
            else
            {
                // Do nothing
            }
        }
        else
        {
            // Do nothing
        }
    }

    // Makes the purchase
    private void Purchase()
    {
        FindObjectOfType<ShopManager>().DebitScore(cost);
        purchased = true;
        GetComponent<Image>().color = new Color32(100, 100, 100, 100);
    }

    // Returns the cost int
    public int GetCost()
    {
        return cost;
    }
}
