using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace RedatorSaude.Engine
{
    public class RedatorOpenXml
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainFile"></param>
        /// <param name="sourceFiles"></param>
        /// <param name="destMergedFile"></param>
        public static void MergeDocOpenXml(string mainFile, List<string> sourceFiles, string destMergedFile)
        {
            File.Delete(destMergedFile);
            File.Copy(mainFile, destMergedFile);
            int id = 1;
            foreach (string sourceFile in sourceFiles)
            {
                using (WordprocessingDocument myDoc =
                    WordprocessingDocument.Open(destMergedFile, true))
                {
                    string altChunkId = "AltChunkId" + id;
                    MainDocumentPart mainPart = myDoc.MainDocumentPart;
                    AlternativeFormatImportPart chunk =
                        mainPart.AddAlternativeFormatImportPart(
                        AlternativeFormatImportPartType.WordprocessingML, altChunkId);
                    using (FileStream fileStream = File.Open(sourceFile, FileMode.Open))
                        chunk.FeedData(fileStream);
                    AltChunk altChunk = new AltChunk();
                    altChunk.Id = altChunkId;
                    mainPart.Document
                        .Body
                        .InsertAfter(altChunk, mainPart.Document.Body
                        .Elements<Paragraph>().Last());
                    mainPart.Document.Save();
                    id++;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileDestDoc"></param>
        /// <param name="tag"></param>
        /// <param name="textTarget"></param>
        public static void fillDocOpenXml(string fileDestDoc, string tag, string textTarget)
        {
            using (WordprocessingDocument doc =
                   WordprocessingDocument.Open(fileDestDoc, true))
            {
                var body = doc.MainDocumentPart.Document.Body;
                var paras = body.Elements<Paragraph>();

                foreach (var para in paras)
                {
                    foreach (var run in para.Elements<Run>())
                    {
                        foreach (var text in run.Elements<Text>())
                        {
                            if (text.Text.Contains(tag))
                            {
                                text.Text = text.Text.Replace(tag, textTarget);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileDestDoc"></param>
        /// <param name="tag"></param>
        /// <param name="ListTextTarget"></param>
        public static void fillDocListOpenXml(string fileDestDoc, string tag, List<string> ListTextTarget)
        {
            using (WordprocessingDocument doc =
                   WordprocessingDocument.Open(fileDestDoc, true))
            {
                var body = doc.MainDocumentPart.Document.Body;
                var paras = body.Elements<Paragraph>();

                foreach (var para in paras)
                {
                    foreach (var run in para.Elements<Run>())
                    {
                        foreach (var text in run.Elements<Text>())
                        {
                            if (text.Text.Contains(tag))
                            {
                                int i = 0;
                                foreach (var textTarget in ListTextTarget)
                                {
                                    if (i == 0)
                                    {
                                        text.Text = text.Text.Replace(tag, textTarget);
                                        run.AppendChild(new Break());
                                        run.AppendChild(new Break());
                                        i++;
                                    }
                                    else
                                    {
                                        run.AppendChild(new Text(textTarget));
                                        run.AppendChild(new Break());
                                        run.AppendChild(new Break());
                                        i++;
                                    }

                                }

                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileDestDoc"></param>
        /// <param name="tag"></param>
        /// <param name="textTarget"></param>
        public static void fillDocOpenXml2(string fileDestDoc, string tag, string textTarget)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(fileDestDoc, true))
            {

                var document = doc.MainDocumentPart.Document;

                foreach (var text in document.Descendants<Text>()) // <<< Here
                {
                    if (text.Text.Contains(tag))
                    {
                        text.Text = text.Text.Replace(tag, textTarget);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dest1"></param>
        /// <param name="temp"></param>
        /// <param name="tag"></param>
        /// <param name="textToReplace"></param>
        public static void searchAndReplace(string dest1, string temp, string tag, string textToReplace)
        {
            File.Delete(temp);
            File.Copy(dest1, temp);

            using (WordprocessingDocument wordDoc =
            WordprocessingDocument.Open(temp, true))
            {
                // Insert other code here.
                string docText = null;
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                if (docText.Contains(tag))
                {
                    docText = docText.Replace(tag, textToReplace);
                    docText = docText.Replace("«", "");
                    docText = docText.Replace("»", "");
                }

                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }
            }
        }
    }
}
