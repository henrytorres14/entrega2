using System;
namespace SebastianRuiz_HenryTorres_EntregaAula2.Models
{
	public class Persona
	{
		private string nombre;
		private string apellidos;
		private string cedula;
		private string eps;
		private string regimen;
		private string afiliacion;
		private string historiaclinica;
		private string enfermedadrelevante;
		private string semanascotizadas;
		private string costotratamiento;
		private string cantidadenfermedades;
        public string edad;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public Persona(string nombre, string apellidos, string cedula, string eps, string regimen, string afiliacion, string historiaclinica, string enfermedadrelevante, string semanascotizadas, string costotratamiento, string cantidadenfermedades, string edad)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Cedula = cedula;
            this.Eps = eps;
            this.Regimen = regimen;
            this.Afiliacion = afiliacion;
            this.Historiaclinica = historiaclinica;
            this.Enfermedadrelevante = enfermedadrelevante;
            this.Semanascotizadas = semanascotizadas;
            this.Costotratamiento = costotratamiento;
            this.Cantidadenfermedades = cantidadenfermedades;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Eps { get => eps; set => eps = value; }
        public string Regimen { get => regimen; set => regimen = value; }
        public string Afiliacion { get => afiliacion; set => afiliacion = value; }
        public string Historiaclinica { get => historiaclinica; set => historiaclinica = value; }
        public string Enfermedadrelevante { get => enfermedadrelevante; set => enfermedadrelevante = value; }
        public string Semanascotizadas { get => semanascotizadas; set => semanascotizadas = value; }
        public string Costotratamiento { get => costotratamiento; set => costotratamiento = value; }
        public string Cantidadenfermedades { get => cantidadenfermedades; set => cantidadenfermedades = value; }
        public string Edad { get => edad; set => edad = value; }
    }
}

