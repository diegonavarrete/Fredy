using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaClases
{
    class Contrato
    {
		private string _numero;
		private DateTime _fechaCreacion;
		private DateTime _fechaTermino;
		private string _rutCliente;
		private String _codigoPlan;
		private DateTime _fechaIniciVigencia;
		private DateTime _fechaFinVigencia;
		private bool _vigente;
		private bool _declaracionSalud;
		private float _primaAnual;
		private float _primaMensual;
		private string _observaciones;


		public string Observaciones
		{
			get { return _observaciones; }
			set { _observaciones = value; }
		}


		public float PrimaMensual
		{
			get { return _primaMensual; }
			set { _primaMensual = value; }
		}

		public float PrimaAnual
		{
			get { return _primaAnual; }
			set { _primaAnual = value; }
		}


		public bool DeclaracionSalud
		{
			get { return _declaracionSalud; }
			set { _declaracionSalud = value; }
		}


		public bool Vigente
		{
			get { return _vigente; }
			set { _vigente = value; }
		}


		public DateTime FechaFinVigencia

		{
			get { return _fechaFinVigencia; }
			set { _fechaFinVigencia = value; }
		}


		public DateTime FechaInicioVigencia

		{
			get { return _fechaIniciVigencia; }
			set { _fechaIniciVigencia = value; }
		}

		public String CodigoPlan
		{
			get { return _codigoPlan; }
			set { _codigoPlan = value; }
		}






		public string RutCliente
		{
			get { return _rutCliente; }
			set { _rutCliente = value; }
		}





		public DateTime FechaTermino
		{
			get { return _fechaTermino; }
			set { _fechaTermino = value; }
		}


		public DateTime FechaCreacion
		{
			get { return _fechaCreacion; }
			set { _fechaCreacion = value; }
		}


		public string Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}


	}
}
