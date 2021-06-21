using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bibloteka.BusinessLogicLayer
{
    public class ChangeLanguage
    {
        public void UpdateLang(string key, string value)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            if (xmlDoc.DocumentElement != null)
                foreach (XmlElement el in xmlDoc.DocumentElement)
                {
                    if (el.Name.Equals("appSettings"))
                    {
                        foreach (XmlNode node in el.ChildNodes)
                        {
                            if (node.Attributes != null && node.Attributes[0].Value.Equals(key))
                            {
                                node.Attributes[1].Value = value;
                            }
                        }
                    }
                }
            ConfigurationManager.RefreshSection("appSettings");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
