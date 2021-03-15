using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level: MonoBehaviour{
    private const float Pipe_width=7.8f;
    private const float Pipe_height=3.75f;

    private void Start(){
        CreatePipe(50f,0f);
        CreatePipe(50f,20f);
    }

    private void CreatePipe(float height, float xPosition){
        //fixam varful conductei
        Transform pipeHead= Instantiate(GameAssets.getInstance().pfPipeHead);
        pipeHead =  new Vector3(xPosition, height - PipeHeadHeight * .5f);

        //fixam corpul conductei
        Transform pipeBody= Instantiate(GameAssets.getInstance().pfPipeBody);
        pipeBody.position =  new Vector3(xPosition, 0f);

        SpriteRenderer pipeBodyBoxCollider = pipeBody.GetComponent<SpriteRenderer>();
        pipeBodySpriteRenderer.size = new Vector2(Pipe_width,height);

        BoxCollider2D  pipeBodyBoxCollider = pipeBody.GetComponent<BoxCollider2D>();
        pipeBodyBoxCollider.size = new Vector2(Pipe_width,height);
        pipeBodyBoxCollider.offset = new vector2(0f,)

    }
}