using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeScript : Photon.MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player" || collision.tag == "localPlayer")
		{
			this.photonView.RPC("setDied", PhotonTargets.MasterClient);
		}
	}


	[PunRPC]
	public void setDied()
	{
		PhotonNetwork.Destroy(gameObject);
	}
}