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
    public class Person : IXmlSerializable
    {
        private string firstName;

        private string lastName;

        private DateTime dataOfBirth;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            } 
        }

        public DateTime DataOfBirth
        {
            get
            {
                return dataOfBirth;
            }
            set
            {
                dataOfBirth = value;
            }
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
                        case "Имя":
                            reader.Read();
                            firstName = reader.Value;
                            break;

                        case "Фамилия":
                            reader.Read();
                           lastName = reader.Value;
                            break;

                        case "Дата рождения":
                            reader.Read();
                            dataOfBirth = DateTime.Parse(reader.Value);
                            break;
                    }
                }
                if (reader.Name.Equals("Человек"))
                {
                    break;
                }               
            }
        }

        public static List<Person> ReadPersonsList(string fileName)
        {
            List<Person> persons = new List<Person>();
            if (File.Exists(fileName))
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    //jump from root tag
                    reader.MoveToContent();
                    while (reader.Read())
                    {
                        //if we reach closed tag @articles@ we can make stop
                        if (reader.IsStartElement() && !reader.Name.Equals("Человек"))
                        {
                            Person person = new Person();
                            person.ReadXml(reader);
                            persons.Add(person);
                        }
                        else
                        {
                            break;
                        }
                    }
                }               
            }
            return persons;
        }
       
        public void WriteXml(XmlWriter writer)
        {          
            writer.WriteStartElement("Человек");
            writer.WriteElementString("Имя", firstName);
            writer.WriteElementString("Фамилия", lastName);
            writer.WriteElementString("Дата рождения", dataOfBirth.ToString());           
            writer.WriteEndElement();
        }

        public static void WriteAuthorsToFile(string fileName,List<Person> persons)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = false;
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartElement("Челоек");
            persons.ForEach(author =>
            {
                author.WriteXml(xmlWriter);
            });
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public override string ToString()=> $"{firstName} {lastName} {dataOfBirth.Date.ToString("dd/MM/yyyy")}";
        
    }
}
