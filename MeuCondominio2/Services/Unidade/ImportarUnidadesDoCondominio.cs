using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MeuCondominio2.Model;

namespace MeuCondominio2.Services.Unidade
{
    class ImportarUnidadesDoCondominio
    {
        public List<Model.Unidade> ImportarArquivoDeUnidadesDoCondominio(StreamReader reader, int idCondominio)
        {
            List<Model.Unidade> unidadesDoCondominio = new List<Model.Unidade>();

            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                string[] value = linha.Split(';');

                Model.Unidade unidade = new Model.Unidade
                {
                    Identificacao = value[0],
                    QtdVagas = Convert.ToInt32(value[1]),
                    StatusOcupacao = false,
                    StatusInadimplencia = false,
                    IdCondominio = idCondominio
                };

                unidadesDoCondominio.Add(unidade);
            }
            return unidadesDoCondominio;
        }
    }
}
