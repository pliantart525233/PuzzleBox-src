
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Moving_Platform : MonoBehaviour

{

    [Header("Custom Moving")]

    [SerializeField] private float dirX, moveSpeed = 3f;

    [SerializeField] private float right = 2f;

    [SerializeField] private float left = -2f;

	[SerializeField] private bool moveRight = true;

	// Update is called once per frame

	void Update () {

		// Check if it reached the maximun X position, so it changes the direction

		if (transform.position.x > right)

			moveRight = false;

		if (transform.position.x < left)

			moveRight = true;

		if (moveRight)

			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);

		else

			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

	}

}
