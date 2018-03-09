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
	public class pedido: IDisposable
	{
		DAL.pedido _pedido = new DAL.pedido();

		public pedido()
		{
		}

		/// <summary>
		/// Método retorna uma lista com todos os registros da tabela pedido.
		/// </summary>
		/// <returns>Retorna List.</returns>
		public List<DTO.pedido> GetList( )
		{
			try
			{
				_pedido = new DAL.pedido();
				return _pedido.GetList( );
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros da tabela pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.pedido> GetListByID(DTO.pedido VAR)
		{
			try
			{
				_pedido = new DAL.pedido();
				return _pedido.GetListByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método insere um registro na tabela pedido. Recebe um objeto DTO com os campos a serem inseridos
		/// </summary>
		/// <param name="dto"> Registro a ser inserido</param>
		/// <returns>Retorna void.</returns>
		public void Insert(DTO.pedido dto)
		{
			try
			{
				_pedido = new DAL.pedido();
				_pedido.Insert(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método atualiza um registro na tabela pedido. Recebe um objeto DTO com os campos a serem atualizados
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id </param>
		/// <returns>Retorna void.</returns>
		public void Update(DTO.pedido dto)
		{
			try
			{
				_pedido = new DAL.pedido();
				_pedido.Update(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método exclui um registro na tabela pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco a ser deletado
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id </param>
		/// <returns>Retorna void.</returns>
		public void Delete(DTO.pedido dto)
		{
			try
			{
				_pedido = new DAL.pedido();
				_pedido.Delete(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros da tabela pedido.
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTable( )
		{
			try
			{
				_pedido = new DAL.pedido();
				return _pedido.GetDataTable();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros da tabela pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableByID(DTO.pedido VAR)
		{
			try
			{
				_pedido = new DAL.pedido();
				return _pedido.GetDataTableByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros relacionados a tabela pedido. Retorna a tabelas relacionadas por join
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoin( )
		{
			try
			{
				_pedido = new DAL.pedido();
				return _pedido.GetDataTableJoin();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros relacionados a tabela pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoinByID(DTO.pedido VAR)
		{
			try
			{
				_pedido = new DAL.pedido();
				return _pedido.GetDataTableJoinByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros relacionados a tabela pedido. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.pedido> GetListJoinByID(DTO.pedido VAR)
		{
			try
			{
				_pedido = new DAL.pedido();
				return _pedido.GetListJoinByID(VAR);
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
				_pedido.Dispose();
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
