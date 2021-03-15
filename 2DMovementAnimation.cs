using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: Behavior{
    public CharacterController2D controller;
    public float runSpeed=40f;
    float horizontalMove=0f;
    bool jump=false;
    bool crouch=false;

//per fiecare frame
    void Update(){
        horizontalMove=Input.GetAxisRaw("Horizontal")*runSpeed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.getButtonDown("Jump")){
            jump = true; 
            animator.SetBool("ItsJumping",true);
        }

        if(Input.getButtonDown("Crouch")){
            crouch = true;
        }else if(Input.getButtonUp("Crouch")){
            crouch = false;
        }
    }

    public void OnLanding(){
        animator.SetBool("ItsJumping",false);
    }

    public void OnCrouching(bool isCrouching){
        animator.SetBool("IsCrouching",isCrouching);
    }
//move character
    void FixedUpdate(){
        controller.Move(horizontalMove * TIME.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}