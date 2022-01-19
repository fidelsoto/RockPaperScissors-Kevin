using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePlay : MonoBehaviour
{
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	
	bool piedra1;
	bool papel1;
	bool tijera1;
	    
	bool piedra2;
	bool papel2;
	bool tijera2;
	
	
	
	
    // Update is called once per frame
    void Update()
	{
		piedra1 = Input.GetKey(KeyCode.Q);
		papel1 = Input.GetKey(KeyCode.W);
		tijera1 = Input.GetKey(KeyCode.E);
	    
		piedra2 = Input.GetKey(KeyCode.A);
		papel2 = Input.GetKey(KeyCode.S);
		tijera2 = Input.GetKey(KeyCode.D);
	    Versus();
    }
    
    
	public void Versus(){
		if (piedra1 && piedra2 )
		{
			Debug.Log("empate");
		}else if (piedra1  && papel2)
		{
			Debug.Log("el jugador 2 ha ganado");
		}else if (piedra1 && tijera2)
		{
			Debug.Log("el jugador 1 ha ganado ");
		}
		
		if (papel1 && papel2)
		{
			Debug.Log("empate");
		}else if (papel1 && piedra2)
		{
			Debug.Log("el jugador 1 ha ganado ");
		}else if (papel1 && tijera2)
		{
			Debug.Log("el jugador 2 ha ganado");
		}
		
		if (tijera1 && tijera2)
		{
			Debug.Log("empate");
		}else if (tijera1 && papel2)
		{
			Debug.Log("el jugador 1 ha ganado");
		}else if (tijera1 && piedra2)
		{
			Debug.Log("el jugador 2 ha ganado");
		}
	}
}
