using UnityEngine;
using System.Collections;

public class CharacterIdle : MonoBehaviour {

	public  float y = 0.0f;
   	public float gravity = 0.0f;     // 중력느낌용
   	public int direction = 0;       // 0:정지상태, 1:점프중, 2:다운중
    // 설정값
    public float jump_speed = 0.1f;  // 점프속도
    public float jump_accell = 0.01f; // 점프가속
    public float y_base = 0.0f;      // 캐릭터가 서있는 기준점
	
	
	// Use this for initialization
	void Start()
    {
        y = y_base;
        DoJump();
    }
    void Update()
    {
        JumpProcess();
   
        // y값을 gameObject에 적용하세요.
        Vector3 pos = gameObject.transform.position;
        pos.y = y;
        gameObject.transform.position = pos;
    }
    void DoJump()
    {
        direction = 1;
        gravity = jump_speed;
			
		}
    
    void JumpProcess()
    {
        switch (direction)
        {
            case 0: // 2단 점프시 처리
            {
                if (y > y_base)
                {
                    if (y >= jump_accell)
                    {
                        //y -= jump_accell;
                        y -= gravity;
                    }
                    else
                    {
                        y = y_base;
                    }
                }
                break;
            }
            case 1: // up
            {
                y += gravity;
                if (gravity <= 0.0f)
                {
                    direction = 2;
                }
                else
                {
                    gravity -= jump_accell;
                }
                break;
            }
 
            case 2: // down
            {
                y -= gravity;
                if (y > y_base)
                {
                    gravity += jump_accell;
                }
                else
                {
                    direction = 1;
                    y = y_base;
                }
                break;
            }
        }
 
    }
 
}
