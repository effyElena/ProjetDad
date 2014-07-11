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

        public void createPdf(string name, string content, string key, DateTime date, string stat, string email)
        {
            Document nouveauDocument = new Document(); 
 
            try 
            { 
            PdfWriter.GetInstance (nouveauDocument, new 
            FileStream("C:\\wamp\\www\\rapport-pdf\\"+name+".pdf", FileMode.Create)); 
              nouveauDocument.Open();

              nouveauDocument.Add(new Paragraph("Document : " + name + " du : " + date));
              nouveauDocument.Add(new Paragraph(" "));
              nouveauDocument.Add(new Paragraph("La clé utilisé est : " + key));
              nouveauDocument.Add(new Paragraph("Nous avons détécté : " + stat + " % de français"));
              nouveauDocument.Add(new Paragraph("L'email secret : " + email));
              nouveauDocument.Add(new Paragraph(" "));
              nouveauDocument.Add(new Paragraph(content));
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
