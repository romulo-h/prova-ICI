using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados
{
	public class Noticia
	{
		public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        [NotMapped]
        public List<int?> Tags { get; set; }
        public List<Tag> TagsSalvas { get; set; }
    }
}
