﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente
    {
		private String _rutCliente;
		private String  _nombres;
		private String _apellidos;
		private DateTime _fechaNacimiento;
		private int _idSexo;
		private int _idEstadoCivil;


		public int IdEstadoCivil
		{
			get { return _idEstadoCivil; }
			set { _idEstadoCivil = value; }
		}


		public int IdSexo
		{
			get { return _idSexo; }
			set { _idSexo = value; }
		}


		public DateTime FechaNacimiento
		{
			get { return _fechaNacimiento; }
			set { _fechaNacimiento = value; }
		}


		public String Apellidos
		{
			get { return _apellidos; }
			set { _apellidos = value; }
		}

		public String  Nombres
		{
			get { return _nombres; }
			set { _nombres = value; }
		}


		public String RutCliente
		{
			get { return _rutCliente; }
			set { _rutCliente = value; }


		}


		public Cliente()
		{
			this.Init();
		}

		private void Init()

		{
			RutCliente = string.Empty;
			Nombres = string.Empty;
			Apellidos = string.Empty;
			FechaNacimiento=DateTime.MinValue;
			IdSexo =0;
			IdEstadoCivil = 0;

		}


	}


}
