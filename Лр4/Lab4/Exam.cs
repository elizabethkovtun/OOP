using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4
{
    public class Exam : IXmlSerializable
    {

        private string nameOfExam;

        private int mark = 0;

        private DateTime dateOfExam;
     
        

        public string NameOfExam
        {
            get
            {
                return nameOfExam;
            }
            set
            {
                nameOfExam = value;
            }
        }

        public int Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }                
        }

        public DateTime DateOfExam
        {
            get
            {
                return dateOfExam;
            }
            set
            {
                dateOfExam = value;
            }
        }
       
        public XmlSchema GetSchema()
        {
            return null;
        }
        
        public void ReadXml(XmlReader reader)
        {                      
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                       

                        case "Название":
                            reader.Read();
                            nameOfExam = reader.Value;
                            break;

                        case "Дата екзамена":
                            reader.Read();
                            dateOfExam = DateTime.Parse(reader.Value);
                            break;

                        case "Оценка":
                            reader.Read();
                            mark = Int32.Parse(reader.Value);
                            break;
                    }
                }

                if (reader.Name.Equals("Екзамен"))
                {
                    break;
                }
            }           
        }
       
        public  void WriteXml(XmlWriter writer)
        {
           writer.WriteStartElement("Екзамен");
               writer.WriteElementString("Название", nameOfExam);
               writer.WriteElementString("Оценка", mark.ToString());
               writer.WriteElementString("Дата екзамена", dateOfExam.ToString());          
           writer.WriteEndElement();
        }

        public static List<Exam> ReadArticles(XmlReader reader)
        {
            List<Exam> exams = new List<Exam>();
            reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.IsStartElement() && !reader.Name.Equals("Articles"))
                {
                    Exam exam = new Exam();
                    exam.ReadXml(reader);
                    exams.Add(exam);
                }
                else
                {
                    break;
                }
                    
            }
            return exams;            
        }

        public override string ToString()
        {
            return $" { nameOfExam} {mark} {dateOfExam}";
        }
    }
}
