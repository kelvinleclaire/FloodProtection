using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class LimitPlaceableObjectsToOne : MonoBehaviour
{
    public GameObject WelcomeCanvas;

    private ARPlacementInteractable placementInteractable;

    void Start()
    {
        placementInteractable = this.GetComponent<ARPlacementInteractable>();
        ARObjectPlacedEvent aRObjectPlacedEvent = placementInteractable.onObjectPlaced;
        aRObjectPlacedEvent.AddListener(ObjectPlaced);
    }


    //Sobald die City einmal platziert wurde, wird das Placement-Prefab auf null gesetzt.
    public void ObjectPlaced(ARPlacementInteractable p, GameObject q)
    {
        placementInteractable.placementPrefab = null;
    }
}