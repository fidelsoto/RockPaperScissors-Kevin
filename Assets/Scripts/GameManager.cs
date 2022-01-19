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
	
    void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
			Versus();
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
			}
			if (seleccionDelJugador2 == Opciones.tijeras)
			{
				Debug.Log("Ganó el jugador #1.");
			}
		}
		if (seleccionDelJugador1 == Opciones.papel)
		{
			if (seleccionDelJugador2 == Opciones.piedra)
			{
				Debug.Log("Ganó el jugador #1.");
			}
			if (seleccionDelJugador2 == Opciones.tijeras)
			{
				Debug.Log("Ganó el jugador #2.");
			}
		}
		if (seleccionDelJugador1 == Opciones.tijeras)
		{
			if (seleccionDelJugador2 == Opciones.papel)
			{
				Debug.Log("Ganó el jugador #1.");
			}
			if (seleccionDelJugador2 == Opciones.piedra)
			{
				Debug.Log("Ganó el jugador #2.");
			}
		}
		seleccionDelJugador1 = Opciones.none;
		seleccionDelJugador2 = Opciones.none;
	}
}
