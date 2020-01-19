using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virt_btn_anim : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public Animator pizzaAnim;

    // Start is called before the first frame update
    void Start() {
        vbBtnObj = GameObject.Find("pizzaButton");
    	vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    	pizzaAnim.GetComponent<Animator>();
    }

    public void OnButtonPressed (VirtualButtonBehaviour vb) {
    	pizzaAnim.Play("translate_pizza");
    	Debug.Log("btn pressed");
    }

    public void OnButtonReleased (VirtualButtonBehaviour vb) {
    	pizzaAnim.Play("none");
    	Debug.Log("btn released");	
    }

    // Update is called once per frame
    void Update() {
        
    }
}
