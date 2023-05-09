using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DeleteOnGrab : MonoBehaviour
{
    public int goldValue = 100;

    private XRGrabInteractable grabInteractable;
    private GoldTrackerController goldTrackerController;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnGrabbed);
        goldTrackerController = FindObjectOfType<GoldTrackerController>();
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        Destroy(gameObject);
        goldTrackerController.UpdateGold(goldValue);
    }
}
