using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    
    private static Slider slider;
    private static int health;
	// Use this for initialization
	void Start () {
        health = 100;
        slider = GetComponent<Slider>();
	}
		
	public static void down(int damage) {
        health -= damage;
        slider.value = health;
    }

}
