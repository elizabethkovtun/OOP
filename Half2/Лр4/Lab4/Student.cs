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
using System.Windows.Forms;

namespace Lab4
{
    public class Student: IXmlSerializable
    {

        private EducationLevel? education = null;

        private Person person;

        private List<Exam> exams = new List<Exam>();

        private int middleMark = 0;

        public Person Person
        {
            get
            {
                return person;
            }
            set
            {
                person = value;
            }
        }

        public EducationLevel? educationLevel
        {
            get
            {
                return education;
            }
            set
            {
                education = value;
            }            
        }

        public List<Exam> Exams
        {
            get
            {
                return exams;
            }
            set
            {
                exams = value;
            }           
        }

        public int MiddleMark
        {
            get
            {
                return middleMark;
            }
            set
            {
                middleMark = value;
            }
        }

        public void AddExam(Exam exam)
        {
            // we can set null by List<Article> Articles setter
            if (exams == null)
            {
                exams = new List<Exam>();
            }
            exams.Add(exam);
        }

          

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();            
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {                   
                    switch (reader.Name)
                    {
                        case "Человек":
                            person = new Person();
                            person.ReadXml(reader);
                            break;

                        case "Учебный уровень":
                            reader.Read();
                            education = (EducationLevel)Enum.Parse(typeof(EducationLevel), reader.Value);
                            break;

                        case "Екзамени":                           
                            exams = Exam.ReadArticles(reader);
                            break;
                    }
                }
                if (reader.Name.Equals("Студент"))
                {
                    break;
                }
            }            
        }

        public static List<Student> ReadStudentList(string fileName)
        {
            List<Student> students = new List<Student>();
            if(File.Exists(fileName))
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    reader.MoveToContent();
                    while (reader.Read())
                    {
                        if (reader.IsStartElement() && !reader.Name.Equals("Journals"))
                        {
                            Student student = new Student();
                            student.ReadXml(reader);
                            students.Add(student);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }                          
            return students;
        }
      
        public void WriteXml(XmlWriter writer)
        { 
            writer.WriteStartElement("Студент");
            writer.WriteElementString("Человек", person.ToString());
            writer.WriteElementString("Учебный уровень", education.ToString());
            writer.WriteStartElement("Студенты");
            if(Exams != null)
            {
                Exams.ForEach(article =>
                {
                    article.WriteXml(writer);
                });
            }          
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        public static  void WriteJournalsToFile(string fileName, List<Student> students)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = false;
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartElement("Студенти");
            students.ForEach(student =>
            {
                student.WriteXml(xmlWriter);
            });
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public override string ToString()
        {
            return $"Человек: {person}\n: Екзамени {exams}\nУчебный уровень: {Enum.GetName(typeof(EducationLevel), education)}";
        }

        public  string ToShortString()
        {
            return $"Фамилия: {person.LastName} Средний бал: {middleMark}";
        }

    }
}
