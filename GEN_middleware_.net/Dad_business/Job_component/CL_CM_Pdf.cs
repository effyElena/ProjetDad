using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Job_component
{
    public class CL_CM_Pdf
    {
        public CL_CM_Pdf()
        {

        }

        public void createPdf()
        {
            Document nouveauDocument = new Document(); 
 
            try 
            { 
            PdfWriter.GetInstance (nouveauDocument, new 
            FileStream("C:\\wamp\\www\\rapport-pdf\\fichier.pdf", FileMode.Create)); 
              nouveauDocument.Open(); 
              nouveauDocument.Add(new Phrase("hello world")); 
            } 
            catch (DocumentException de) 
            { 
                  Console.WriteLine("error " + de); 
            } 
            catch (System.IO.IOException ioe) 
            { 
                  Console.WriteLine("error " + ioe); 
            } 
                nouveauDocument.Close(); 
        }
    }
}
