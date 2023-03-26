using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CompassBAr : MonoBehaviour
{
    public RectTransform compassBarTransform;
    public RectTransform objectiveMarkerTransform;
    public Transform cameraObjectTransform;
    public Transform objectiveObjectTransform;

    void Update()
    {
        SetMarkerPosition(objectiveMarkerTransform, objectiveObjectTransform.position);
    }

    void SetMarkerPosition(RectTransform markerTransform, Vector3 worldposition)
    {
        Vector3 directionToTarget = worldposition - cameraObjectTransform.position;
        float angle = Vector2.SignedAngle(new Vector2(directionToTarget.x, directionToTarget.z), new Vector2(cameraObjectTransform.forward.x, cameraObjectTransform.forward.z));

        float horizontalFOV = Camera.main.fieldOfView * Camera.main.aspect; // Get the horizontal field of view
        float compassPositionX = Mathf.Clamp(angle / horizontalFOV, -1, 1);

        markerTransform.anchoredPosition = new Vector2(compassBarTransform.rect.width / 2 * compassPositionX, 0);
    }


}
