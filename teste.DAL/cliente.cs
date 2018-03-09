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
	public class cliente: IDisposable
	{
		String _conexaoSQL = "";
		SqlConnection conn = null;

		public cliente()
		{
			_conexaoSQL = conf.Default.ConnectionString;
		}

		public List<DTO.cliente> GetList( )
		{
			try
			{
				String sql = "SELECT * FROM cliente";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				List<DTO.cliente> lista = new List<DTO.cliente>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.cliente dto = new DTO.cliente();
						dto.id = Convert.ToInt32(dr["id"]);
						dto.nome = Convert.ToString(dr["nome"]);
						dto.email = Convert.ToString(dr["email"]);
						dto.senha = Convert.ToString(dr["senha"]);
						dto.id_contato = (dr["id_contato"] != DBNull.Value) ? (Int32?)(dr["id_contato"]) : null;
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
		public List<DTO.cliente> GetListByID(DTO.cliente VAR)
		{
			try
			{
				String sql = "SELECT * FROM cliente WHERE id = @VAR0  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR0", VAR.id);
				conn.Open();
				List<DTO.cliente> lista = new List<DTO.cliente>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.cliente dto = new DTO.cliente();
						dto.id = Convert.ToInt32(dr["id"]);
						dto.nome = Convert.ToString(dr["nome"]);
						dto.email = Convert.ToString(dr["email"]);
						dto.senha = Convert.ToString(dr["senha"]);
						dto.id_contato = (dr["id_contato"] != DBNull.Value) ? (Int32?)(dr["id_contato"]) : null;
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
		public void Insert(DTO.cliente dto)
		{
			try
			{
				String sql = "INSERT INTO cliente (nome, email, senha, id_contato) VALUES (@nome, @email, @senha, @id_contato)";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", dto.id);
				cmd.Parameters.AddWithValue("@nome", dto.nome);
				cmd.Parameters.AddWithValue("@email", dto.email);
				cmd.Parameters.AddWithValue("@senha", dto.senha);
				cmd.Parameters.AddWithValue("@id_contato", dto.id_contato == null ? (object)DBNull.Value : dto.id_contato);
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
		public void Update(DTO.cliente dto)
		{
			try
			{
				String sql = "UPDATE cliente SET nome = @nome, email = @email, senha = @senha, id_contato = @id_contato WHERE id = @DTO5  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@DTO5", dto.id);
				cmd.Parameters.AddWithValue("@id", dto.id);
				cmd.Parameters.AddWithValue("@nome", dto.nome);
				cmd.Parameters.AddWithValue("@email", dto.email);
				cmd.Parameters.AddWithValue("@senha", dto.senha);
				cmd.Parameters.AddWithValue("@id_contato", dto.id_contato == null ? (object)DBNull.Value : dto.id_contato);
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
		public void Delete(DTO.cliente dto)
		{
			try
			{
				String sql = "DELETE FROM cliente WHERE id = @DTO10  ";
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
				String sql = "SELECT * FROM cliente";
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
		public DataTable GetDataTableByID(DTO.cliente VAR)
		{
			try
			{
				String sql = "SELECT * FROM cliente WHERE id = @VAR15  ";
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
				String sql = "SELECT * FROM cliente JOIN cliente t0 ON cliente.id_contato = t0.id";
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
		public DataTable GetDataTableJoinByID(DTO.cliente VAR)
		{
			try
			{
				String sql = "SELECT * FROM cliente JOIN cliente t0 ON cliente.id_contato = t0.id WHERE cliente.id = @VAR20  ";
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
		public List<DTO.cliente> GetListJoinByID(DTO.cliente VAR)
		{
			try
			{
				String sql = "SELECT * FROM cliente JOIN cliente t0 ON cliente.id_contato = t0.id WHERE cliente.id = @VAR25  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR25", VAR.id);
				conn.Open();
				List<DTO.cliente> lista = new List<DTO.cliente>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.cliente dto = new DTO.cliente();
						dto.id = Convert.ToInt32(dr[0]);
						dto.nome = Convert.ToString(dr[1]);
						dto.email = Convert.ToString(dr[2]);
						dto.senha = Convert.ToString(dr[3]);
						dto.id_contato = (dr[4] != DBNull.Value) ? (Int32?)(dr[4]) : null;
						DTO.cliente dto0 = new DTO.cliente();
						dto0.id = Convert.ToInt32(dr[5]);
						dto0.nome = Convert.ToString(dr[6]);
						dto0.email = Convert.ToString(dr[7]);
						dto0.senha = Convert.ToString(dr[8]);
						dto0.id_contato = (dr[9] != DBNull.Value) ? (Int32?)(dr[9]) : null;
						dto.cliente0.Add(dto0);
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
