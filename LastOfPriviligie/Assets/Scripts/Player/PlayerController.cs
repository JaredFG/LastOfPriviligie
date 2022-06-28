using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player settings")]
    public float speed = 2.5f;
	public float jumpForce = 2.5f;
    public Rigidbody2D _rigidbody;
	public Animator _animator;
    private bool _facingRight = true;
    private bool _isAttacking;
    private Vector2 _movement;
    bool _isGrounded = true;
    public float _rollpower = 5f;
    public bool rolling = true;
    public float timer = 10;
    public bool canRoll =true;
    public bool Normal;
    public bool HasGun;
    [Space]
    [Header("Gun settings")]
    public bool Pistol;
    public bool Shotgun;
    public bool Baston;
    public bool Llave;
    public bool Pan;
    public bool Machete;
    public bool MiniGun;
    public bool Rocket;
    public bool Crossbow;
    public bool Katana;
    public bool Extint;

    
    inventory inventory ;
    [Header("Weapons Hurtboxes-shootpoint")]
    public GameObject pistolShootpoint;
    public GameObject shotgunShootpoint;
    public GameObject minigunShootpoint;
    public GameObject rocketShootpoint;
    public GameObject crossbowShootpoint;
    public GameObject bastonHurtbox;
    public GameObject llaveHurtbox;
    public GameObject panHurtbox;
    public GameObject macheteHurtbox;
    public GameObject extintHurtbox;
    public GameObject katanaHurtbox;
    

    void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();
        inventory = GetComponent<inventory>();
	}
    void Start()
    {
        canRoll = true;
        _animator.SetBool("Normal", Normal);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("presionaste 1");
            inventory.currentWeapon= inventory.GunSlot1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("presionaste 2");
            inventory.currentWeapon= inventory.GunSlot2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("presionaste 3");
            inventory.currentWeapon= inventory.GunSlot3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("presionaste 4");
            inventory.currentWeapon= inventory.GunSlot4;
        }
        timer -= Time.deltaTime;
        //Debug.Log(timer);
        if(timer <=0)
        {
            //Debug.Log("se acabo el tiempo, a reiniciar papi");
            canRoll = true;
        }


        //_isGrounded = true;

        if (_isAttacking == false) {
			// Movement
			float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
			_movement = new Vector2(horizontalInput, verticalInput);

			// Flip character
			if (horizontalInput < 0f && _facingRight == true) {
				Flip();
			} else if (horizontalInput > 0f && _facingRight == false) {
				Flip();
			}
		}
        // Wanna Attack?
		if (Input.GetButtonDown("Fire1")  && _isAttacking == false) {
			_movement = Vector2.zero;
			_rigidbody.velocity = Vector2.zero;
			//_animator.SetTrigger("Attack");
            StartCoroutine("Attack");
		}
        if (Input.GetButtonDown("Jump") &&canRoll  && (Input.GetAxisRaw("Horizontal")>0f || Input.GetAxisRaw("Horizontal")<0f)) {
            if(_facingRight==true)
            {
               // _rigidbody.AddForce(Vector2.right * 10);
                StartCoroutine("Roll");
            }
            else if(_facingRight==false)
            {
                //_rigidbody.AddForce(Vector2.right * 10);
                StartCoroutine("Roll");
            }
			
			//_rigidbody.velocity = Vector2.zero;
			//_animator.SetTrigger("Attack");
		}
    }
    void FixedUpdate()
	{
		if (_isAttacking == false) {
			float horizontalVelocity = _movement.normalized.x * speed;
            float vertivalVelocity = _movement.normalized.y * speed;
			_rigidbody.velocity = new Vector2(horizontalVelocity, vertivalVelocity);
		}
        if (rolling== true) {
			float horizontalVelocity = _movement.normalized.x * speed*3;
            float vertivalVelocity = _movement.normalized.y * speed*3;
			_rigidbody.velocity = new Vector2(horizontalVelocity, vertivalVelocity);
		}

	}
    void LateUpdate()
	{
		_animator.SetBool("Idle", _movement == Vector2.zero);
		_animator.SetBool("IsGrounded", _isGrounded);
		_animator.SetFloat("VerticalVelocity", _rigidbody.velocity.y);

		// Animator
		
        
	}
    private void Flip()
	{
		_facingRight = !_facingRight;
		float localScaleX = transform.localScale.x;
		localScaleX = localScaleX * -1f;
		transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
	}
    //IEnumerator Jump()
    //{
     //   _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
     //   _animator.SetBool("IsGrounded",false);
           // _isGrounded=true;
    //    yield return new WaitForSeconds(2);
     //   _animator.SetBool("IsGrounded",false);

    //}
    IEnumerator Roll()
    {
        rolling = true;
        _animator.SetBool("Roll",true);
        //_rigidbody.AddForce(Vector2.right * 10);
        this.gameObject.GetComponent<BoxCollider2D>().enabled =false;
        yield return new WaitForSeconds(0.5f);
        this.gameObject.GetComponent<BoxCollider2D>().enabled =true;
        rolling = false;
        canRoll = false;
        //_rigidbody.AddForce(Vector2.right * 10);
        _animator.SetBool("Roll",false);
        timer =10;
    }
    IEnumerator Attack()
    {
        _isAttacking = true;
        _animator.SetBool("Attack",true);
        yield return new WaitForSeconds(0.5f);
        _isAttacking = false;
        _animator.SetBool("Attack",false);

    }
}
