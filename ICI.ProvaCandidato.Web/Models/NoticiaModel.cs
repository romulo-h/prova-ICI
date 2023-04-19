using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ICI.ProvaCandidato.Web.Models
{
	public class NoticiaModel
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Texto { get; set; }
		public int UsuarioId { get; set; }
        public string NmUsuario { get; set; }
	}
}
