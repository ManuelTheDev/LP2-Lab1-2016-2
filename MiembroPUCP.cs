using System;
public class MiembroPUCP : Miembro, Consultable {
	
	public MiembroPUCP(){
		
	}
	
	public MiembroPUCP(string nombre, DateTime fechaNac, string direccion, string email, char sexo) : base (nombre, fechaNac, direccion, email, sexo){
		
	}
	
	public virtual string consultarDatos(){
		return "";
	}
}