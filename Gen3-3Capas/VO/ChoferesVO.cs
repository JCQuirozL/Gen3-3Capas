using System;
using System.Data;

namespace Gen3_3Capas.VO
{
    public class ChoferesVO
    {
        private int _IdChofer;
        private string _Nombre;
        private string _ApPAterno;
        private string _ApMaterno;
        private string _Telefono;
        private string _Licencia;
        private string _UrlFoto;
        private DateTime _FechaNacimiento;
        private bool _Disponibilidad;

        public int IdChofer { get => _IdChofer; set => _IdChofer = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string ApPAterno { get => _ApPAterno; set => _ApPAterno = value; }
        public string ApMaterno { get => _ApMaterno; set => _ApMaterno = value; }

        public string NombreCompleto { get => Nombre + " " + ApPAterno + " " + ApMaterno; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Licencia { get => _Licencia; set => _Licencia = value; }
        public string UrlFoto { get => _UrlFoto; set => _UrlFoto = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public bool Disponibilidad { get => _Disponibilidad; set => _Disponibilidad = value; }

        public ChoferesVO()
        {
            IdChofer = 0;
            Nombre = "";
            ApPAterno = "";
            ApMaterno = "";
            Telefono = "";
            Licencia = "";
            UrlFoto = "";
            FechaNacimiento = DateTime.Parse("1990-01-01");
            Disponibilidad = false;
        }
        public ChoferesVO(DataRow dr)
        {
            //Debe coincidir el nombre entre corchetes con el nombre del campo de la base de datos
            IdChofer = int.Parse(dr["id"].ToString()); 
            Nombre = dr["Nombre"].ToString();
            ApPAterno = dr["ApPaterno"].ToString();
            ApMaterno = dr["ApMaterno"].ToString();
            Telefono = dr["Telefono"].ToString();
            Licencia = dr["Licencia"].ToString();
            UrlFoto = dr["UrlFoto"].ToString();
            FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
            Disponibilidad = bool.Parse(dr["Disponibilidad"].ToString());
        }
    }
}