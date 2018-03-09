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
	public class item_pedido
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214: DoNotCallOverridableMethodsInConstructors")]
		public item_pedido()
		{
			this.pedido = new HashSet<pedido>();
			this.produto = new HashSet<produto>();
		}
		public Int32 id_pedido{ get; set; }
		public Int32 id_produto{ get; set; }
		public Double preco_unitario{ get; set; }
		public Int32 quantidade{ get; set; }
		public Double preco_total{ get; set; }
		public virtual ICollection<pedido> pedido{ get; set; }
		public virtual ICollection<produto> produto{ get; set; }
	}
}
