using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] int playerID;
    public GameManager gameManager;
    ControlManager controlManager;

    public Vector3 moveDirection;
    public Vector3 rotateDirection;

    public GameObject rightArea, leftArea;
    
    public float speed;
    public float hp;
    private Rigidbody rb;
    private CharacterController controller;
    private Animator animator;
    bool isGrounded, canRun;
    public bool canAttack;
    public bool stopAnimations;


    public RectTransform hpBar;
    public GameObject rightParticleHit,leftParticleHit;

    public PlayerMovement otherPlayer;


    public ParticleSystem deadParticle;
    public ParticleSystem winParticle;

    private bool stopTriggering;
    private Vector3 lastPos = new Vector3(0, 0, 0);
    public AudioClip punch;
    public AudioClip hit;
    public AudioClip run;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        stopAnimations = false;
        stopTriggering = false;
        canAttack = true;
        canRun = true;
        animator = GetComponentInChildren<Animator>();
        controller = GetComponentInChildren<CharacterController>();
        gameManager = FindObjectOfType<GameManager>();
        controlManager = FindObjectOfType<ControlManager>();
        rb = GetComponentInChildren<Rigidbody>();
    }
    void MovePlayer()
    {
        if (canRun)
        {
            if (!stopAnimations)
            {
                animator.SetBool("isRunning", true);
                animator.SetBool("isIdle", false);
                if(!audioSource.isPlaying)
                    audioSource.PlayOneShot(run);
                controller.Move(moveDirection * Time.deltaTime * speed);
            }
        }
        else
        {
            if (!stopAnimations)
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdle", true);
            }
            

        }
    }
    void Movement()
    {
        isGrounded = controller.isGrounded;

        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.LeftKey)))
        {
            moveDirection = Vector3.left;
            MovePlayer();
        }

        if(Input.GetKey(controlManager.GetKey(playerID, ControlKeys.RightKey)))
        {
            moveDirection = Vector3.right;
            MovePlayer();
        }

        if(Input.GetKey(controlManager.GetKey(playerID, ControlKeys.UpKey)))
        {
            moveDirection = new Vector3(0, 0, 1);
            MovePlayer();
        }

        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.DownKey)))
        {
            moveDirection = new Vector3(0, 0, -1);
            MovePlayer();
        }
        if (!Input.GetKey(controlManager.GetKey(playerID, ControlKeys.DownKey)) && !Input.GetKey(controlManager.GetKey(playerID, ControlKeys.UpKey))
            && !Input.GetKey(controlManager.GetKey(playerID, ControlKeys.RightKey)) && !Input.GetKey(controlManager.GetKey(playerID, ControlKeys.LeftKey))
            )
        {

            if(!stopAnimations)
            {
                animator.SetBool("isIdle", true);
                animator.SetBool("isRunning", false);
                animator.SetBool("isAttacking", false);

            }
        }


    }
    public void TakeDamage(bool dmgOnce)
    {
        int percentaje = 15;
        if(dmgOnce)
        {
            int dmg = Random.Range(10, 15);

            if (Random.Range(0, 100) <= percentaje)
                hp -= dmg * 1.15f;
            else
                hp -= dmg;
          
            if(!stopAnimations)
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isRunning", false);
                animator.SetBool("isAttacking", false);
                animator.SetTrigger("isDamaged");
            }
            

            UpdateHpVisuals();
            dmgOnce = false;
        }
    }
    public void TakeDamage(float dmg)
    {
        int percentaje = 15;
            if (Random.Range(0, 100) <= percentaje)
                hp -= dmg * 1.15f;
            else
                hp -= dmg;

            if (!stopAnimations)
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isRunning", false);
                animator.SetBool("isAttacking", false);
                animator.SetTrigger("isDamaged");

                if (!audioSource.isPlaying)
                    audioSource.PlayOneShot(hit);
            }
            UpdateHpVisuals();     
    }

    void UpdateHpVisuals()
    {
        if(hpBar.localScale.x >=0)
        {
            hpBar.localScale = new Vector3((hp / 100), 1, 1);
        }
    }
    IEnumerator WaitAnimationToEnd(int id)
    {
        if (!stopAnimations)
        {
            animator.SetBool("isAttacking", true);
            animator.SetBool("isIdle", false);
            animator.SetBool("isRunning", false);
        }
        if (id == 0)
            yield return new WaitForSeconds(1f);
        if (id == 1)
            yield return new WaitForSeconds(2f);
    }
    void Attack()
    {
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.Attack)) && canAttack==true)
        {
            StartCoroutine("WaitAnimationToEnd", playerID);

            canRun = false;
            moveDirection = Vector3.zero;

            if (playerID==0)
            {
                if (GetComponentInChildren<SpriteRenderer>().flipX == true)
                {
                    //attack with righ coll
                    Collider[] col = Physics.OverlapSphere(rightArea.transform.position, 1);
                    foreach (Collider c in col)
                    {
                        if (c.GetComponent<MyColliderHolder>() != null && c.GetComponent<MyColliderHolder>().GetComponentInParent<PlayerMovement>().gameObject != gameObject)
                        {
                            StartCoroutine("ParticleWaitToPlay", rightParticleHit.GetComponent<ParticleSystem>());
                            c.GetComponentInParent<PlayerMovement>().SendMessage("TakeDamage", canAttack);
                            if (!audioSource.isPlaying)
                                audioSource.PlayOneShot(punch);
                        }
                    }
                }
                if (GetComponentInChildren<SpriteRenderer>().flipX == false)
                {
                    //attack with righ coll
                    Collider[] col = Physics.OverlapSphere(leftArea.transform.position, 1);
                    foreach (Collider c in col)
                    {
                        if (c.GetComponent<MyColliderHolder>() != null && c.GetComponent<MyColliderHolder>().GetComponentInParent<PlayerMovement>().gameObject != gameObject)
                        {
                            StartCoroutine("ParticleWaitToPlay", leftParticleHit.GetComponent<ParticleSystem>());
                            c.GetComponentInParent<PlayerMovement>().SendMessage("TakeDamage", canAttack);
                            if (!audioSource.isPlaying)
                                audioSource.PlayOneShot(punch);
                        }
                    }
                }
            }
            if (playerID == 1)
            {
                if (GetComponentInChildren<SpriteRenderer>().flipX == false)
                {
                    Collider[] col = Physics.OverlapSphere(rightArea.transform.position, 1);
                    foreach (Collider c in col)
                    {
                        if (c.GetComponent<MyColliderHolder>() != null && c.GetComponent<MyColliderHolder>().GetComponentInParent<PlayerMovement>().gameObject != gameObject)
                        {
                            StartCoroutine("ParticleWaitToPlay", rightParticleHit.GetComponent<ParticleSystem>());
                            c.GetComponentInParent<PlayerMovement>().SendMessage("TakeDamage", canAttack);
                            if (!audioSource.isPlaying)
                                audioSource.PlayOneShot(punch);
                        }
                    }
                }
                if (GetComponentInChildren<SpriteRenderer>().flipX == true)
                {
                    Collider[] col = Physics.OverlapSphere(leftArea.transform.position, 1);
                    foreach (Collider c in col)
                    {
                        if (c.GetComponent<MyColliderHolder>() != null && c.GetComponent<MyColliderHolder>().GetComponentInParent<PlayerMovement>().gameObject != gameObject)
                        {
                            StartCoroutine("ParticleWaitToPlay", leftParticleHit.GetComponent<ParticleSystem>());
                            c.GetComponentInParent<PlayerMovement>().SendMessage("TakeDamage", canAttack);
                            if (!audioSource.isPlaying)
                                audioSource.PlayOneShot(punch);
                        }
                    }
                }
            }
            canAttack = false;
            StartCoroutine("CanAttackCooldown");
        }
    }

    IEnumerator ParticleWaitToPlay(ParticleSystem particle)
    {
        yield return new WaitForSeconds(0.28f);
        if(!stopAnimations)
            particle.Play();
    }

   IEnumerator CanAttackCooldown()
    {
        if (playerID == 0)
            yield return new WaitForSeconds(1.2f);
        if (playerID == 1)
            yield return new WaitForSeconds(1.9f);
        canAttack = true;
    }
    void CheckVisuals()
    {
        if(!stopAnimations)
        {
            if (moveDirection.x > 0 && playerID == 0)
            {
                GetComponentInChildren<SpriteRenderer>().flipX = true;
            }
            else if (moveDirection.x > 0 && playerID == 1)
            {
                GetComponentInChildren<SpriteRenderer>().flipX = false;
            }
            if (moveDirection.x < 0 && playerID == 0)
            {
                GetComponentInChildren<SpriteRenderer>().flipX = false;
            }
            else if (moveDirection.x < 0 && playerID == 1)
            {
                GetComponentInChildren<SpriteRenderer>().flipX = true;
            }

        }
        

    }
    void Update()
    {
        //if (gameManager != null){ gameManager = FindObjectOfType<GameManager>(); }
        if (!animator.GetBool("isAttacking")) canRun = true; 
        Movement();
        Attack();
        CheckVisuals();
        Dead();
        if (hp <= 20)
        {
            if (!stopAnimations)
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isRunning", false);
                animator.SetBool("isAttacking", false);
                animator.SetTrigger("isDead");
                stopAnimations = true;
            }
            
        }

        if (otherPlayer.hp <= 20 && !stopTriggering)
         {
            stopAnimations = true;
            animator.SetTrigger("isPrank");
            winParticle.Play();
            stopTriggering = true;
         }
        
    }
    
    void Dead()
    {
        if (hp <= 20) 
        {
            if(!stopAnimations)
            {
                stopAnimations = true;
                animator.SetTrigger("isDead");
                otherPlayer.stopAnimations = true;
                otherPlayer.animator.SetBool("isIdle", false);
                otherPlayer.animator.SetBool("isRunning", false);
                otherPlayer.animator.SetBool("isAttacking", false);
                otherPlayer.animator.SetTrigger("isDead");
                deadParticle.Play();
            }
            gameManager.looserId = playerID;
            gameManager.GetWinningId();
        }

        //trigger dead animations
        //when ended, particle dead and destroy obj
        //trigger other player prank animation

        //update score
        //restart scene




    }
    



}
