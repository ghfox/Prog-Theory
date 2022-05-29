using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{

    private Camera GameCamera;

    // Start is called before the first frame update
    void Start()
    {
       GameCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var unit = hit.collider.GetComponentInParent<FuseObject>();
                if (unit != null)
                    unit.OnClick();
            }
        }
    }
}
