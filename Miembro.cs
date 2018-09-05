using System;
public class Miembro{
	public static int i = 1;
	private int codigo;
	private string nombre;
	private DateTime fechaNac;
	private string direccion;
	private string email;
	private char sexo;
	
	public Miembro(){}
	
	public Miembro(string nombre, DateTime fechaNac, string direccion, string email, char sexo){
		this.codigo = i;
		this.nombre = nombre;
		this.fechaNac = fechaNac;
		this.direccion = direccion;
		this.email = email;
		this.sexo = sexo;
		i++;
	}
	
	public void setNombre(string nombre){
		this.nombre = nombre;
	}
	
	public void setFechaNac(DateTime fechaNac){
		this.fechaNac = fechaNac;
	}
	
	public void setDireccion(string direccion){
		this.direccion = direccion;
	}
	
	public void setEmail(string email){
		this.email = email;
	}
	
	public void setSexo(char sexo){
		this.sexo = sexo;
	}
	
	public string getNombre(){
		return nombre;
	}
	
	public DateTime getFechaNac(){
		return fechaNac;
	}
	
	public string getDireccion(){
		return direccion;
	}
	
	public string getEmail(){
		return email;
	}
	
	public char getSexo(){
		return sexo;
	}
}