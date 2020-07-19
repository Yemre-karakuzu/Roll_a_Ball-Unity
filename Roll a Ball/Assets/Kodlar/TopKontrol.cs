using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour {

    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public int toplanicakNesneSayisi;
    public Text sayacText;
    public Text OyunBittiText;
    void Start ()
    {
        fizik = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate ()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        
        Vector3 vec = new Vector3(yatay,0,dikey);
        fizik.AddForce(vec*hiz);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Engel")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);//is riggerini degiştirir
            sayac++;
            sayacText.text = "Sayac=" + sayac;
        }
        if (sayac==toplanicakNesneSayisi)
        {
            OyunBittiText.text = "OYUN BİTTİ!";
        }
    }
}
