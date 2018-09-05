using System;
public class Alumno : MiembroPUCP{
	private int codigoAlumno;
	private float CRAEST;
	
	public Alumno(){
		
	}
	
	public Alumno(string nombre, DateTime fechaNac, string direccion, string email, char sexo, int codigoAlumno, float CRAEST) : base (nombre, fechaNac, direccion, email, sexo){
		this.codigoAlumno = codigoAlumno;
		this.CRAEST = CRAEST;
	}
	
	public int getCodigoAlumno(){
		return codigoAlumno;
	}
	
	public float getCRAEST(){
		return CRAEST;
	}
	
	public void setCodigoAlumno(int codigoAlumno){
		this.codigoAlumno = codigoAlumno;
	}
	
	public void setCRAEST(float CRAEST){
		this.CRAEST = CRAEST;
	}
	
	public override string consultarDatos(){
		return "Alumno: " + codigoAlumno + " "+ getNombre() +" "+ CRAEST;
	}
}