using System;
public class Principal{
	public static void Main(string[] args){
		//Crea una instancia de EQuipu
		EQuipu objEquipu = new EQuipu();
		//Crear un equipo
		Equipo equipoUsabilidad = new Equipo("UMETSOFT","HCI");
		
		Miembro a1 = new Alumno("Juan Perez", Convert.ToDateTime("18/09/1975"), "Av. Universitaria 1910", "jperez@pucp.pe", 'M', 20090606, 68.3f);
		equipoUsabilidad.agregarMiembro(a1);
		
		
		
		Miembro p1 = new Profesor("Andrea Montenegro", Convert.ToDateTime("18/09/1975"), "Av. Universitaria 1910", "amontenegro@pucp.pe", 'F', 46891, "TC");
		equipoUsabilidad.agregarMiembro(p1);
		
		objEquipu.agregarEquipoRed(equipoUsabilidad);
		String reporte = objEquipu.ConsultarMiembrosDeEquipo(0);
		Console.Write(reporte);
		Console.Read();
		
	}
}