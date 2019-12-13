using UnityEngine;

public class player : MonoBehaviour {

    public float speedbullet=1000;

    #region 欄位
	
	[Header("移動速度"),Range(-20,20)]
	public float speed=9.4f;
	
	[Header("血量"),Range(0,100)]
	public float blood=100f;
    
	[Header("子彈")]
	public GameObject bullet;
	[Header("音效")]
	public AudioClip source;
    [Header("發射位置")]
	public Transform point;

	private Animator ani;
	private Rigidbody2D r2d;
	private AudioSource boo;
    
	#endregion
	
 private void Start(){
	  
	  ani=GetComponent<Animator>();
      r2d=GetComponent<Rigidbody2D>(); 
	  boo=GetComponent<AudioSource>();   

 }
private void FixedUpdate(){

      Move();
	  shoot();

	}
	
private void Move(){

  float S=Input.GetAxisRaw("Horizontal");
	r2d.AddForce(new Vector2(speed*S,0));
	if(S!=0){
		transform.localScale=new Vector3(S, 1, 1);
	}
	

	}

private void shoot(){
	if( Input.GetMouseButtonDown(0) ){
		boo.PlayOneShot(source);
		GameObject temp=Instantiate( bullet,point.position,Quaternion.identity );
		
		temp.GetComponent<Rigidbody2D> ().AddForce ( new Vector2(speedbullet*transform.localScale.x,80));　

	}

}

}