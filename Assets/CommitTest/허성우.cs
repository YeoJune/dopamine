using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    [Header("基础设置")]
    public float moveSpeed = 5f;
    
    [Header("组件")]
    private Animator anim;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        // 自动获取组件
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        // 如果没有Animator，添加一个
        if (anim == null)
            Debug.LogWarning("建议添加Animator组件来控制动画");
    }
    
    void Update()
    {
        // 获取WASD输入
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        // 移动角色
        Vector2 movement = new Vector2(moveX, moveY).normalized;
        transform.position += (Vector3)movement * moveSpeed * Time.deltaTime;
        
        // 控制动画
        ControlAnimation(moveX, moveY);
        
        // 控制朝向
        ControlFacingDirection(moveX);
    }
    
    void ControlAnimation(float moveX, float moveY)
    {
        if (anim == null) return;
        
        // 判断是否有移动输入
        bool isMoving = Mathf.Abs(moveX) > 0.1f || Mathf.Abs(moveY) > 0.1f;
        
        // 更新动画参数
        anim.SetFloat("Speed", isMoving ? 1f : 0f);
    }
    
    void ControlFacingDirection(float moveX)
    {
        if (spriteRenderer == null) return;
        
        // 根据水平输入翻转角色
        if (moveX > 0.1f)  // 向右移动
        {
            spriteRenderer.flipX = false;
        }
        else if (moveX < -0.1f)  // 向左移动
        {
            spriteRenderer.flipX = true;
        }
        // 如果没有水平输入，保持当前朝向
    }
}