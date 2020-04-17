using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class EstadoCivil
    {
		private int _estadoCivil;
		private String _descripcion;


		public String Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}


		public int estadoCivil
		{
			get { return _estadoCivil; }
			set { _estadoCivil = value; }
		}

	}
}
