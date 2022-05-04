using System;
using RedatorSaude.Models;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using RedatorSaude.Engine;

namespace RedatorSaude.Service
{
    public class DocumentService
    {
        public static Stream CreateSimpleDoc(Document doc)
        {
            Stream stream;
            using (MemoryStream mem = new MemoryStream())
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(mem, DocumentFormat.OpenXml.WordprocessingDocumentType.Document, true))
                {
                    string _mainFile = SimpleDocumentHelper.GetFilePathByType(doc.NomePeca);
                    string _destFile = SimpleDocumentHelper.GetFilePathByType("RESULTADO");
                    Advogado adv = SimpleDocumentHelper.GetAdvogadoByClient(doc.Reu);

                    RedatorOpenXml.searchAndReplace(_mainFile, _destFile, "$VARA$", doc.Vara.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$FORO$", doc.Foro.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$QUALI$", SimpleDocumentHelper.GetQuali(doc.Reu).ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$CIDADE$", doc.Cidade.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$ESTADO$", doc.Estado.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$NUMEROPROCESSO$", doc.NumeroProcesso.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$REU$", doc.Reu.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$AUTOR$", doc.Autor.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$UF$", SimpleDocumentHelper.GetUF(doc.Estado.ToUpper()));
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$DATACRIACAO$", SimpleDocumentHelper.RetornarDataString(DateTime.Now).ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$ADVOGADO$", adv.Nome.ToUpper());
                    RedatorOpenXml.fillDocOpenXml(_destFile, "$OAB$", adv.OAB.ToUpper());

                    stream = new FileStream(_destFile, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                }
                return stream;
            }
        }
    }
}
