using System;
public class Profesor : MiembroPUCP{
	private int codProfesor;
	private string estado;
	
	public Profesor(string nombre, DateTime fechaNac, string direccion, string email, char sexo, int codProfesor, string estado) : base (nombre, fechaNac, direccion, email, sexo) {
		this.codProfesor = codProfesor;
		this.estado = estado;
	}
	
	public override string consultarDatos(){
		return "Profesor: " + codProfesor + " "+ getNombre() +" "+ estado;
	}
	
}