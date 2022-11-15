using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public float runSpeed = 40f;

	//Attempt 2 at doing footsteps sfx audio.
	//AudioSource walkSoundEffect;
	Rigidbody2D rb;
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	bool isWalking = false;
	bool isJumping = false;
	bool m_Grounded;
	//Audio bools
	//bool m_Play = false;
	//bool m_ToggleChange = false; //m stands for music. music_Play, or music_ToggleChange for if you want to toggle music/audio on or off.

	//Attempt 1 at doing audio for walking footsteps.
	[SerializeField] private AudioSource walkSoundEffect;

	void Start () {
		//rb = GetComponent<Rigidbody2D> ();
		walkSoundEffect = gameObject.GetComponent<AudioSource> ();
		m_Grounded = controller.m_Grounded;
	}
	// Update is called once per frame
	void Update () {

		//Jump & Crouch are booleans so that similarly to above, while the player's inputs are constantly checked, the actual enactment of this can occur in FixedUpdate(), saving space & performance/memory.
		//Jump & Crouch input buttons/controls are designated in Unity's Input Manager. To edit this, go to: Edit > Project Settings > Input Manager.
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			isJumping = true;
		}
		if (Input.GetButtonUp("Jump"))
		{
			jump = false;
			isJumping = false;
		}
		//If the Crouch button (whatever it might be) is held down, then you are crouching; The moment you let go of the crouch button, you will get up & stop crouching. This is a constant held-down style crouch input, rather than a toggle.
		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

		//Input.GetAxisRaw("Horizontal") = Gets input based on A & D, Left & Right. 0 = Neutral. -1 = Left (A). 1 = Right (D).

		/*float horizontalMove is a variable for storing the (dynamic) movement speed left or right (Horizontal, -1 or 1) times the runSpeed.
		By putting this in Update(), it will continue to store and update the current input & supposed movement, without actually enacting it every frame.
		Instead, the movement is acted upon using horizontalMove in FixedUpdate().*/
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		//if there is input detected for Horizontal (a.k.a. A/D or Left/Right), then the player isWalking.
		if (Input.GetAxisRaw("Horizontal") != 0)
		//if (rb.velocity.x != 0) //If the Rigidbody2D, rb, is moving a.k.a. velocity of x-axis is not 0, then the player isWalking.
		{
			isWalking = true;
			//m_ToggleChange = true;
			/*if (isJumping == true)
			{
				isWalking = false;
			}*/
			if(jump == true)
			{
				isJumping = true;
			}
		}
		else {
			isWalking = false;
			//Ensure audio doesn’t play more than once
			//m_ToggleChange = false;
		}

		if((isJumping == false) && (isWalking == true) && !walkSoundEffect.isPlaying)
		{
			walkSoundEffect.Play();
		}
		if(isWalking == false){
			walkSoundEffect.Stop();
		}
		if(isJumping == true)
		{
			walkSoundEffect.Stop();
		}
		/*if(m_Grounded == false)
		{
			walkSoundEffect.Stop();
		}*/

		/*if((jump == true) && walkSoundEffect.isPlaying)
		{
			walkSoundEffect.Stop();
		}*/

		/*
		if (isWalking == true && m_ToggleChange == true)
		{
			//if (walkSoundEffect.Play() == true)
			//{
				walkSoundEffect.Play();
			//}
			m_ToggleChange = false;
		}
		if (isWalking == false && m_ToggleChange == false)
		{
			walkSoundEffect.Stop();
			//Ensure audio doesn’t play more than once
			m_ToggleChange = false;
		}
		*/




	}

//FixedUpdate is only called a fixed amount of times per X times. No clue how often that is numerically, but it's not every frame.
	void FixedUpdate ()
	{
		/* Move our character. The function .Move() is from the CharacterController.cs script, which is the CharacterController2D variable, controller. This is what's called to use .Move.
		Hence, controller.Move(float move, bool crouch, bool jump);. The crouch & jump values are simply the variables here, because the values of crouch & jump are defined in Update() based on player input for said buttons.*/
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

		//Time.fixedDeltaTime is the amount of time that has elapsed since this function was last called. By multiplying horizontalMove with Time.fixedDeltaTime, this ensures that the player's movement speed is the same regardless of how many times this function, FixedUpdate(), has been called, across all platforms/computers.
		jump = false;
	}
}
