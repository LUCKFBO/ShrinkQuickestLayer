using System;

using System.Collections.Generic;

namespace teste.DTO
{
		/// <summary>
		/// Transferencia de Dados de Objetos
		/// São muitas vezes utilizados em conjunto com os objetos de dados de acesso
		/// para recuperar dados de um banco de dados.
		/// A diferença entre os objetos de transferência de dados e
		/// objetos de negócios ou objetos de acesso a dados é que um DTO não tem
		/// qualquer comportamento, exceto para armazenamento e recuperação de seus
		/// próprios dados.
		/// </summary>
	public class cliente
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214: DoNotCallOverridableMethodsInConstructors")]
		public cliente()
		{
			this.cliente0 = new HashSet<cliente>();
		}
		public Int32 id{ get; set; }
		public String nome{ get; set; }
		public String email{ get; set; }
		public String senha{ get; set; }
		public Int32? id_contato{ get; set; }
		public virtual ICollection<cliente> cliente0{ get; set; }
	}
}
