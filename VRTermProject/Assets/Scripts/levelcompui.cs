using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcompui : MonoBehaviour{
    public GameObject comp;
    public void CompleteLevel(){
        comp.SetActive(true);
    }
}
