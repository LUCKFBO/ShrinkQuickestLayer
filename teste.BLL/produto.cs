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
	public class produto: IDisposable
	{
		DAL.produto _produto = new DAL.produto();

		public produto()
		{
		}

		/// <summary>
		/// Método retorna uma lista com todos os registros da tabela produto.
		/// </summary>
		/// <returns>Retorna List.</returns>
		public List<DTO.produto> GetList( )
		{
			try
			{
				_produto = new DAL.produto();
				return _produto.GetList( );
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros da tabela produto. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.produto> GetListByID(DTO.produto VAR)
		{
			try
			{
				_produto = new DAL.produto();
				return _produto.GetListByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método insere um registro na tabela produto. Recebe um objeto DTO com os campos a serem inseridos
		/// </summary>
		/// <param name="dto"> Registro a ser inserido</param>
		/// <returns>Retorna void.</returns>
		public void Insert(DTO.produto dto)
		{
			try
			{
				_produto = new DAL.produto();
				_produto.Insert(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método atualiza um registro na tabela produto. Recebe um objeto DTO com os campos a serem atualizados
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id </param>
		/// <returns>Retorna void.</returns>
		public void Update(DTO.produto dto)
		{
			try
			{
				_produto = new DAL.produto();
				_produto.Update(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método exclui um registro na tabela produto. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco a ser deletado
		/// </summary>
		/// <param name="dto"> Campo(s) WHERE dto.id </param>
		/// <returns>Retorna void.</returns>
		public void Delete(DTO.produto dto)
		{
			try
			{
				_produto = new DAL.produto();
				_produto.Delete(dto);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros da tabela produto.
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTable( )
		{
			try
			{
				_produto = new DAL.produto();
				return _produto.GetDataTable();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros da tabela produto. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableByID(DTO.produto VAR)
		{
			try
			{
				_produto = new DAL.produto();
				return _produto.GetDataTableByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com todos os registros relacionados a tabela produto. Retorna a tabelas relacionadas por join
		/// </summary>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoin( )
		{
			try
			{
				_produto = new DAL.produto();
				return _produto.GetDataTableJoin();
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma tabela com os registros relacionados a tabela produto. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma tabela
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna DataTable.</returns>
		public DataTable GetDataTableJoinByID(DTO.produto VAR)
		{
			try
			{
				_produto = new DAL.produto();
				return _produto.GetDataTableJoinByID(VAR);
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Método retorna uma lista com os registros relacionados a tabela produto. Recebe um objeto DTO com os operadores para selecionar um registro especifico do banco e devolver uma lista
		/// </summary>
		/// <param name="VAR"> Campo(s) WHERE VAR.id </param>
		/// <returns>Retorna List.</returns>
		public List<DTO.produto> GetListJoinByID(DTO.produto VAR)
		{
			try
			{
				_produto = new DAL.produto();
				return _produto.GetListJoinByID(VAR);
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
				_produto.Dispose();
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
