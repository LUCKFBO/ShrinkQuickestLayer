using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace teste.DAL
{
		/// <summary>
		/// Camada de Acesso de Dados
		/// É uma camada separada da camada da apresentação de dados
		/// que tem a função de efetuar a conexão com a fonte de dados e através de
		/// comandos SQL (neste nosso caso) obter os dados para apresentação.
		/// </summary>
	public class produto: IDisposable
	{
		String _conexaoSQL = "";
		SqlConnection conn = null;

		public produto()
		{
			_conexaoSQL = conf.Default.ConnectionString;
		}

		public List<DTO.produto> GetList( )
		{
			try
			{
				String sql = "SELECT * FROM produto";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				List<DTO.produto> lista = new List<DTO.produto>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.produto dto = new DTO.produto();
						dto.id = Convert.ToInt32(dr["id"]);
						dto.titulo = Convert.ToString(dr["titulo"]);
						dto.descricao = (dr["descricao"] != DBNull.Value) ? Convert.ToString(dr["descricao"]) : null;
						dto.preco = Convert.ToDouble(dr["preco"]);
						dto.imagem = (dr["imagem"] != DBNull.Value) ? (Byte?[])(dr["imagem"]) : null;
						lista.Add(dto);
					}
				}
				return lista;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public List<DTO.produto> GetListByID(DTO.produto VAR)
		{
			try
			{
				String sql = "SELECT * FROM produto WHERE id = @VAR0  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR0", VAR.id);
				conn.Open();
				List<DTO.produto> lista = new List<DTO.produto>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.produto dto = new DTO.produto();
						dto.id = Convert.ToInt32(dr["id"]);
						dto.titulo = Convert.ToString(dr["titulo"]);
						dto.descricao = (dr["descricao"] != DBNull.Value) ? Convert.ToString(dr["descricao"]) : null;
						dto.preco = Convert.ToDouble(dr["preco"]);
						dto.imagem = (dr["imagem"] != DBNull.Value) ? (Byte?[])(dr["imagem"]) : null;
						lista.Add(dto);
					}
				}
				return lista;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public void Insert(DTO.produto dto)
		{
			try
			{
				String sql = "INSERT INTO produto (titulo, descricao, preco, imagem) VALUES (@titulo, @descricao, @preco, @imagem)";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", dto.id);
				cmd.Parameters.AddWithValue("@titulo", dto.titulo);
				cmd.Parameters.AddWithValue("@descricao", dto.descricao == null ? (object)DBNull.Value : dto.descricao);
				cmd.Parameters.AddWithValue("@preco", dto.preco);
				cmd.Parameters.AddWithValue("@imagem", dto.imagem == null ? (object)DBNull.Value : dto.imagem);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public void Update(DTO.produto dto)
		{
			try
			{
				String sql = "UPDATE produto SET titulo = @titulo, descricao = @descricao, preco = @preco, imagem = @imagem WHERE id = @DTO5  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@DTO5", dto.id);
				cmd.Parameters.AddWithValue("@id", dto.id);
				cmd.Parameters.AddWithValue("@titulo", dto.titulo);
				cmd.Parameters.AddWithValue("@descricao", dto.descricao == null ? (object)DBNull.Value : dto.descricao);
				cmd.Parameters.AddWithValue("@preco", dto.preco);
				cmd.Parameters.AddWithValue("@imagem", dto.imagem == null ? (object)DBNull.Value : dto.imagem);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public void Delete(DTO.produto dto)
		{
			try
			{
				String sql = "DELETE FROM produto WHERE id = @DTO10  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@DTO10", dto.id);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTable( )
		{
			try
			{
				String sql = "SELECT * FROM produto";
				conn = new SqlConnection(_conexaoSQL);
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTableByID(DTO.produto VAR)
		{
			try
			{
				String sql = "SELECT * FROM produto WHERE id = @VAR15  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR15", VAR.id);
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTableJoin( )
		{
			try
			{
				String sql = "SELECT * FROM produto";
				conn = new SqlConnection(_conexaoSQL);
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTableJoinByID(DTO.produto VAR)
		{
			try
			{
				String sql = "SELECT * FROM produto WHERE produto.id = @VAR20  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR20", VAR.id);
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public List<DTO.produto> GetListJoinByID(DTO.produto VAR)
		{
			try
			{
				String sql = "SELECT * FROM produto WHERE produto.id = @VAR25  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR25", VAR.id);
				conn.Open();
				List<DTO.produto> lista = new List<DTO.produto>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.produto dto = new DTO.produto();
						dto.id = Convert.ToInt32(dr[0]);
						dto.titulo = Convert.ToString(dr[1]);
						dto.descricao = (dr[2] != DBNull.Value) ? Convert.ToString(dr[2]) : null;
						dto.preco = Convert.ToDouble(dr[3]);
						dto.imagem = (dr[4] != DBNull.Value) ? (Byte?[])(dr[4]) : null;
						lista.Add(dto);
					}
				}
				return lista;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				conn.Dispose();
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
