using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class Player : MonoBehaviour {

	public float jumpForce = 10f,speed = 50f;
	public bool jump;
	public Rigidbody rb;
    public GameObject Blast;
    
	void Start ()
	{
		jump = true;
	}
	
	// Update is called once per frame
	void Update () {
		Jump ();
		move ();
	}
	void Jump(){
		if (Input.GetButtonDown("Jump")&&jump)
		{   
			jump = false;
			rb.velocity = Vector2.up * jumpForce;
			StartCoroutine (StopJump ());
		}
	
	}
	IEnumerator StopJump(){
		yield return new WaitForSeconds (1f);
		jump = true;
	}
	void move ()
	{
		float h = Input.GetAxisRaw("Horizontal");
		Vector3 temp = this.transform.position;
		if (h > 0) {
			temp.z += h*speed;	
			this.transform.position= temp;
		}  if (h < 0) {

			temp.z += h*speed;	
			this.transform.position =temp;
		} else {
		}
	}
    public GameObject blastpos;
    
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name == "block")
        {
            Instantiate(Blast, target.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(this.gameObject);
        }
    }
}