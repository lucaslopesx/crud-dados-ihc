using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace crud_dados_ihc
{
    class Perguntas
    {
        public int IdPergunta { get; set; }
        public string Categoria { get; set; }
        public string PerguntaA { get; set; }
        public string PerguntaB { get; set; }
        public string PerguntaC { get; set; }
        public string PerguntaD { get; set; }
        public int Resultado { get; set; }


        private Connection connection = new Connection();

        public void Insert()
        {
            string sql = $"Insert into {Categoria} (perguntaA, perguntaB, perguntaC, perguntaD, resultado) values ('{PerguntaA}', '{PerguntaB}', '{PerguntaC}', '{PerguntaD}', '{Resultado}')";
            connection.Execute(sql);
        }
        public void Update()
        {
            string sql = $"update {Categoria} set perguntaA = '{PerguntaA}', perguntaB = '{PerguntaB}', perguntaC = '{PerguntaC}', perguntaD = '{PerguntaD}', resultado = '{Resultado}' where idPergunta = {IdPergunta}";
            connection.Execute(sql);
        }
        public void Delete()
        {
            string sql = $"delete from {Categoria} where idPergunta = {IdPergunta}";
            connection.Execute(sql);
        }
        public void Consult()
        {
            string sql = $"Select * from {Categoria} where idPergunta = {IdPergunta}";

            connection.Consult(sql);
            if (connection.dr.Read())
            {
                PerguntaA = connection.dr["perguntaA"].ToString();
                PerguntaB = connection.dr["perguntaB"].ToString();
                PerguntaC = connection.dr["perguntaC"].ToString();
                PerguntaD = connection.dr["perguntaD"].ToString();
                Resultado = int.Parse(connection.dr["resultado"].ToString());
            }
            connection.Disconnect();
        }
        public DataSet List()
        {
            string sql = $"Select * from {Categoria}";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
        public DataSet ListBy()
        {
            string sql = "";
            connection.ListInfo(sql);
            connection.Disconnect();
            return connection.ds;
        }
    }
}
