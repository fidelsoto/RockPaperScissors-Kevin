using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public enum Opciones
	{
		piedra = 0,
		papel = 1,
		tijeras = 2,
		none = 3
	}
	
	
	
	[SerializeField]
	private Opciones seleccionDelJugador1 = Opciones.none;
	[SerializeField]
	private Opciones seleccionDelJugador2 = Opciones.none;
	
	public int scoreP1 = 0;
	public int scoreP2 = 0;
	public Text miTexto1;
	public Text miTexto2;
	//
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		
		
	}
	 void Update()
	{
	miTexto1.text = scoreP1.ToString();
	miTexto2.text = scoreP2.ToString();
	}
    
	public void CaptureP1Input(int seleccion)
	{
		seleccionDelJugador1 = (Opciones)seleccion;
	}
    
	public void CaptureP2Input(int seleccion)
	{
		seleccionDelJugador2 = (Opciones)seleccion;
	}
    
	public void Versus(){
		if (seleccionDelJugador1 == Opciones.none || seleccionDelJugador2 == Opciones.none)
		{
			Debug.Log("Falta un jugador por jugar.");
			return;
		}
		if (seleccionDelJugador1 == seleccionDelJugador2)
		{
			Debug.Log("Empate.");
		}
		if (seleccionDelJugador1 == Opciones.piedra)
		{
			if (seleccionDelJugador2 == Opciones.papel)
			{
				Debug.Log("Ganó el jugador #2.");
				scoreP2 = scoreP2+1;
			}
			if (seleccionDelJugador2 == Opciones.tijeras)
			{
				Debug.Log("Ganó el jugador #1.");
				scoreP1 = scoreP1+1;
			}
		}
		if (seleccionDelJugador1 == Opciones.papel)
		{
			if (seleccionDelJugador2 == Opciones.piedra)
			{
				Debug.Log("Ganó el jugador #1.");
				scoreP1 = scoreP1+1;
			}
			if (seleccionDelJugador2 == Opciones.tijeras)
			{
				Debug.Log("Ganó el jugador #2.");
				scoreP2 = scoreP2+1;
			}
		}
		if (seleccionDelJugador1 == Opciones.tijeras)
		{
			if (seleccionDelJugador2 == Opciones.papel)
			{
				Debug.Log("Ganó el jugador #1.");
				scoreP1 = scoreP1+1;
			}
			if (seleccionDelJugador2 == Opciones.piedra)
			{
				Debug.Log("Ganó el jugador #2.");
				scoreP2 = scoreP2+1;
			}
		}
		seleccionDelJugador1 = Opciones.none;
		seleccionDelJugador2 = Opciones.none;
	}
}
