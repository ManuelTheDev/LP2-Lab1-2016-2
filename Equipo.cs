using System.Collections.Generic;
public class Equipo{
	private List<Miembro> miembros;
	private string nombre;
	private string interes;
	
	public Equipo(string nombre, string interes){
		miembros = new List<Miembro>();
		this.nombre = nombre;
		this.interes = interes;
	}
	
	public void setNombre(string nombre){
		this.nombre = nombre;
	}
	
	public void setInteres(string interes){
		this.interes = interes;
	}
	
	public string getNombre(){
		return nombre;
	}
	
	public string getInteres(){
		return interes;
	}
	
	public void setMiembros(List<Miembro> miembros){
		this.miembros = miembros;
	}
	
	public List<Miembro> getMiembros(){
		return this.miembros;
	}
	
	public void agregarMiembro(Miembro m){
		miembros.Add(m);
	}
}