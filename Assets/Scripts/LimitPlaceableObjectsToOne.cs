using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
using System;
 
public class LimitPlaceableObjectsToOne : MonoBehaviour
{

    private ARPlacementInteractable placementInteractable;

    void Start()
    {
        placementInteractable = this.GetComponent<ARPlacementInteractable>();
        ARObjectPlacedEvent aRObjectPlacedEvent = placementInteractable.onObjectPlaced;
        aRObjectPlacedEvent.AddListener(ObjectPlaced);
    }
 
 
    public void ObjectPlaced(ARPlacementInteractable p, GameObject q)
    {
        placementInteractable.placementPrefab = null;
    }
}