using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSushi : MonoBehaviour {

    BoxCollider2D sushiHitbox;

    private void Start()
    {
        sushiHitbox = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray))
            {
                sushiHitbox.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            }
        }
	}
}
