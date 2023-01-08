using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] InputAction Mouse;
    [SerializeField] InputAction Interaction;
    [SerializeField] LayerMask interactLayer;
    Vector2 mousePositionInput;
    Camera myCamera;

    private void Awake()
    {
        Interaction.performed += Interact;
    }

    private void OnEnable()
    {
        Mouse.Enable();
        Interaction.Enable();
    }

    private void OnDisable()
    {
        Mouse.Disable();
        Interaction.Disable();
    }

    private void Update()
    {
        mousePositionInput = Mouse.ReadValue<Vector2>();
    }

    void Interact(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            RaycastHit hit;
            Ray ray = myCamera.ScreenPointToRay(mousePositionInput);
            if (Physics.Raycast(ray, out hit, interactLayer))
            {
                if (hit.transform.tag == "Interactable")
                {
                    if (!hit.transform.GetChild(0).gameObject.activeInHierarchy)
                        return;
                    Interactables temp = hit.transform.GetComponent<Interactables>();
                    temp.DoTask();
                }
            }
        }
    }
}
