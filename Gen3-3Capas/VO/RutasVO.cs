﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Gen3_3Capas.VO
{
    public class RutasVO
    {
        private int _IdRuta;
        private DateTime _Salida;
        private DateTime _Llegada;
        private double _Distancia;
        private bool _ATiempo;
        private string _Nombre;
        private string _Licencia;
        private string _FotoCh;
        private string _Matricula;
        private string _FotoCamion;
        private string _Origen;
        private string _Destino;

        public int IdRuta { get => _IdRuta; set => _IdRuta = value; }
        public DateTime Salida { get => _Salida; set => _Salida = value; }
        public DateTime Llegada { get => _Llegada; set => _Llegada = value; }
        public double Distancia { get => _Distancia; set => _Distancia = value; }
        public bool ATiempo { get => _ATiempo; set => _ATiempo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Licencia { get => _Licencia; set => _Licencia = value; }
        public string FotoCh { get => _FotoCh; set => _FotoCh = value; }
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public string FotoCamion { get => _FotoCamion; set => _FotoCamion = value; }
        public string Origen { get => _Origen; set => _Origen = value; }
        public string Destino { get => _Destino; set => _Destino = value; }

        public RutasVO()
        {
            IdRuta = 0;
            Nombre = "";
            Licencia = "";
            FotoCh = "";
            Matricula = "";
            FotoCamion = "";
            Origen = "";
            Destino = "";
            Salida = DateTime.Now;
            Llegada = DateTime.Now;
            ATiempo = false;
            Distancia = 0;
        }

        public RutasVO(DataRow dr)
        {
            IdRuta = int.Parse(dr["id"].ToString());
            Salida = DateTime.Parse(dr["FHSalida"].ToString());
            Llegada = DateTime.Parse(dr["FHLlegada"].ToString());
            Distancia = double.Parse(dr["Distancia"].ToString());
            ATiempo = bool.Parse(dr["ATiempo"].ToString());
            Nombre = dr["Nombre"].ToString();
            Licencia = dr["Licencia"].ToString();
            FotoCh = dr["FotoChofer"].ToString();
            Matricula = dr["Matricula"].ToString();
            FotoCamion = dr["FotoCamion"].ToString();
            Origen = dr["Origen"].ToString();
            Destino = dr["Destino"].ToString();
        }
        
    }
}