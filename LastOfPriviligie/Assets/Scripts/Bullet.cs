using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public int damage = 1;
	public float speed = 2f;
	public Vector2 direction;

	public float livingTime = 3f;
	public Color initialColor = Color.white;
	public Color finalColor;

	public GameObject explosion;

	private SpriteRenderer _renderer;
	private Rigidbody2D _rigidbody;
	private float _startingTime;

	private bool _returning;
	private bool _facingRight = true;
	public GameObject shooter;

	void Awake()
	{
		_renderer = GetComponent<SpriteRenderer>();
		_rigidbody = GetComponent<Rigidbody2D>();
		shooter = GameObject.FindGameObjectWithTag("Player");
	}

	// Start is called before the first frame update
	void Start()
    {
		//  Save initial time
		_startingTime = Time.time;
		if (shooter.transform.localScale.x < 0f && _facingRight == true) {
				Flip();
			} else if (shooter.transform.localScale.x > 0f && _facingRight == false) {
				Flip();
			}
    }

    // Update is called once per frame
    void Update()
    {
		
		// Change bullet's color over time
		float _timeSinceStarted = Time.time - _startingTime;
		float _percentageCompleted = _timeSinceStarted / livingTime;

		_renderer.color = Color.Lerp(initialColor, finalColor, _percentageCompleted);

		if (_percentageCompleted >= 1f) {
			Explode();
		}
	}

	private void FixedUpdate()
	{
		//  Move object
		Vector2 movement = direction.normalized * speed;
		_rigidbody.velocity = movement;
	}

	

	public void AddDamage()
	{
		_returning = true;
		direction = direction * -1f;
	}

	public void Explode()
	{
		speed = 0f;

		_renderer.enabled = false;

		if (explosion) {
			explosion.SetActive(true);
		}

		Destroy(gameObject, 1.5f);
	}
	private void Flip()
	{
		_facingRight = !_facingRight;
		float localScaleX = transform.localScale.x;
		localScaleX = localScaleX * -1f;
		transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
	}
}
