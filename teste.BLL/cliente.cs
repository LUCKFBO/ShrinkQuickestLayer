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
	public class cliente: IDisposable
	{
		DAL.cliente _cliente = new DAL.cliente();

		public cliente()
		{
		}

		/// <summary>
		/// Método retorna uma lista com todos os registros da tabela cliente.
		/// </summary>
		/// <returns>Retorna List.</returns>
		public List<DTO.cliente> GetList( )
		{
			try
			{
				_cliente = new DAL.cliente();
				return _cliente.GetList( );
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros da tabela cliente. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.cliente> GetListByID(DTO.cliente VAR)
		{
			try
			{
				_cliente = new DAL.cliente();
				return _cliente.GetListByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método insere um registro na tabela cliente. Recebe um objeto DTO com os campos a serem inseridos
		/// </summary>
		/// <param name="dto"> Registro a ser inserido</param>
		/// <returns>Retorna void.</returns>
		public void Insert(DTO.cliente dto)
		{
			try
			{
				_cliente = new DAL.cliente();
				_cliente.Insert(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método atualiza um registro na tabela cliente. Recebe um objeto DTO com os campos a serem atualizados
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id </param>
		/// <returns>Retorna void.</returns>
		public void Update(DTO.cliente dto)
		{
			try
			{
				_cliente = new DAL.cliente();
				_cliente.Update(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método exclui um registro na tabela cliente. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco a ser deletado
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id </param>
		/// <returns>Retorna void.</returns>
		public void Delete(DTO.cliente dto)
		{
			try
			{
				_cliente = new DAL.cliente();
				_cliente.Delete(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros da tabela cliente.
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTable( )
		{
			try
			{
				_cliente = new DAL.cliente();
				return _cliente.GetDataTable();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros da tabela cliente. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableByID(DTO.cliente VAR)
		{
			try
			{
				_cliente = new DAL.cliente();
				return _cliente.GetDataTableByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros relacionados a tabela cliente. Retorna a tabelas relacionadas por join
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoin( )
		{
			try
			{
				_cliente = new DAL.cliente();
				return _cliente.GetDataTableJoin();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros relacionados a tabela cliente. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoinByID(DTO.cliente VAR)
		{
			try
			{
				_cliente = new DAL.cliente();
				return _cliente.GetDataTableJoinByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros relacionados a tabela cliente. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.cliente> GetListJoinByID(DTO.cliente VAR)
		{
			try
			{
				_cliente = new DAL.cliente();
				return _cliente.GetListJoinByID(VAR);
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
				_cliente.Dispose();
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
