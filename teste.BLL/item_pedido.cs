using System;
using System.Collections.Generic;
using System.Data;

namespace teste.BLL
{
		/// <summary>
		/// Camada de Regra de Negocio
		/// As regras de negócio definem como o seu negócio funciona. 
		/// Essas regras podem abranger diversos assuntos como suas políticas, interesses, 
		/// objetivos, compromissos éticos e sociais, obrigações contratuais, 
		/// decisões estratégicas, leis e regulamentações, entre outros.
		/// </summary>
	public class item_pedido: IDisposable
	{
		DAL.item_pedido _item_pedido = new DAL.item_pedido();

		public item_pedido()
		{
		}

		/// <summary>
		/// Método retorna uma lista com todos os registros da tabela item_pedido.
		/// </summary>
		/// <returns>Retorna List.</returns>
		public List<DTO.item_pedido> GetList( )
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				return _item_pedido.GetList( );
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros da tabela item_pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id_pedido VAR.id_produto </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.item_pedido> GetListByID(DTO.item_pedido VAR)
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				return _item_pedido.GetListByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método insere um registro na tabela item_pedido. Recebe um objeto DTO com os campos a serem inseridos
		/// </summary>
		/// <param name="dto"> Registro a ser inserido</param>
		/// <returns>Retorna void.</returns>
		public void Insert(DTO.item_pedido dto)
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				_item_pedido.Insert(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método atualiza um registro na tabela item_pedido. Recebe um objeto DTO com os campos a serem atualizados
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id_pedido dto.id_produto </param>
		/// <returns>Retorna void.</returns>
		public void Update(DTO.item_pedido dto)
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				_item_pedido.Update(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método exclui um registro na tabela item_pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco a ser deletado
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id_pedido dto.id_produto </param>
		/// <returns>Retorna void.</returns>
		public void Delete(DTO.item_pedido dto)
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				_item_pedido.Delete(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros da tabela item_pedido.
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTable( )
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				return _item_pedido.GetDataTable();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros da tabela item_pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id_pedido VAR.id_produto </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableByID(DTO.item_pedido VAR)
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				return _item_pedido.GetDataTableByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros relacionados a tabela item_pedido. Retorna a tabelas relacionadas por join
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoin( )
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				return _item_pedido.GetDataTableJoin();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros relacionados a tabela item_pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id_pedido VAR.id_produto </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoinByID(DTO.item_pedido VAR)
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				return _item_pedido.GetDataTableJoinByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros relacionados a tabela item_pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id_pedido VAR.id_produto </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.item_pedido> GetListJoinByID(DTO.item_pedido VAR)
		{
			try
			{
				_item_pedido = new DAL.item_pedido();
				return _item_pedido.GetListJoinByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				_item_pedido.Dispose();
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
