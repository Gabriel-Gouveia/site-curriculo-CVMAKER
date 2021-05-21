using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class CurriculoDAO
    {
        public void Inserir(CurriculoViewModel curriculo)
        {
            string sql = "insert into Curriculo(id, idExperiencia, idIdioma1, idIdioma2, idIdioma3, idFormacaoG, idFormacaoPG, idFormacaoTec, idade, nome, cpf, " +
                "codEndereco, telefone, email, area, cargo)" +
                "values (@id, @idExperiencia, @idIdioma1, @idIdioma2, @idIdioma3, @idFormacaoG, @idFormacaoPG, @idFormacaoTec, @idade, @nome, " +
                "@cpf, @codEndereco, @telefone, @email, @area, @cargo) ";// +
                                                                         //"\n insert into Enderecos(idEnd, idCurriculo, estado, cidade, bairro, rua, cep) VALUES(@codEndereco, @id, 'SP', 'SÃO PAULO', 'MORUMBI', 'X', '000000')";
            HelperDAO.ExecutaSQL(sql, CriaParametros(curriculo));
        }

        public void Alterar(CurriculoViewModel curriculo)
        {
            string sql = "update Curriculo set idade = @idade, " + "nome = @nome, " + "cpf = @cpf, " + "telefone = @telefone, " + "email = @email, " + "area = @area, " + "cargo = @cargo where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(curriculo));
        }
        private SqlParameter[] CriaParametros(CurriculoViewModel curriculo)
        {
            SqlParameter[] parametros = new SqlParameter[16];
            parametros[0] = new SqlParameter("id", curriculo.Id);
            parametros[1] = new SqlParameter("idExperiencia", curriculo.IdExperiencia);
            parametros[2] = new SqlParameter("idIdioma1", curriculo.IdIdioma1);
            parametros[3] = new SqlParameter("idIdioma2", curriculo.IdIdioma2);
            parametros[4] = new SqlParameter("idIdioma3", curriculo.IdIdioma3);
            parametros[5] = new SqlParameter("idFormacaoG", curriculo.IdFormacaoG);
            parametros[6] = new SqlParameter("idFormacaoPG", curriculo.IdFormacaoPG);
            parametros[7] = new SqlParameter("idFormacaoTec", curriculo.IdFormacaoTec);
            parametros[8] = new SqlParameter("idade", curriculo.Idade);
            parametros[9] = new SqlParameter("nome", curriculo.Nome);
            parametros[10] = new SqlParameter("cpf", curriculo.Cpf);
            parametros[11] = new SqlParameter("codEndereco", curriculo.CodEndereco);
            parametros[12] = new SqlParameter("telefone", curriculo.Telefone);
            parametros[13] = new SqlParameter("email", curriculo.Email);
            parametros[14] = new SqlParameter("area", curriculo.Area);
            parametros[15] = new SqlParameter("cargo", curriculo.Cargo);


            return parametros;
        }
        public void Excluir(int id)
        {
            string sql = "delete Curriculo where id =" + id;
            string sql2 = "delete Enderecos where idCurriculo_end =" + id;
            string sql3 = "delete Experiencias where id_curriculo_EXP =" + id;
            string sql4 = "delete FormacaoGraduacao where idCurriculo_G =" + id;
            string sql5 = "delete FormacaoPosGraduacao where idCurriculo_PG =" + id;
            string sql6 = "delete FormacaoTecnico where idCurriculo_TEC =" + id;
            string sql7 = "delete Idiomas where Id_Curriculo =" + id;
            HelperDAO.ExecutaSQL(sql, null);
            HelperDAO.ExecutaSQL(sql2, null);
            HelperDAO.ExecutaSQL(sql3, null);
            HelperDAO.ExecutaSQL(sql4, null);
            HelperDAO.ExecutaSQL(sql5, null);
            HelperDAO.ExecutaSQL(sql6, null);
            HelperDAO.ExecutaSQL(sql7, null);
        }


        public int ProximoId()
        {
            string instrucao = "select isnull(max(id) +1, 1) as 'Maior' from Curriculo";
            DataTable table = HelperDAO.ExecutaSelect(instrucao, null);
            return Convert.ToInt32(table.Rows[0]["Maior"]);
        }
    }
}