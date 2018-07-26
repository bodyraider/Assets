using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour {

    public Gamekit2D.Damageable boss;
    Slider slider;
	void Start () {
        slider = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        slider.value = boss.CurrentHealth;
	}
}
