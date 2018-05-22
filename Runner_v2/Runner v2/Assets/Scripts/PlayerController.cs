using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.Windows.Speech;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D myRigidBody;

	public bool grounded;
	public LayerMask whatIsGround;

	private Collider2D myCollider;

	private Animator myAnimator;

	public GameManager theGameManager;

	private ScoreManager theScoreManager;
	private int letraNum;

    //audio variables
    //public static string path = "C:/Users/fabian/Downloads/grammar.xml";
    public static string path = Environment.CurrentDirectory+ "\\Assets\\Scripts\\grammar.xml";
    
    private GrammarRecognizer grammar_Recognizer;

    public int num_pal;

    // Use this for initialization
    void Start () {
        //audio variables
        //Debug.Log(path);
        grammar_Recognizer = new GrammarRecognizer(path);
        grammar_Recognizer.OnPhraseRecognized += OnKeywordsRecognized;
        grammar_Recognizer.Start();
        
        myRigidBody = GetComponent<Rigidbody2D> ();
		myCollider = GetComponent<Collider2D> ();
		myAnimator = GetComponent<Animator> ();
		theScoreManager = FindObjectOfType<ScoreManager> ();
	}

    //audio actions
    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Keyword: " + args.text);
        switch (args.text)
        {
            case "casa":
                num_pal = 1;
                break;
            case "hola":
                num_pal = 2;
                break;
            case "perro":
                num_pal = 3;
                break;
            case "mirar":
                num_pal = 4;
                break;
            case "oler":
                num_pal = 5;
                break;
            case "agua":
                num_pal = 6;
                break;
            case "arbol":
                num_pal = 7;
                break;
            case "amigo":
                num_pal = 8;
                break;
            case "avion":
                num_pal = 9;
                break;
            case "azul":
                num_pal = 10;
                break;
            case "barco":
                num_pal = 11;
                break;
            case "cielo":
                num_pal = 12;
                break;
            case "comer":
                num_pal = 13;
                break;
            case "flor":
                num_pal = 14;
                break;
            case "gato":
                num_pal = 15;
                break;
            case "fresa":
                num_pal = 16;
                break;
            case "hoja":
                num_pal = 17;
                break;
            case "jugar":
                num_pal = 18;
                break;
            case "leer":
                num_pal = 19;
                break;
            case "libro":
                num_pal = 20;
                break;
            case "madre":
                num_pal = 21;
                break;
            case "mesa":
                num_pal = 22;
                break;
            case "oso":
                num_pal = 23;
                break;
            case "padre":
                num_pal = 24;
                break;
            case "pato":
                num_pal = 25;
                break;
            case "pera":
                num_pal = 26;
                break;
            case "pez":
                num_pal = 27;
                break;
            case "pollo":
                num_pal = 28;
                break;
            case "queso":
                num_pal = 29;
                break;
            case "rana":
                num_pal = 30;
                break;
            case "reir":
                num_pal = 31;
                break;
            case "reloj":
                num_pal = 32;
                break;
            case "rojo":
                num_pal = 33;
                break;
            case "ropa":
                num_pal = 34;
                break;
            case "silla":
                num_pal = 35;
                break;
            case "taza":
                num_pal = 36;
                break;
            case "tren":
                num_pal = 37;
                break;
            case "verde":
                num_pal = 38;
                break;
            case "lapiz":
                num_pal = 39;
                break;
            case "pluma":
                num_pal = 40;
                break;
            case "ayer":
                num_pal = 41;
                break;
            case "nuevo":
                num_pal = 42;
                break;
            case "noche":
                num_pal = 43;
                break;
            case "dia":
                num_pal = 44;
                break;
            case "mano":
                num_pal = 45;
                break;
            case "ojos":
                num_pal = 46;
                break;
            case "carro":
                num_pal = 47;
                break;
            case "meses":
                num_pal = 48;
                break;
            case "hora":
                num_pal = 49;
                break;
            case "bien":
                num_pal = 50;
                break;
        }
    }

    // Update is called once per frame
    void Update () {
		grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);
		myRigidBody.velocity = new Vector2 (moveSpeed, myRigidBody.velocity.y);

		letraNum = theScoreManager.GetLetra ();
		if (num_pal == letraNum) 
		{
			if (grounded) {
                double jump_Total = jumpForce * 1.25;
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, (float)jump_Total);
                num_pal = 0;
            }
		}

		myAnimator.SetFloat ("Speed", myRigidBody.velocity.x);
		myAnimator.SetBool ("Grounded", grounded);
	}


	// Lost
	void OnCollisionStay2D (Collision2D other) {
		if (other.gameObject.tag == "killbox") {
			theGameManager.PlayerLost ();
            num_pal = 0;
        }
	}

}
