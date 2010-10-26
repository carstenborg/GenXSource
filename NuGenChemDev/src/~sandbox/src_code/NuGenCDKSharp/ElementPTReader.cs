/* $RCSfile$
* $Author: egonw $
* $Date: 2006-03-29 10:27:08 +0200 (Wed, 29 Mar 2006) $
* $Revision: 5855 $
*
* Copyright (C) 2003-2006  The Chemistry Development Kit (CDK) project
*
* Contact: cdk-devel@lists.sourceforge.net
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU Lesser General Public License
* as published by the Free Software Foundation; either version 2.1
* of the License, or (at your option) any later version.
* All we ask is that proper credit is given for our work, which includes
* - but is not limited to - adding the above copyright notice to the beginning
* of your source code files, and to any copyright notice that you may distribute
* with programs based on this work.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
*
* You should have received a copy of the GNU Lesser General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301 USA.
*/
using System;
using Support;
using System.Collections.Generic;

namespace Org.OpenScience.CDK.Config.Elements
{
    /// <summary> Reader that instantiates an XML parser and customized handler to process
    /// the isotope information in the CML2 isotope data file. The Reader first
    /// tries to instantiate a JAXP XML parser available from Sun JVM 1.4.0 and
    /// later. If not found it tries the Aelfred2 parser, and as last try the
    /// Xerces parser.
    /// 
    /// </summary>
    /// <author>      	   Miguel Rojas
    /// </author>
    /// <cdk.created>     May 8, 2005 </cdk.created>
    /// <cdk.module>      extra </cdk.module>
    public class ElementPTReader
    {
        private XmlSAXDocumentManager parser;
        //UPGRADE_ISSUE: Class hierarchy differences between 'java.io.Reader' and 'System.IO.StreamReader' may cause compilation errors. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1186'"
        private System.IO.StreamReader input;

        //private LoggingTool //logger;

        /// <summary> Instantiates a new reader that parses the XML from the given <code>input</code>.
        /// 
        /// </summary>
        /// <param name="input">Reader with the XML source
        /// </param>
        //UPGRADE_ISSUE: Class hierarchy differences between 'java.io.Reader' and 'System.IO.StreamReader' may cause compilation errors. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1186'"
        public ElementPTReader(System.IO.StreamReader input)
        {
            this.init();
            this.input = input;
        }

        private void init()
        {
            //logger = new LoggingTool(this);
            bool success = false;
            // If JAXP is prefered (comes with Sun JVM 1.4.0 and higher)
            if (!success)
            {
                try
                {
                    XmlSAXDocumentManager spf = XmlSAXDocumentManager.NewInstance();
                    spf.NamespaceAllowed = true;
                    XmlSAXDocumentManager saxParser = XmlSAXDocumentManager.CloneInstance(spf);
                    //UPGRADE_TODO: Method 'javax.xml.parsers.SAXParser.getXMLReader' was converted to 'SupportClass.XmlSAXDocumentManager' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073'"
                    parser = saxParser;
                    //logger.info("Using JAXP/SAX XML parser.");
                    success = true;
                }
                catch (System.Exception exception)
                {
                    //logger.warn("Could not instantiate JAXP/SAX XML reader!");
                    //logger.debug(exception);
                }
            }
            // Aelfred is first alternative.
            if (!success)
            {
                try
                {
                    //UPGRADE_TODO: Method 'java.lang.Class.newInstance' was converted to 'System.Activator.CreateInstance' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javalangClassnewInstance'"
                    //UPGRADE_ISSUE: Method 'java.lang.ClassLoader.loadClass' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangClassLoader'"
                    //UPGRADE_ISSUE: Method 'java.lang.Class.getClassLoader' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangClassgetClassLoader'"
                    parser = new XmlSAXDocumentManager();//(XmlSAXDocumentManager)System.Activator.CreateInstance(this.GetType().getClassLoader().loadClass("gnu.xml.aelfred2.XmlReader"));
                    //logger.info("Using Aelfred2 XML parser.");
                    success = true;
                }
                catch (System.Exception e)
                {
                    //logger.warn("Could not instantiate Aelfred2 XML reader!");
                    //logger.debug(e);
                }
            }
            // Xerces is second alternative
            if (!success)
            {
                try
                {
                    //UPGRADE_TODO: Method 'java.lang.Class.newInstance' was converted to 'System.Activator.CreateInstance' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javalangClassnewInstance'"
                    //UPGRADE_ISSUE: Method 'java.lang.ClassLoader.loadClass' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangClassLoader'"
                    //UPGRADE_ISSUE: Method 'java.lang.Class.getClassLoader' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangClassgetClassLoader'"
                    parser = new XmlSAXDocumentManager();//(XmlSAXDocumentManager)System.Activator.CreateInstance(this.GetType().getClassLoader().loadClass("org.apache.xerces.parsers.SAXParser"));
                    //logger.info("Using Xerces XML parser.");
                    success = true;
                }
                catch (System.Exception e)
                {
                    //logger.warn("Could not instantiate Xerces XML reader!");
                    //logger.debug(e);
                }
            }
            if (!success)
            {
                //logger.error("Could not instantiate any XML parser!");
            }
        }

        /// <summary> Triggers the XML parsing of the data file and returns the read Isotopes. 
        /// It turns of XML validation before parsing.
        /// 
        /// </summary>
        /// <returns> a Vector of Isotope's. Returns an empty vector is some reading error
        /// occured.
        /// </returns>
        public virtual List<PeriodicTableElement> readElements()
        {
            List<PeriodicTableElement> elements = new List<PeriodicTableElement>();
            try
            {
                parser.setFeature("http://xml.org/sax/features/validation", false);
                //logger.info("Deactivated validation");
            }
            //UPGRADE_TODO: Class 'org.xml.sax.SAXException' was converted to 'System.Xml.XmlException' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073'"
            catch (System.Xml.XmlException exception)
            {
                //logger.warn("Cannot deactivate validation: ", exception.Message);
                //logger.debug(exception);
            }
            ElementPTHandler handler = new ElementPTHandler();
            parser.setContentHandler(handler);
            try
            {
                parser.parse(new XmlSourceSupport(input));
                elements = new List<PeriodicTableElement>((PeriodicTableElement[])handler.Elements.ToArray(typeof(PeriodicTableElement)));
            }
            catch (System.IO.IOException exception)
            {
                //UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
                //logger.error("IOException: ", exception.Message);
                //logger.debug(exception);
            }
            //UPGRADE_TODO: Class 'org.xml.sax.SAXException' was converted to 'System.Xml.XmlException' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073'"
            catch (System.Xml.XmlException saxe)
            {
                //UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
                //logger.error("SAXException: ", saxe.GetType().FullName);
                //logger.error(saxe.Message);
                //logger.debug(saxe);
            }
            return elements;
        }
    }
}