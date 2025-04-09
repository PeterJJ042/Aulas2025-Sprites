using UnityEngine;

public class movimentacao : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void Update()
    {
        float eixo_h = Input.GetAxis("Horizontal");
        animator.SetFloat("eixo_h", eixo_h);
        if(eixo_h < 0)
        {
            animator.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else if(eixo_h > 0)
        {
            animator.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
