using System.Collections.Generic;
using System;
public class EQuipu{
	private List<Equipo> red;
	private List<Miembro> ejecutivos;
	
	public EQuipu(){
		red = new List<Equipo>();
		ejecutivos = new List<Miembro>();
	}
	
	public void setEquipos(List<Equipo> equipos){
		this.red = equipos;
	}
	
	public List<Equipo> getEquipos(){
		return red;
	}
	
	public void setEjecutivos(List<Miembro> miembros){
		this.ejecutivos = miembros;
	}
	
	public List<Miembro> getEjecutivos(){
		return ejecutivos;
	}
	
	public void agregarEquipoRed(Equipo e){
		red.Add(e);
	}
	
	public String ConsultarMiembrosDeEquipo(int indice){
		String cadena="";
		foreach(MiembroPUCP m in red[indice].getMiembros()){
			cadena = cadena + m.consultarDatos() + "\n";
		}
		return cadena;
	}
}