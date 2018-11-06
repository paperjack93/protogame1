using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public LayerMask layerMask;
	public Rigidbody player;
	public float playerMoveStrength = 50f;
	Ray _ray;
	RaycastHit _hit;

    void Start() {
        
    }

    void FixedUpdate() {
    	Vector3 pos = Input.mousePosition;
    	if(Input.touches.Length > 0) pos = Input.GetTouch(0).position;
        _ray = Camera.main.ScreenPointToRay(pos);
        if (!Physics.Raycast(_ray, out _hit, Mathf.Infinity, layerMask)) return;
        player.velocity = (_hit.point - player.position) * playerMoveStrength;
    }
}
