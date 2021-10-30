using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
            Debug.Log("within onclick of destroy cards");
            GameObject originalGameObject = GameObject.Find("PlayerArea");
            GameObject child1 = originalGameObject.transform.GetChild(0).gameObject;
            GameObject child2 = originalGameObject.transform.GetChild(1).gameObject;
            GameObject child3 = originalGameObject.transform.GetChild(2).gameObject;
            GameObject child4 = originalGameObject.transform.GetChild(3).gameObject;
            GameObject child5 = originalGameObject.transform.GetChild(4).gameObject;

            Destroy(child1);
            Destroy(child2);
            Destroy(child3);
            Destroy(child4);
            Destroy(child5);
    }
}
