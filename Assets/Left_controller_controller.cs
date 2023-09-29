using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class Left_controller_controller : MonoBehaviour
{


    [SerializeField]
    GameObject cyllinder_bulletprefab;
    ActionBasedController controller;
    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += ontriggerprass;

    }

    void ontriggerprass(InputAction.CallbackContext context)
    {
        Instantiate(cyllinder_bulletprefab,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
