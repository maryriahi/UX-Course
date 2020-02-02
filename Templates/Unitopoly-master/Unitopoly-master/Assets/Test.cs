using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public GameObject sample;
    public GameObject rotModel;
    public Vector3 prevRot;

    private int flag;
	// Use this for initialization
	void Start () {

        flag = 0;
	}
	
	// Update is called once per frame
	void Update () {
//Input.GetKey(KeyCode.Space
        
            flag = 1;
        
        if(flag == 1)
        {
            rotFunc();
        }
        prevRot = sample.transform.eulerAngles;
	}
    void rotFunc()
    {
        Vector3 vec = sample.transform.eulerAngles - prevRot;
        Vector3 vec2 = new Vector3(0, vec.y, 0);
        rotModel.transform.Rotate(vec2);
    }
}
