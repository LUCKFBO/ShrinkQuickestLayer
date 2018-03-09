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
	public class produto
	{
		public Int32 id{ get; set; }
		public String titulo{ get; set; }
		public String descricao{ get; set; }
		public Double preco{ get; set; }
		public Byte?[] imagem{ get; set; }
	}
}
