using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleInteractor : MonoBehaviour
{
    private XRRayInteractor interactor;
    private XRInteractorLineVisual lineVisual;
    private LineRenderer lineRenderer;

    private void Start()
    {
        interactor = GetComponent<XRRayInteractor>();

        lineVisual = GetComponent<XRInteractorLineVisual>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        lineRenderer.enabled = !interactor.isSelectActive;
        lineVisual.enabled = !interactor.isSelectActive;
    }
}
