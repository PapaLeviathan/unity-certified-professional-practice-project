using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    public enum PurchaseType
    {
        RemoveAds,
        Coin100,
        Coin500
    }
    public PurchaseType _purchaseType;

    public void ClickPurchaseButton()
    {
        switch (_purchaseType)
        {
            case PurchaseType.RemoveAds:
                IAPManager.instance.BuyRemoveAds();
                break;
            case PurchaseType.Coin100:
                IAPManager.instance.BuyCoin100();
                break;
            case PurchaseType.Coin500:
                IAPManager.instance.BuyCoin500();
                break;
        }
    }

}