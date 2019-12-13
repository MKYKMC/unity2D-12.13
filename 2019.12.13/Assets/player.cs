using UnityEngine;

public class player : MonoBehaviour {
    #region 欄位
	
	[Header("移動速度"),Range(0,2)]
	public float speed=1.5f;
	
	[Header("血量"),Range(0,100)]
	public float blood=100f;

	public Animator ani;
	public Rigidbody2D r2d;
    
	#endregion
	
	}
