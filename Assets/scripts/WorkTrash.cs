using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkTrash : MonoBehaviour
{
    public GameObject myObjectDrag;
    // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   	void OnTriggerStay(Collider Col) {
	
	 // if (Col.CompareTag("Trashcan"))
        if (Col.tag == "noneed")
     	{
	    	myObjectDrag.SetActive(false);
	
	   }
       
     	
}
}
